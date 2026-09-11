#nullable enable

namespace NariLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class SpeechRequestModelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::NariLabs.SpeechRequestModel?>
    {
        /// <inheritdoc />
        public override global::NariLabs.SpeechRequestModel? Read(
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
                        return global::NariLabs.SpeechRequestModelExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::NariLabs.SpeechRequestModel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::NariLabs.SpeechRequestModel?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::NariLabs.SpeechRequestModel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::NariLabs.SpeechRequestModelExtensions.ToValueString(value.Value));
            }
        }
    }
}
