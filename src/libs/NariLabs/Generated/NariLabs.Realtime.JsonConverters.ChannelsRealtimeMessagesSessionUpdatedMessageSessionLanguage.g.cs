#nullable enable

namespace NariLabs.Realtime.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::NariLabs.Realtime.ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage>
    {
        /// <inheritdoc />
        public override global::NariLabs.Realtime.ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage Read(
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
                        return global::NariLabs.Realtime.ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguageExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::NariLabs.Realtime.ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::NariLabs.Realtime.ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::NariLabs.Realtime.ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::NariLabs.Realtime.ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguageExtensions.ToValueString(value));
        }
    }
}
