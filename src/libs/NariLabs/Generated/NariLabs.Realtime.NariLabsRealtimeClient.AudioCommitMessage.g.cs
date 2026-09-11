
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
        public async global::System.Threading.Tasks.Task SendAudioCommitMessageAsync(
            global::NariLabs.Realtime.RealtimeAudioCommitMessage message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::NariLabs.Realtime.RealtimeAudioCommitMessage), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}