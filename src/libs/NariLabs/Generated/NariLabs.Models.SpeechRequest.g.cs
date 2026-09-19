
#nullable enable

namespace NariLabs
{
    /// <summary>
    /// The complete UTF-8 JSON body must not exceed 65,536 bytes, before trimming.<br/>
    /// Oversized bodies return 413 REQUEST_TOO_LARGE. Unknown fields, explicit null values,<br/>
    /// and incorrect field types are rejected with 400. Omit optional fields to use their defaults.
    /// </summary>
    public sealed partial class SpeechRequest
    {
        /// <summary>
        /// Select Standard or Fast.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::NariLabs.JsonConverters.SpeechRequestModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::NariLabs.SpeechRequestModel Model { get; set; }

        /// <summary>
        /// Complete text. Surrounding whitespace is removed before validation, synthesis and usage<br/>
        /// measurement. The trimmed text must contain 1–2,048 Unicode code points; otherwise the<br/>
        /// request returns 400 INVALID_SPEECH_REQUEST. Split longer text at sentence boundaries.<br/>
        /// Use [normal capitalization and punctuation](/generate-speech#prepare-your-text);<br/>
        /// all-lowercase or unpunctuated text can severely degrade speech quality.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// Case-sensitive voice ID from [List voices](/api-reference/text-to-speech/voices/list-voices)<br/>
        /// for the same model. The selected voice determines the language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Voice { get; set; }

        /// <summary>
        /// Use `auto` or omit to use the voice's language. An explicit code, such as `en` or `es`,<br/>
        /// must match the selected voice's language. This does not translate the input.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Send a different seed to request another variation. The seed used is returned in `x-nari-seed`.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public long? Seed { get; set; }

        /// <summary>
        /// `false` returns audio after generation finishes; `true` sends audio as it is generated.<br/>
        /// Send the complete text in one request in either mode.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// `wav` includes a WAV header; `pcm` returns raw audio samples.<br/>
        /// Both formats support streaming.<br/>
        /// Default Value: wav
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::NariLabs.JsonConverters.SpeechRequestResponseFormatJsonConverter))]
        public global::NariLabs.SpeechRequestResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// Select Standard or Fast.
        /// </param>
        /// <param name="input">
        /// Complete text. Surrounding whitespace is removed before validation, synthesis and usage<br/>
        /// measurement. The trimmed text must contain 1–2,048 Unicode code points; otherwise the<br/>
        /// request returns 400 INVALID_SPEECH_REQUEST. Split longer text at sentence boundaries.<br/>
        /// Use [normal capitalization and punctuation](/generate-speech#prepare-your-text);<br/>
        /// all-lowercase or unpunctuated text can severely degrade speech quality.
        /// </param>
        /// <param name="voice">
        /// Case-sensitive voice ID from [List voices](/api-reference/text-to-speech/voices/list-voices)<br/>
        /// for the same model. The selected voice determines the language.
        /// </param>
        /// <param name="language">
        /// Use `auto` or omit to use the voice's language. An explicit code, such as `en` or `es`,<br/>
        /// must match the selected voice's language. This does not translate the input.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="seed">
        /// Send a different seed to request another variation. The seed used is returned in `x-nari-seed`.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="stream">
        /// `false` returns audio after generation finishes; `true` sends audio as it is generated.<br/>
        /// Send the complete text in one request in either mode.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="responseFormat">
        /// `wav` includes a WAV header; `pcm` returns raw audio samples.<br/>
        /// Both formats support streaming.<br/>
        /// Default Value: wav
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechRequest(
            global::NariLabs.SpeechRequestModel model,
            string input,
            string voice,
            string? language,
            long? seed,
            bool? stream,
            global::NariLabs.SpeechRequestResponseFormat? responseFormat)
        {
            this.Model = model;
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Voice = voice ?? throw new global::System.ArgumentNullException(nameof(voice));
            this.Language = language;
            this.Seed = seed;
            this.Stream = stream;
            this.ResponseFormat = responseFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechRequest" /> class.
        /// </summary>
        public SpeechRequest()
        {
        }

    }
}