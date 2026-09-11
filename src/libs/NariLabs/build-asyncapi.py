#!/usr/bin/env python3
"""Convert Nari Labs' published AsyncAPI 2.6 document to AutoSDK's 3.0 client shape."""

from __future__ import annotations

import argparse
from pathlib import Path
from urllib.parse import urlsplit

import yaml


def parse_args() -> argparse.Namespace:
    parser = argparse.ArgumentParser()
    parser.add_argument("source", type=Path)
    parser.add_argument("output", type=Path)
    return parser.parse_args()


def main() -> None:
    args = parse_args()
    source = yaml.safe_load(args.source.read_text(encoding="utf-8"))

    if source.get("asyncapi") != "2.6.0":
        raise SystemExit("error: expected Nari Labs AsyncAPI version 2.6.0")

    source_channels = source.get("channels", {})
    if len(source_channels) != 1:
        raise SystemExit("error: expected exactly one realtime channel")

    address, source_channel = next(iter(source_channels.items()))
    source_messages = source.get("components", {}).get("messages", {})
    if not source_messages:
        raise SystemExit("error: upstream AsyncAPI contains no component messages")

    messages: dict[str, object] = {}
    directions: list[tuple[str, str]] = []
    for operation_name, action in (("publish", "receive"), ("subscribe", "send")):
        operation = source_channel.get(operation_name, {})
        variants = operation.get("message", {}).get("oneOf", [])
        if not variants:
            raise SystemExit(f"error: channel {operation_name} contains no messages")

        for variant in variants:
            reference = variant.get("$ref", "")
            prefix = "#/components/messages/"
            if not reference.startswith(prefix):
                raise SystemExit(f"error: unsupported message reference: {reference}")

            source_key = reference.removeprefix(prefix)
            message = source_messages.get(source_key)
            if not isinstance(message, dict) or not message.get("name"):
                raise SystemExit(f"error: unresolved or unnamed message: {source_key}")

            message_name = message["name"]
            if message_name in messages:
                raise SystemExit(f"error: duplicate message name: {message_name}")

            messages[message_name] = message
            directions.append((action, message_name))

    source_servers = source.get("servers", {})
    if len(source_servers) != 1:
        raise SystemExit("error: expected exactly one realtime server")

    server_name, source_server = next(iter(source_servers.items()))
    server_url = urlsplit(source_server.get("url", ""))
    if server_url.scheme != "wss" or not server_url.netloc:
        raise SystemExit("error: expected a wss production server URL")

    channel_name = "realtimeTranscription"
    channel_messages = {
        name: {"$ref": f"#/components/messages/{name}"} for name in messages
    }
    operations = {
        f"{action}{message_name}": {
            "action": action,
            "channel": {"$ref": f"#/channels/{channel_name}"},
            "messages": [
                {"$ref": f"#/channels/{channel_name}/messages/{message_name}"}
            ],
        }
        for action, message_name in directions
    }

    description = source_channel.get("description", "")
    converted = {
        "asyncapi": "3.0.0",
        "info": {
            **source["info"],
            "description": (
                "Generated from Nari Labs' published AsyncAPI 2.6 contract without "
                "changing its message schemas.\n\n" + description
            ),
        },
        "servers": {
            server_name: {
                "host": server_url.netloc,
                "pathname": server_url.path or "/",
                "protocol": source_server.get("protocol", "wss"),
                "description": source_server.get(
                    "description", "Nari Labs production WebSocket server."
                ),
                "security": [{"$ref": "#/components/securitySchemes/bearer"}],
            }
        },
        "channels": {
            channel_name: {
                "address": address,
                "description": description,
                "servers": [{"$ref": f"#/servers/{server_name}"}],
                "messages": channel_messages,
            }
        },
        "operations": operations,
        "components": {
            **source.get("components", {}),
            "securitySchemes": {
                "bearer": {
                    "type": "http",
                    "scheme": "bearer",
                    "description": "Nari Labs API key as a Bearer token.",
                }
            },
            "messages": messages,
        },
    }

    args.output.write_text(
        yaml.safe_dump(converted, sort_keys=False, allow_unicode=True),
        encoding="utf-8",
    )


if __name__ == "__main__":
    main()
