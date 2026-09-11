#nullable enable

namespace NariLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class VoiceGenderNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::NariLabs.VoiceGender?>
    {
        /// <inheritdoc />
        public override global::NariLabs.VoiceGender? Read(
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
                        return global::NariLabs.VoiceGenderExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::NariLabs.VoiceGender)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::NariLabs.VoiceGender?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::NariLabs.VoiceGender? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::NariLabs.VoiceGenderExtensions.ToValueString(value.Value));
            }
        }
    }
}
