
#nullable enable

namespace NariLabs.Realtime
{
    public sealed partial class NariLabsRealtimeClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendAudioAppendMessageAsync(
            global::NariLabs.Realtime.RealtimeAudioAppendMessage message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::NariLabs.Realtime.RealtimeAudioAppendMessage), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }


        /// <summary>
        /// Base64 of nonempty raw 16 kHz mono PCM16 little-endian samples, without a WAV header. Use whole two-byte samples and keep each complete JSON message within 128 KiB.
        /// </summary>
        /// <param name="audio">The binary payload to send.</param>
        /// <param name="type"></param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public global::System.Threading.Tasks.Task SendAudioAppendMessageAsync(
            global::System.ReadOnlyMemory<byte> audio,
            global::NariLabs.Realtime.ChannelsRealtimeMessagesAudioAppendMessageType type = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            return SendAudioAppendMessageAsync(
                new global::NariLabs.Realtime.RealtimeAudioAppendMessage
                {
                Audio = global::System.Convert.ToBase64String(audio.Span),
                Type = type,
                },
                cancellationToken);
        }
    }
}