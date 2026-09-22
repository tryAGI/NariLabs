#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace NariLabs.Realtime.JsonConverters
{
    /// <inheritdoc />
    public class ServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::NariLabs.Realtime.ServerEvent>
    {
        /// <inheritdoc />
        public override global::NariLabs.Realtime.ServerEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("event_id")) __score0++;
            if (__jsonProps.Contains("session")) __score0++;
            if (__jsonProps.Contains("session.id")) __score0++;
            if (__jsonProps.Contains("session.language")) __score0++;
            if (__jsonProps.Contains("session.limits")) __score0++;
            if (__jsonProps.Contains("session.model")) __score0++;
            if (__jsonProps.Contains("session.prompt")) __score0++;
            if (__jsonProps.Contains("session.turn_detection")) __score0++;
            if (__jsonProps.Contains("session.word_timestamps")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("event_id")) __score1++;
            if (__jsonProps.Contains("item_id")) __score1++;
            if (__jsonProps.Contains("revision")) __score1++;
            if (__jsonProps.Contains("transcript")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("commit_reason")) __score2++;
            if (__jsonProps.Contains("event_id")) __score2++;
            if (__jsonProps.Contains("item_id")) __score2++;
            if (__jsonProps.Contains("language")) __score2++;
            if (__jsonProps.Contains("transcript")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("usage")) __score2++;
            if (__jsonProps.Contains("usage.input_audio_seconds")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("event_id")) __score3++;
            if (__jsonProps.Contains("item_id")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("words")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("error")) __score4++;
            if (__jsonProps.Contains("error.code")) __score4++;
            if (__jsonProps.Contains("error.message")) __score4++;
            if (__jsonProps.Contains("error.requestId")) __score4++;
            if (__jsonProps.Contains("event_id")) __score4++;
            if (__jsonProps.Contains("item_id")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("client_event_id")) __score5++;
            if (__jsonProps.Contains("event_id")) __score5++;
            if (__jsonProps.Contains("item_id")) __score5++;
            if (__jsonProps.Contains("previous_item_id")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("audio_start_ms")) __score6++;
            if (__jsonProps.Contains("event_id")) __score6++;
            if (__jsonProps.Contains("item_id")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("audio_end_ms")) __score7++;
            if (__jsonProps.Contains("event_id")) __score7++;
            if (__jsonProps.Contains("item_id")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("error")) __score8++;
            if (__jsonProps.Contains("error.code")) __score8++;
            if (__jsonProps.Contains("error.message")) __score8++;
            if (__jsonProps.Contains("error.requestId")) __score8++;
            if (__jsonProps.Contains("event_id")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("client_event_id")) __score9++;
            if (__jsonProps.Contains("event_id")) __score9++;
            if (__jsonProps.Contains("item_id")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }

            global::NariLabs.Realtime.RealtimeSessionUpdatedMessage? realtimeSessionUpdatedMessage = default;
            global::NariLabs.Realtime.RealtimePartialTranscriptMessage? realtimePartialTranscriptMessage = default;
            global::NariLabs.Realtime.RealtimeCompletedTranscriptMessage? realtimeCompletedTranscriptMessage = default;
            global::NariLabs.Realtime.RealtimeWordTimestampsMessage? realtimeWordTimestampsMessage = default;
            global::NariLabs.Realtime.RealtimeWordTimestampsFailedMessage? realtimeWordTimestampsFailedMessage = default;
            global::NariLabs.Realtime.RealtimeAudioCommittedMessage? realtimeAudioCommittedMessage = default;
            global::NariLabs.Realtime.RealtimeSpeechStartedMessage? realtimeSpeechStartedMessage = default;
            global::NariLabs.Realtime.RealtimeSpeechStoppedMessage? realtimeSpeechStoppedMessage = default;
            global::NariLabs.Realtime.RealtimeErrorEventMessage? realtimeErrorEventMessage = default;
            global::NariLabs.Realtime.RealtimeCommitEmptyMessage? realtimeCommitEmptyMessage = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::NariLabs.Realtime.RealtimeSessionUpdatedMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::NariLabs.Realtime.RealtimeSessionUpdatedMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::NariLabs.Realtime.RealtimeSessionUpdatedMessage).Name}");
                        realtimeSessionUpdatedMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::NariLabs.Realtime.RealtimePartialTranscriptMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::NariLabs.Realtime.RealtimePartialTranscriptMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::NariLabs.Realtime.RealtimePartialTranscriptMessage).Name}");
                        realtimePartialTranscriptMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::NariLabs.Realtime.RealtimeCompletedTranscriptMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::NariLabs.Realtime.RealtimeCompletedTranscriptMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::NariLabs.Realtime.RealtimeCompletedTranscriptMessage).Name}");
                        realtimeCompletedTranscriptMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::NariLabs.Realtime.RealtimeWordTimestampsMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::NariLabs.Realtime.RealtimeWordTimestampsMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::NariLabs.Realtime.RealtimeWordTimestampsMessage).Name}");
                        realtimeWordTimestampsMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::NariLabs.Realtime.RealtimeWordTimestampsFailedMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::NariLabs.Realtime.RealtimeWordTimestampsFailedMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::NariLabs.Realtime.RealtimeWordTimestampsFailedMessage).Name}");
                        realtimeWordTimestampsFailedMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::NariLabs.Realtime.RealtimeAudioCommittedMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::NariLabs.Realtime.RealtimeAudioCommittedMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::NariLabs.Realtime.RealtimeAudioCommittedMessage).Name}");
                        realtimeAudioCommittedMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::NariLabs.Realtime.RealtimeSpeechStartedMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::NariLabs.Realtime.RealtimeSpeechStartedMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::NariLabs.Realtime.RealtimeSpeechStartedMessage).Name}");
                        realtimeSpeechStartedMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::NariLabs.Realtime.RealtimeSpeechStoppedMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::NariLabs.Realtime.RealtimeSpeechStoppedMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::NariLabs.Realtime.RealtimeSpeechStoppedMessage).Name}");
                        realtimeSpeechStoppedMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::NariLabs.Realtime.RealtimeErrorEventMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::NariLabs.Realtime.RealtimeErrorEventMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::NariLabs.Realtime.RealtimeErrorEventMessage).Name}");
                        realtimeErrorEventMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::NariLabs.Realtime.RealtimeCommitEmptyMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::NariLabs.Realtime.RealtimeCommitEmptyMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::NariLabs.Realtime.RealtimeCommitEmptyMessage).Name}");
                        realtimeCommitEmptyMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (realtimeSessionUpdatedMessage == null && realtimePartialTranscriptMessage == null && realtimeCompletedTranscriptMessage == null && realtimeWordTimestampsMessage == null && realtimeWordTimestampsFailedMessage == null && realtimeAudioCommittedMessage == null && realtimeSpeechStartedMessage == null && realtimeSpeechStoppedMessage == null && realtimeErrorEventMessage == null && realtimeCommitEmptyMessage == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::NariLabs.Realtime.RealtimeSessionUpdatedMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::NariLabs.Realtime.RealtimeSessionUpdatedMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::NariLabs.Realtime.RealtimeSessionUpdatedMessage).Name}");
                    realtimeSessionUpdatedMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (realtimeSessionUpdatedMessage == null && realtimePartialTranscriptMessage == null && realtimeCompletedTranscriptMessage == null && realtimeWordTimestampsMessage == null && realtimeWordTimestampsFailedMessage == null && realtimeAudioCommittedMessage == null && realtimeSpeechStartedMessage == null && realtimeSpeechStoppedMessage == null && realtimeErrorEventMessage == null && realtimeCommitEmptyMessage == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::NariLabs.Realtime.RealtimePartialTranscriptMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::NariLabs.Realtime.RealtimePartialTranscriptMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::NariLabs.Realtime.RealtimePartialTranscriptMessage).Name}");
                    realtimePartialTranscriptMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (realtimeSessionUpdatedMessage == null && realtimePartialTranscriptMessage == null && realtimeCompletedTranscriptMessage == null && realtimeWordTimestampsMessage == null && realtimeWordTimestampsFailedMessage == null && realtimeAudioCommittedMessage == null && realtimeSpeechStartedMessage == null && realtimeSpeechStoppedMessage == null && realtimeErrorEventMessage == null && realtimeCommitEmptyMessage == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::NariLabs.Realtime.RealtimeCompletedTranscriptMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::NariLabs.Realtime.RealtimeCompletedTranscriptMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::NariLabs.Realtime.RealtimeCompletedTranscriptMessage).Name}");
                    realtimeCompletedTranscriptMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (realtimeSessionUpdatedMessage == null && realtimePartialTranscriptMessage == null && realtimeCompletedTranscriptMessage == null && realtimeWordTimestampsMessage == null && realtimeWordTimestampsFailedMessage == null && realtimeAudioCommittedMessage == null && realtimeSpeechStartedMessage == null && realtimeSpeechStoppedMessage == null && realtimeErrorEventMessage == null && realtimeCommitEmptyMessage == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::NariLabs.Realtime.RealtimeWordTimestampsMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::NariLabs.Realtime.RealtimeWordTimestampsMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::NariLabs.Realtime.RealtimeWordTimestampsMessage).Name}");
                    realtimeWordTimestampsMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (realtimeSessionUpdatedMessage == null && realtimePartialTranscriptMessage == null && realtimeCompletedTranscriptMessage == null && realtimeWordTimestampsMessage == null && realtimeWordTimestampsFailedMessage == null && realtimeAudioCommittedMessage == null && realtimeSpeechStartedMessage == null && realtimeSpeechStoppedMessage == null && realtimeErrorEventMessage == null && realtimeCommitEmptyMessage == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::NariLabs.Realtime.RealtimeWordTimestampsFailedMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::NariLabs.Realtime.RealtimeWordTimestampsFailedMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::NariLabs.Realtime.RealtimeWordTimestampsFailedMessage).Name}");
                    realtimeWordTimestampsFailedMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (realtimeSessionUpdatedMessage == null && realtimePartialTranscriptMessage == null && realtimeCompletedTranscriptMessage == null && realtimeWordTimestampsMessage == null && realtimeWordTimestampsFailedMessage == null && realtimeAudioCommittedMessage == null && realtimeSpeechStartedMessage == null && realtimeSpeechStoppedMessage == null && realtimeErrorEventMessage == null && realtimeCommitEmptyMessage == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::NariLabs.Realtime.RealtimeAudioCommittedMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::NariLabs.Realtime.RealtimeAudioCommittedMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::NariLabs.Realtime.RealtimeAudioCommittedMessage).Name}");
                    realtimeAudioCommittedMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (realtimeSessionUpdatedMessage == null && realtimePartialTranscriptMessage == null && realtimeCompletedTranscriptMessage == null && realtimeWordTimestampsMessage == null && realtimeWordTimestampsFailedMessage == null && realtimeAudioCommittedMessage == null && realtimeSpeechStartedMessage == null && realtimeSpeechStoppedMessage == null && realtimeErrorEventMessage == null && realtimeCommitEmptyMessage == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::NariLabs.Realtime.RealtimeSpeechStartedMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::NariLabs.Realtime.RealtimeSpeechStartedMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::NariLabs.Realtime.RealtimeSpeechStartedMessage).Name}");
                    realtimeSpeechStartedMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (realtimeSessionUpdatedMessage == null && realtimePartialTranscriptMessage == null && realtimeCompletedTranscriptMessage == null && realtimeWordTimestampsMessage == null && realtimeWordTimestampsFailedMessage == null && realtimeAudioCommittedMessage == null && realtimeSpeechStartedMessage == null && realtimeSpeechStoppedMessage == null && realtimeErrorEventMessage == null && realtimeCommitEmptyMessage == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::NariLabs.Realtime.RealtimeSpeechStoppedMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::NariLabs.Realtime.RealtimeSpeechStoppedMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::NariLabs.Realtime.RealtimeSpeechStoppedMessage).Name}");
                    realtimeSpeechStoppedMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (realtimeSessionUpdatedMessage == null && realtimePartialTranscriptMessage == null && realtimeCompletedTranscriptMessage == null && realtimeWordTimestampsMessage == null && realtimeWordTimestampsFailedMessage == null && realtimeAudioCommittedMessage == null && realtimeSpeechStartedMessage == null && realtimeSpeechStoppedMessage == null && realtimeErrorEventMessage == null && realtimeCommitEmptyMessage == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::NariLabs.Realtime.RealtimeErrorEventMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::NariLabs.Realtime.RealtimeErrorEventMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::NariLabs.Realtime.RealtimeErrorEventMessage).Name}");
                    realtimeErrorEventMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (realtimeSessionUpdatedMessage == null && realtimePartialTranscriptMessage == null && realtimeCompletedTranscriptMessage == null && realtimeWordTimestampsMessage == null && realtimeWordTimestampsFailedMessage == null && realtimeAudioCommittedMessage == null && realtimeSpeechStartedMessage == null && realtimeSpeechStoppedMessage == null && realtimeErrorEventMessage == null && realtimeCommitEmptyMessage == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::NariLabs.Realtime.RealtimeCommitEmptyMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::NariLabs.Realtime.RealtimeCommitEmptyMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::NariLabs.Realtime.RealtimeCommitEmptyMessage).Name}");
                    realtimeCommitEmptyMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::NariLabs.Realtime.ServerEvent(
                realtimeSessionUpdatedMessage,

                realtimePartialTranscriptMessage,

                realtimeCompletedTranscriptMessage,

                realtimeWordTimestampsMessage,

                realtimeWordTimestampsFailedMessage,

                realtimeAudioCommittedMessage,

                realtimeSpeechStartedMessage,

                realtimeSpeechStoppedMessage,

                realtimeErrorEventMessage,

                realtimeCommitEmptyMessage
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::NariLabs.Realtime.ServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRealtimeSessionUpdatedMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::NariLabs.Realtime.RealtimeSessionUpdatedMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::NariLabs.Realtime.RealtimeSessionUpdatedMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::NariLabs.Realtime.RealtimeSessionUpdatedMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RealtimeSessionUpdatedMessage!, typeInfo);
            }
            else if (value.IsRealtimePartialTranscriptMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::NariLabs.Realtime.RealtimePartialTranscriptMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::NariLabs.Realtime.RealtimePartialTranscriptMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::NariLabs.Realtime.RealtimePartialTranscriptMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RealtimePartialTranscriptMessage!, typeInfo);
            }
            else if (value.IsRealtimeCompletedTranscriptMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::NariLabs.Realtime.RealtimeCompletedTranscriptMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::NariLabs.Realtime.RealtimeCompletedTranscriptMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::NariLabs.Realtime.RealtimeCompletedTranscriptMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RealtimeCompletedTranscriptMessage!, typeInfo);
            }
            else if (value.IsRealtimeWordTimestampsMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::NariLabs.Realtime.RealtimeWordTimestampsMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::NariLabs.Realtime.RealtimeWordTimestampsMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::NariLabs.Realtime.RealtimeWordTimestampsMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RealtimeWordTimestampsMessage!, typeInfo);
            }
            else if (value.IsRealtimeWordTimestampsFailedMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::NariLabs.Realtime.RealtimeWordTimestampsFailedMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::NariLabs.Realtime.RealtimeWordTimestampsFailedMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::NariLabs.Realtime.RealtimeWordTimestampsFailedMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RealtimeWordTimestampsFailedMessage!, typeInfo);
            }
            else if (value.IsRealtimeAudioCommittedMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::NariLabs.Realtime.RealtimeAudioCommittedMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::NariLabs.Realtime.RealtimeAudioCommittedMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::NariLabs.Realtime.RealtimeAudioCommittedMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RealtimeAudioCommittedMessage!, typeInfo);
            }
            else if (value.IsRealtimeSpeechStartedMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::NariLabs.Realtime.RealtimeSpeechStartedMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::NariLabs.Realtime.RealtimeSpeechStartedMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::NariLabs.Realtime.RealtimeSpeechStartedMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RealtimeSpeechStartedMessage!, typeInfo);
            }
            else if (value.IsRealtimeSpeechStoppedMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::NariLabs.Realtime.RealtimeSpeechStoppedMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::NariLabs.Realtime.RealtimeSpeechStoppedMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::NariLabs.Realtime.RealtimeSpeechStoppedMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RealtimeSpeechStoppedMessage!, typeInfo);
            }
            else if (value.IsRealtimeErrorEventMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::NariLabs.Realtime.RealtimeErrorEventMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::NariLabs.Realtime.RealtimeErrorEventMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::NariLabs.Realtime.RealtimeErrorEventMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RealtimeErrorEventMessage!, typeInfo);
            }
            else if (value.IsRealtimeCommitEmptyMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::NariLabs.Realtime.RealtimeCommitEmptyMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::NariLabs.Realtime.RealtimeCommitEmptyMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::NariLabs.Realtime.RealtimeCommitEmptyMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RealtimeCommitEmptyMessage!, typeInfo);
            }
        }
    }
}