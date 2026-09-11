
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace NariLabs
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::NariLabs.JsonConverters.VoiceListObjectJsonConverter),

            typeof(global::NariLabs.JsonConverters.VoiceListObjectNullableJsonConverter),

            typeof(global::NariLabs.JsonConverters.VoiceObjectJsonConverter),

            typeof(global::NariLabs.JsonConverters.VoiceObjectNullableJsonConverter),

            typeof(global::NariLabs.JsonConverters.VoiceAccentJsonConverter),

            typeof(global::NariLabs.JsonConverters.VoiceAccentNullableJsonConverter),

            typeof(global::NariLabs.JsonConverters.VoiceGenderJsonConverter),

            typeof(global::NariLabs.JsonConverters.VoiceGenderNullableJsonConverter),

            typeof(global::NariLabs.JsonConverters.SpeechRequestModelJsonConverter),

            typeof(global::NariLabs.JsonConverters.SpeechRequestModelNullableJsonConverter),

            typeof(global::NariLabs.JsonConverters.SpeechRequestResponseFormatJsonConverter),

            typeof(global::NariLabs.JsonConverters.SpeechRequestResponseFormatNullableJsonConverter),

            typeof(global::NariLabs.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.VoiceListObject), TypeInfoPropertyName = "VoiceListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.VoiceObject), TypeInfoPropertyName = "VoiceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.VoiceAccent), TypeInfoPropertyName = "VoiceAccent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.VoiceGender), TypeInfoPropertyName = "VoiceGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.Voice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.VoiceList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::NariLabs.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.ErrorResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.SpeechRequestModel), TypeInfoPropertyName = "SpeechRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.SpeechRequestResponseFormat), TypeInfoPropertyName = "SpeechRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NariLabs.SpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::NariLabs.Voice>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}