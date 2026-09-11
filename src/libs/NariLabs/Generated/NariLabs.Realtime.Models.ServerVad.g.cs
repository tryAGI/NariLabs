
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ServerVad
    {
        /// <summary>
        /// Use server-side voice activity detection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::NariLabs.Realtime.JsonConverters.ServerVadTypeJsonConverter))]
        public global::NariLabs.Realtime.ServerVadType Type { get; set; }

        /// <summary>
        /// Speech probability threshold. Higher values require stronger evidence of speech.<br/>
        /// Default Value: 0.5F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// Milliseconds of buffered audio to retain before detected speech begins, so the start of speech is not clipped.<br/>
        /// Default Value: 300
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix_padding_ms")]
        public int? PrefixPaddingMs { get; set; }

        /// <summary>
        /// Milliseconds of detected silence used to end an utterance. This measures input audio time, not a network timeout.<br/>
        /// Default Value: 500
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("silence_duration_ms")]
        public int? SilenceDurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerVad" /> class.
        /// </summary>
        /// <param name="type">
        /// Use server-side voice activity detection.
        /// </param>
        /// <param name="threshold">
        /// Speech probability threshold. Higher values require stronger evidence of speech.<br/>
        /// Default Value: 0.5F
        /// </param>
        /// <param name="prefixPaddingMs">
        /// Milliseconds of buffered audio to retain before detected speech begins, so the start of speech is not clipped.<br/>
        /// Default Value: 300
        /// </param>
        /// <param name="silenceDurationMs">
        /// Milliseconds of detected silence used to end an utterance. This measures input audio time, not a network timeout.<br/>
        /// Default Value: 500
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerVad(
            global::NariLabs.Realtime.ServerVadType type,
            double? threshold,
            int? prefixPaddingMs,
            int? silenceDurationMs)
        {
            this.Type = type;
            this.Threshold = threshold;
            this.PrefixPaddingMs = prefixPaddingMs;
            this.SilenceDurationMs = silenceDurationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerVad" /> class.
        /// </summary>
        public ServerVad()
        {
        }

    }
}