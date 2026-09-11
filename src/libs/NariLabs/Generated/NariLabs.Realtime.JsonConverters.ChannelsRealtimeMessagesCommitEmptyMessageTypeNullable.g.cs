#nullable enable

namespace NariLabs.Realtime.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChannelsRealtimeMessagesCommitEmptyMessageTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::NariLabs.Realtime.ChannelsRealtimeMessagesCommitEmptyMessageType?>
    {
        /// <inheritdoc />
        public override global::NariLabs.Realtime.ChannelsRealtimeMessagesCommitEmptyMessageType? Read(
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
                        return global::NariLabs.Realtime.ChannelsRealtimeMessagesCommitEmptyMessageTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::NariLabs.Realtime.ChannelsRealtimeMessagesCommitEmptyMessageType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::NariLabs.Realtime.ChannelsRealtimeMessagesCommitEmptyMessageType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::NariLabs.Realtime.ChannelsRealtimeMessagesCommitEmptyMessageType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::NariLabs.Realtime.ChannelsRealtimeMessagesCommitEmptyMessageTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
