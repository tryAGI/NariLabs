
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
        public bool? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.RealtimeSessionUpdatedMessage? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesPartialTranscriptMessageType? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.RealtimePartialTranscriptMessage? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesCompletedTranscriptMessageType? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesCompletedTranscriptMessageCommitReason? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesCompletedTranscriptMessageUsage? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.RealtimeCompletedTranscriptMessage? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesWordTimestampsMessageType? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.WordTimestamp? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.RealtimeWordTimestampsMessage? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::NariLabs.Realtime.WordTimestamp>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesWordTimestampsFailedMessageType? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesWordTimestampsFailedMessageError? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.RealtimeWordTimestampsFailedMessage? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesAudioCommittedMessageType? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.RealtimeAudioCommittedMessage? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesSpeechStartedMessageType? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.RealtimeSpeechStartedMessage? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesSpeechStoppedMessageType? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.RealtimeSpeechStoppedMessage? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesErrorEventMessageType? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesErrorEventMessageError? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.RealtimeErrorEventMessage? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesCommitEmptyMessageType? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.RealtimeCommitEmptyMessage? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesSessionUpdateMessageType? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.SessionConfigModel? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.SessionConfigLanguage? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.SessionConfig? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.RealtimeSessionUpdateMessage? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesAudioAppendMessageType? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.RealtimeAudioAppendMessage? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesAudioCommitMessageType? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.RealtimeAudioCommitMessage? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.ServerEvent? Type47 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::NariLabs.Realtime.WordTimestamp>? ListType0 { get; set; }
    }
}