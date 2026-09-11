
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RealtimePartialTranscriptMessage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesPartialTranscriptMessageTypeJsonConverter))]
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesPartialTranscriptMessageType Type { get; set; }

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
        /// Current text for this utterance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Transcript { get; set; }

        /// <summary>
        /// Increasing revision number for this utterance. Intermediate revisions may be skipped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Revision { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimePartialTranscriptMessage" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Unique identifier of this event.
        /// </param>
        /// <param name="itemId">
        /// Utterance identifier shared by its boundary and transcript events.
        /// </param>
        /// <param name="transcript">
        /// Current text for this utterance.
        /// </param>
        /// <param name="revision">
        /// Increasing revision number for this utterance. Intermediate revisions may be skipped.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimePartialTranscriptMessage(
            string eventId,
            string itemId,
            string transcript,
            int revision,
            global::NariLabs.Realtime.ChannelsRealtimeMessagesPartialTranscriptMessageType type)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.Revision = revision;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimePartialTranscriptMessage" /> class.
        /// </summary>
        public RealtimePartialTranscriptMessage()
        {
        }

    }
}