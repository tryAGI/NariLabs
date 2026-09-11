
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RealtimeAudioAppendMessage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesAudioAppendMessageTypeJsonConverter))]
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesAudioAppendMessageType Type { get; set; }

        /// <summary>
        /// Base64 of nonempty raw 16 kHz mono PCM16 little-endian samples, without a WAV header. Use whole two-byte samples and keep each complete JSON message within 128 KiB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeAudioAppendMessage" /> class.
        /// </summary>
        /// <param name="audio">
        /// Base64 of nonempty raw 16 kHz mono PCM16 little-endian samples, without a WAV header. Use whole two-byte samples and keep each complete JSON message within 128 KiB.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeAudioAppendMessage(
            string audio,
            global::NariLabs.Realtime.ChannelsRealtimeMessagesAudioAppendMessageType type)
        {
            this.Type = type;
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeAudioAppendMessage" /> class.
        /// </summary>
        public RealtimeAudioAppendMessage()
        {
        }

    }
}