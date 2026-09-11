
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RealtimeSpeechStoppedMessage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesSpeechStoppedMessageTypeJsonConverter))]
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesSpeechStoppedMessageType Type { get; set; }

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
        /// Milliseconds from the start of all audio received on this connection; does not reset after commit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_end_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AudioEndMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSpeechStoppedMessage" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Unique identifier of this event.
        /// </param>
        /// <param name="itemId">
        /// Utterance identifier shared by its boundary and transcript events.
        /// </param>
        /// <param name="audioEndMs">
        /// Milliseconds from the start of all audio received on this connection; does not reset after commit.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSpeechStoppedMessage(
            string eventId,
            string itemId,
            int audioEndMs,
            global::NariLabs.Realtime.ChannelsRealtimeMessagesSpeechStoppedMessageType type)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.AudioEndMs = audioEndMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSpeechStoppedMessage" /> class.
        /// </summary>
        public RealtimeSpeechStoppedMessage()
        {
        }

    }
}