#nullable enable

namespace NariLabs.Realtime.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChannelsRealtimeMessagesCompletedTranscriptMessageLanguageNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::NariLabs.Realtime.ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage?>
    {
        /// <inheritdoc />
        public override global::NariLabs.Realtime.ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::NariLabs.Realtime.ChannelsRealtimeMessagesCompletedTranscriptMessageLanguageExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::NariLabs.Realtime.ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::NariLabs.Realtime.ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::NariLabs.Realtime.ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::NariLabs.Realtime.ChannelsRealtimeMessagesCompletedTranscriptMessageLanguageExtensions.ToValueString(value.Value));
            }
        }
    }
}
