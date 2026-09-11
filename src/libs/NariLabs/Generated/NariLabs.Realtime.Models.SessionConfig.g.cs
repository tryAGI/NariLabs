
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SessionConfig
    {
        /// <summary>
        /// STT model used for this connection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::NariLabs.Realtime.JsonConverters.SessionConfigModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::NariLabs.Realtime.SessionConfigModel Model { get; set; }

        /// <summary>
        /// Supported language code. Omit or use null for automatic language recognition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::NariLabs.Realtime.JsonConverters.SessionConfigLanguageJsonConverter))]
        public global::NariLabs.Realtime.SessionConfigLanguage? Language { get; set; }

        /// <summary>
        /// Names or terminology to help recognition. Omitted, null, or empty means no context. Applies to every utterance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Omit or use null for manual commit; use server_vad for automatic speech boundaries.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_detection")]
        public global::NariLabs.Realtime.ServerVad? TurnDetection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionConfig" /> class.
        /// </summary>
        /// <param name="model">
        /// STT model used for this connection.
        /// </param>
        /// <param name="language">
        /// Supported language code. Omit or use null for automatic language recognition.
        /// </param>
        /// <param name="prompt">
        /// Names or terminology to help recognition. Omitted, null, or empty means no context. Applies to every utterance.
        /// </param>
        /// <param name="turnDetection">
        /// Omit or use null for manual commit; use server_vad for automatic speech boundaries.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionConfig(
            global::NariLabs.Realtime.SessionConfigModel model,
            global::NariLabs.Realtime.SessionConfigLanguage? language,
            string? prompt,
            global::NariLabs.Realtime.ServerVad? turnDetection)
        {
            this.Model = model;
            this.Language = language;
            this.Prompt = prompt;
            this.TurnDetection = turnDetection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionConfig" /> class.
        /// </summary>
        public SessionConfig()
        {
        }

    }
}