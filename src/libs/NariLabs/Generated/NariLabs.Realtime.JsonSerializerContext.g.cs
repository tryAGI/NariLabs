
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace NariLabs.Realtime
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesSessionUpdatedMessageTypeJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesSessionUpdatedMessageTypeNullableJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesSessionUpdatedMessageSessionModelJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesSessionUpdatedMessageSessionModelNullableJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguageJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguageNullableJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.ServerVadTypeJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.ServerVadTypeNullableJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesPartialTranscriptMessageTypeJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesPartialTranscriptMessageTypeNullableJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesCompletedTranscriptMessageTypeJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesCompletedTranscriptMessageTypeNullableJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesCompletedTranscriptMessageLanguageJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesCompletedTranscriptMessageLanguageNullableJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesCompletedTranscriptMessageCommitReasonJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesCompletedTranscriptMessageCommitReasonNullableJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesAudioCommittedMessageTypeJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesAudioCommittedMessageTypeNullableJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesSpeechStartedMessageTypeJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesSpeechStartedMessageTypeNullableJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesSpeechStoppedMessageTypeJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesSpeechStoppedMessageTypeNullableJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesErrorEventMessageTypeJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesErrorEventMessageTypeNullableJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesCommitEmptyMessageTypeJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesCommitEmptyMessageTypeNullableJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesSessionUpdateMessageTypeJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesSessionUpdateMessageTypeNullableJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.SessionConfigModelJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.SessionConfigModelNullableJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.SessionConfigLanguageJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.SessionConfigLanguageNullableJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesAudioAppendMessageTypeJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesAudioAppendMessageTypeNullableJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesAudioCommitMessageTypeJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesAudioCommitMessageTypeNullableJsonConverter),

            typeof(global::NariLabs.Realtime.JsonConverters.ServerEventJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.ChannelsRealtimeMessagesSessionUpdatedMessageType), TypeInfoPropertyName = "ChannelsRealtimeMessagesSessionUpdatedMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.ChannelsRealtimeMessagesSessionUpdatedMessageSessionLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.ChannelsRealtimeMessagesSessionUpdatedMessageSessionModel), TypeInfoPropertyName = "ChannelsRealtimeMessagesSessionUpdatedMessageSessionModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage), TypeInfoPropertyName = "ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.ServerVadType), TypeInfoPropertyName = "ServerVadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.ServerVad))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.ChannelsRealtimeMessagesSessionUpdatedMessageSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.RealtimeSessionUpdatedMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.ChannelsRealtimeMessagesPartialTranscriptMessageType), TypeInfoPropertyName = "ChannelsRealtimeMessagesPartialTranscriptMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.RealtimePartialTranscriptMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.ChannelsRealtimeMessagesCompletedTranscriptMessageType), TypeInfoPropertyName = "ChannelsRealtimeMessagesCompletedTranscriptMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage), TypeInfoPropertyName = "ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.ChannelsRealtimeMessagesCompletedTranscriptMessageCommitReason), TypeInfoPropertyName = "ChannelsRealtimeMessagesCompletedTranscriptMessageCommitReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.ChannelsRealtimeMessagesCompletedTranscriptMessageUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.RealtimeCompletedTranscriptMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.ChannelsRealtimeMessagesAudioCommittedMessageType), TypeInfoPropertyName = "ChannelsRealtimeMessagesAudioCommittedMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.RealtimeAudioCommittedMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.ChannelsRealtimeMessagesSpeechStartedMessageType), TypeInfoPropertyName = "ChannelsRealtimeMessagesSpeechStartedMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.RealtimeSpeechStartedMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.ChannelsRealtimeMessagesSpeechStoppedMessageType), TypeInfoPropertyName = "ChannelsRealtimeMessagesSpeechStoppedMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.RealtimeSpeechStoppedMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.ChannelsRealtimeMessagesErrorEventMessageType), TypeInfoPropertyName = "ChannelsRealtimeMessagesErrorEventMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.ChannelsRealtimeMessagesErrorEventMessageError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.RealtimeErrorEventMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.ChannelsRealtimeMessagesCommitEmptyMessageType), TypeInfoPropertyName = "ChannelsRealtimeMessagesCommitEmptyMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.RealtimeCommitEmptyMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.ChannelsRealtimeMessagesSessionUpdateMessageType), TypeInfoPropertyName = "ChannelsRealtimeMessagesSessionUpdateMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.SessionConfigModel), TypeInfoPropertyName = "SessionConfigModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.SessionConfigLanguage), TypeInfoPropertyName = "SessionConfigLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.SessionConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.RealtimeSessionUpdateMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.ChannelsRealtimeMessagesAudioAppendMessageType), TypeInfoPropertyName = "ChannelsRealtimeMessagesAudioAppendMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.RealtimeAudioAppendMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.ChannelsRealtimeMessagesAudioCommitMessageType), TypeInfoPropertyName = "ChannelsRealtimeMessagesAudioCommitMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.RealtimeAudioCommitMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Realtime.ServerEvent), TypeInfoPropertyName = "ServerEvent2")]
    public sealed partial class RealtimeSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}