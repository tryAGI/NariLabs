
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RealtimeAudioCommittedMessage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesAudioCommittedMessageTypeJsonConverter))]
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesAudioCommittedMessageType Type { get; set; }

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
        /// Previously committed utterance on this connection, or null for the first. It identifies an utterance, not the previous WebSocket event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_item_id")]
        public string? PreviousItemId { get; set; }

        /// <summary>
        /// Client commit event_id when supplied. May be null or omitted when there is no client event to correlate, including automatic commits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_event_id")]
        public string? ClientEventId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeAudioCommittedMessage" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Unique identifier of this event.
        /// </param>
        /// <param name="itemId">
        /// Utterance identifier shared by its boundary and transcript events.
        /// </param>
        /// <param name="type"></param>
        /// <param name="previousItemId">
        /// Previously committed utterance on this connection, or null for the first. It identifies an utterance, not the previous WebSocket event.
        /// </param>
        /// <param name="clientEventId">
        /// Client commit event_id when supplied. May be null or omitted when there is no client event to correlate, including automatic commits.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeAudioCommittedMessage(
            string eventId,
            string itemId,
            global::NariLabs.Realtime.ChannelsRealtimeMessagesAudioCommittedMessageType type,
            string? previousItemId,
            string? clientEventId)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.PreviousItemId = previousItemId;
            this.ClientEventId = clientEventId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeAudioCommittedMessage" /> class.
        /// </summary>
        public RealtimeAudioCommittedMessage()
        {
        }

    }
}