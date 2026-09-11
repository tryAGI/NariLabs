#nullable enable

namespace NariLabs.Realtime.JsonConverters
{
    /// <inheritdoc />
    public sealed class SessionConfigLanguageNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::NariLabs.Realtime.SessionConfigLanguage?>
    {
        /// <inheritdoc />
        public override global::NariLabs.Realtime.SessionConfigLanguage? Read(
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
                        return global::NariLabs.Realtime.SessionConfigLanguageExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::NariLabs.Realtime.SessionConfigLanguage)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::NariLabs.Realtime.SessionConfigLanguage?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::NariLabs.Realtime.SessionConfigLanguage? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::NariLabs.Realtime.SessionConfigLanguageExtensions.ToValueString(value.Value));
            }
        }
    }
}
