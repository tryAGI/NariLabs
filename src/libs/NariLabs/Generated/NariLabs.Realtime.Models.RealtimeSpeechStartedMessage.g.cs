
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RealtimeSpeechStartedMessage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesSpeechStartedMessageTypeJsonConverter))]
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesSpeechStartedMessageType Type { get; set; }

        /// <summary>
        /// Unique identifier of this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// Utterance identifier shared by its boundary and transcript events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// Milliseconds from the start of all audio received on this connection; does not reset after commit. Includes configured prefix padding, clamped to the current VAD window start.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_start_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AudioStartMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSpeechStartedMessage" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Unique identifier of this event.
        /// </param>
        /// <param name="itemId">
        /// Utterance identifier shared by its boundary and transcript events.
        /// </param>
        /// <param name="audioStartMs">
        /// Milliseconds from the start of all audio received on this connection; does not reset after commit. Includes configured prefix padding, clamped to the current VAD window start.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSpeechStartedMessage(
            string eventId,
            string itemId,
            int audioStartMs,
            global::NariLabs.Realtime.ChannelsRealtimeMessagesSpeechStartedMessageType type)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.AudioStartMs = audioStartMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSpeechStartedMessage" /> class.
        /// </summary>
        public RealtimeSpeechStartedMessage()
        {
        }

    }
}