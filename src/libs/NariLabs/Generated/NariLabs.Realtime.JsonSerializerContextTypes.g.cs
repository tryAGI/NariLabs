
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace NariLabs.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesSessionUpdatedMessageType? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesSessionUpdatedMessageSessionLimits? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesSessionUpdatedMessageSessionModel? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ServerVadType? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ServerVad? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesSessionUpdatedMessageSession? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.RealtimeSessionUpdatedMessage? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesPartialTranscriptMessageType? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.RealtimePartialTranscriptMessage? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesCompletedTranscriptMessageType? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesCompletedTranscriptMessageCommitReason? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesCompletedTranscriptMessageUsage? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.RealtimeCompletedTranscriptMessage? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesAudioCommittedMessageType? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.RealtimeAudioCommittedMessage? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesSpeechStartedMessageType? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.RealtimeSpeechStartedMessage? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesSpeechStoppedMessageType? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.RealtimeSpeechStoppedMessage? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesErrorEventMessageType? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesErrorEventMessageError? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.RealtimeErrorEventMessage? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesCommitEmptyMessageType? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.RealtimeCommitEmptyMessage? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesSessionUpdateMessageType? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.SessionConfigModel? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.SessionConfigLanguage? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.SessionConfig? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.RealtimeSessionUpdateMessage? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesAudioAppendMessageType? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.RealtimeAudioAppendMessage? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesAudioCommitMessageType? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.RealtimeAudioCommitMessage? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ServerEvent? Type39 { get; set; }

    }
}