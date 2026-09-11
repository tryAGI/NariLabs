#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

install_autosdk_cli
rm -rf Generated

fetch_spec https://docs.narilabs.com/openapi/text-to-speech.yaml -o openapi.yaml
fetch_spec https://docs.narilabs.com/asyncapi.yaml -o asyncapi-source.yaml

python3 -c "import yaml" 2>/dev/null || \
  python3 -m pip install --quiet --user --break-system-packages pyyaml
python3 build-asyncapi.py asyncapi-source.yaml asyncapi.yaml

autosdk generate openapi.yaml \
  --namespace NariLabs \
  --clientClassName NariLabsClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --generate-http-exception-hierarchy \
  --generate-retry-handler \
  --security-scheme Http:Header:Bearer \
  --auth-env-var NARI_API_KEY \
  --base-url https://api.narilabs.com

autosdk generate asyncapi.yaml \
  --namespace NariLabs.Realtime \
  --websocket-class-name NariLabsRealtimeClient \
  --json-serializer-context RealtimeSourceGenerationContext \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme Http:Header:Bearer \
  --auth-env-var NARI_API_KEY \
  --base-url wss://api.narilabs.com
