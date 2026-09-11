
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RealtimeAudioCommitMessage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesAudioCommitMessageTypeJsonConverter))]
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesAudioCommitMessageType Type { get; set; }

        /// <summary>
        /// Optional client identifier echoed as client_event_id in committed or commit_empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeAudioCommitMessage" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="eventId">
        /// Optional client identifier echoed as client_event_id in committed or commit_empty.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeAudioCommitMessage(
            global::NariLabs.Realtime.ChannelsRealtimeMessagesAudioCommitMessageType type,
            string? eventId)
        {
            this.Type = type;
            this.EventId = eventId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeAudioCommitMessage" /> class.
        /// </summary>
        public RealtimeAudioCommitMessage()
        {
        }

    }
}