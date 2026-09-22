
#nullable enable

namespace NariLabs.Realtime
{
    public sealed partial class NariLabsRealtimeClient
    {
        /// <summary>
        /// Receives updates from the WebSocket connection as an async enumerable.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token.</param>
        /// <returns>An async enumerable of server events.</returns>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::NariLabs.Realtime.ServerEvent> ReceiveUpdatesAsync(
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            if (!IsConnected)
            {
                await ConnectAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
            }

            var buffer = new byte[1024 * 1024]; // 1MB buffer size
            var arraySegment = new global::System.ArraySegment<byte>(buffer);

            while (_clientWebSocket.State == global::System.Net.WebSockets.WebSocketState.Open)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    yield break;
                }

                using var __messageBuffer = new global::System.IO.MemoryStream();
                var __receivedTextMessage = false;

                while (true)
                {
                    global::System.Net.WebSockets.WebSocketReceiveResult result;

                    try
                    {
                        result = await _clientWebSocket.ReceiveAsync(arraySegment, cancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.WebSockets.WebSocketException exception)
                    {
                        RaiseException(exception);
                        var rethrow = false;
                        OnReceiveException(exception, ref rethrow);
                        if (await TryReconnectAsync(exception, cancellationToken).ConfigureAwait(false))
                        {
                            continue;
                        }

                        if (rethrow)
                        {
                            throw;
                        }

                        yield break;
                    }
                    catch (global::System.OperationCanceledException exception)
                    {
                        if (!cancellationToken.IsCancellationRequested)
                        {
                            RaiseException(exception);
                        }

                        var rethrow = false;
                        OnReceiveException(exception, ref rethrow);
                        if (rethrow)
                        {
                            throw;
                        }

                        yield break;
                    }

                    if (result.MessageType == global::System.Net.WebSockets.WebSocketMessageType.Close)
                    {
                        RaiseClosed(result.CloseStatus, result.CloseStatusDescription);
                        await _clientWebSocket.CloseAsync(
                            closeStatus: global::System.Net.WebSockets.WebSocketCloseStatus.NormalClosure,
                            statusDescription: "Closing",
                            cancellationToken: cancellationToken).ConfigureAwait(false);
                        yield break;
                    }

                    if (result.MessageType == global::System.Net.WebSockets.WebSocketMessageType.Text)
                    {
                        __receivedTextMessage = true;

                        if (result.Count > 0)
                        {
                            __messageBuffer.Write(buffer, 0, result.Count);
                        }
                    }

                    if (result.EndOfMessage)
                    {
                        break;
                    }
                }

                if (!__receivedTextMessage)
                {
                    continue;
                }

                string json = global::System.Text.Encoding.UTF8.GetString(__messageBuffer.ToArray());
                    global::NariLabs.Realtime.ServerEvent @event;
                    try
                    {
                        @event = (global::NariLabs.Realtime.ServerEvent)global::System.Text.Json.JsonSerializer.Deserialize(json, typeof(global::NariLabs.Realtime.ServerEvent), JsonSerializerContext)!;
                    }
                    catch (global::System.Exception exception) when (
                        exception is global::System.Text.Json.JsonException ||
                        exception is global::System.NotSupportedException ||
                        exception is global::System.InvalidOperationException)
                    {
                        var rethrow = false;
                        OnReceiveException(exception, ref rethrow);
                        DispatchUnknownMessage(json);
                        if (rethrow)
                        {
                            throw;
                        }

                        continue;
                    }

                    DispatchReceivedMessage(@event, json);
                    yield return @event;
            }
        }


        private static global::System.Text.Json.JsonElement? TryParseMessageJson(
            string rawText)
        {
            try
            {
                using var document = global::System.Text.Json.JsonDocument.Parse(rawText);
                return document.RootElement.Clone();
            }
            catch (global::System.Text.Json.JsonException)
            {
                return null;
            }
        }

        private void DispatchUnknownMessage(
            string rawText)
        {
            UnknownMessage?.Invoke(
                this,
                new AutoSDKWebSocketUnknownMessageEventArgs(
                    rawText,
                    TryParseMessageJson(rawText)));
        }

        private void DispatchReceivedMessage(
            global::NariLabs.Realtime.ServerEvent @event,
            string rawText)
        {
            var json = TryParseMessageJson(rawText);
            MessageReceived?.Invoke(
                this,
                new AutoSDKWebSocketMessageEventArgs<global::NariLabs.Realtime.ServerEvent>(
                    @event,
                    rawText,
                    json));

            if (@event.RealtimeSessionUpdatedMessage is { } __SessionUpdatedMessageReceived)
            {
                SessionUpdatedMessageReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::NariLabs.Realtime.RealtimeSessionUpdatedMessage>(
                        __SessionUpdatedMessageReceived,
                        rawText,
                        json));
            }
            if (@event.RealtimePartialTranscriptMessage is { } __PartialTranscriptMessageReceived)
            {
                PartialTranscriptMessageReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::NariLabs.Realtime.RealtimePartialTranscriptMessage>(
                        __PartialTranscriptMessageReceived,
                        rawText,
                        json));
            }
            if (@event.RealtimeCompletedTranscriptMessage is { } __CompletedTranscriptMessageReceived)
            {
                CompletedTranscriptMessageReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::NariLabs.Realtime.RealtimeCompletedTranscriptMessage>(
                        __CompletedTranscriptMessageReceived,
                        rawText,
                        json));
            }
            if (@event.RealtimeWordTimestampsMessage is { } __WordTimestampsMessageReceived)
            {
                WordTimestampsMessageReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::NariLabs.Realtime.RealtimeWordTimestampsMessage>(
                        __WordTimestampsMessageReceived,
                        rawText,
                        json));
            }
            if (@event.RealtimeWordTimestampsFailedMessage is { } __WordTimestampsFailedMessageReceived)
            {
                WordTimestampsFailedMessageReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::NariLabs.Realtime.RealtimeWordTimestampsFailedMessage>(
                        __WordTimestampsFailedMessageReceived,
                        rawText,
                        json));
            }
            if (@event.RealtimeAudioCommittedMessage is { } __AudioCommittedMessageReceived)
            {
                AudioCommittedMessageReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::NariLabs.Realtime.RealtimeAudioCommittedMessage>(
                        __AudioCommittedMessageReceived,
                        rawText,
                        json));
            }
            if (@event.RealtimeSpeechStartedMessage is { } __SpeechStartedMessageReceived)
            {
                SpeechStartedMessageReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::NariLabs.Realtime.RealtimeSpeechStartedMessage>(
                        __SpeechStartedMessageReceived,
                        rawText,
                        json));
            }
            if (@event.RealtimeSpeechStoppedMessage is { } __SpeechStoppedMessageReceived)
            {
                SpeechStoppedMessageReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::NariLabs.Realtime.RealtimeSpeechStoppedMessage>(
                        __SpeechStoppedMessageReceived,
                        rawText,
                        json));
            }
            if (@event.RealtimeErrorEventMessage is { } __ErrorEventMessageReceived)
            {
                ErrorEventMessageReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::NariLabs.Realtime.RealtimeErrorEventMessage>(
                        __ErrorEventMessageReceived,
                        rawText,
                        json));
            }
            if (@event.RealtimeCommitEmptyMessage is { } __CommitEmptyMessageReceived)
            {
                CommitEmptyMessageReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::NariLabs.Realtime.RealtimeCommitEmptyMessage>(
                        __CommitEmptyMessageReceived,
                        rawText,
                        json));
            }
        }
    }
}