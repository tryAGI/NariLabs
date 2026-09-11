
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RealtimeCommitEmptyMessage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesCommitEmptyMessageTypeJsonConverter))]
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesCommitEmptyMessageType Type { get; set; }

        /// <summary>
        /// Unique identifier of this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// Any type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object ItemId { get; set; }

        /// <summary>
        /// Client commit event_id, or null when the client did not supply one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_event_id")]
        public string? ClientEventId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeCommitEmptyMessage" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Unique identifier of this event.
        /// </param>
        /// <param name="itemId">
        /// Any type
        /// </param>
        /// <param name="type"></param>
        /// <param name="clientEventId">
        /// Client commit event_id, or null when the client did not supply one.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeCommitEmptyMessage(
            string eventId,
            object itemId,
            global::NariLabs.Realtime.ChannelsRealtimeMessagesCommitEmptyMessageType type,
            string? clientEventId)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.ClientEventId = clientEventId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeCommitEmptyMessage" /> class.
        /// </summary>
        public RealtimeCommitEmptyMessage()
        {
        }

    }
}