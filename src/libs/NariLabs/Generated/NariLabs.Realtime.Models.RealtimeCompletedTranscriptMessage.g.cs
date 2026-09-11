
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RealtimeCompletedTranscriptMessage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesCompletedTranscriptMessageTypeJsonConverter))]
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesCompletedTranscriptMessageType Type { get; set; }

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
        /// Final text for this utterance; may be empty if no speech was recognized.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Transcript { get; set; }

        /// <summary>
        /// Recognized language code, or null if undetermined.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesCompletedTranscriptMessageLanguageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::NariLabs.Realtime.ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage Language { get; set; }

        /// <summary>
        /// What finalized the utterance — client commit, VAD boundary, or accepted-audio duration limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesCompletedTranscriptMessageCommitReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::NariLabs.Realtime.ChannelsRealtimeMessagesCompletedTranscriptMessageCommitReason CommitReason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::NariLabs.Realtime.ChannelsRealtimeMessagesCompletedTranscriptMessageUsage Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeCompletedTranscriptMessage" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Unique identifier of this event.
        /// </param>
        /// <param name="itemId">
        /// Utterance identifier shared by its boundary and transcript events.
        /// </param>
        /// <param name="transcript">
        /// Final text for this utterance; may be empty if no speech was recognized.
        /// </param>
        /// <param name="language">
        /// Recognized language code, or null if undetermined.
        /// </param>
        /// <param name="commitReason">
        /// What finalized the utterance — client commit, VAD boundary, or accepted-audio duration limit.
        /// </param>
        /// <param name="usage"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeCompletedTranscriptMessage(
            string eventId,
            string itemId,
            string transcript,
            global::NariLabs.Realtime.ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage language,
            global::NariLabs.Realtime.ChannelsRealtimeMessagesCompletedTranscriptMessageCommitReason commitReason,
            global::NariLabs.Realtime.ChannelsRealtimeMessagesCompletedTranscriptMessageUsage usage,
            global::NariLabs.Realtime.ChannelsRealtimeMessagesCompletedTranscriptMessageType type)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.Language = language;
            this.CommitReason = commitReason;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeCompletedTranscriptMessage" /> class.
        /// </summary>
        public RealtimeCompletedTranscriptMessage()
        {
        }

    }
}