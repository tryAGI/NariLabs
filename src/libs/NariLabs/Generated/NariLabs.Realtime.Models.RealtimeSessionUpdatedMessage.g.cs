
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RealtimeSessionUpdatedMessage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesSessionUpdatedMessageTypeJsonConverter))]
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesSessionUpdatedMessageType Type { get; set; }

        /// <summary>
        /// Unique identifier of this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::NariLabs.Realtime.ChannelsRealtimeMessagesSessionUpdatedMessageSession Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionUpdatedMessage" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Unique identifier of this event.
        /// </param>
        /// <param name="session"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSessionUpdatedMessage(
            string eventId,
            global::NariLabs.Realtime.ChannelsRealtimeMessagesSessionUpdatedMessageSession session,
            global::NariLabs.Realtime.ChannelsRealtimeMessagesSessionUpdatedMessageType type)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionUpdatedMessage" /> class.
        /// </summary>
        public RealtimeSessionUpdatedMessage()
        {
        }

    }
}