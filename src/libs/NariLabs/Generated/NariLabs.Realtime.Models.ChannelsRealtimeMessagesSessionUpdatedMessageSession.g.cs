
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChannelsRealtimeMessagesSessionUpdatedMessageSession
    {
        /// <summary>
        /// Opaque identifier of the WebSocket session. Reconnecting creates a new session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::NariLabs.Realtime.ChannelsRealtimeMessagesSessionUpdatedMessageSessionLimits Limits { get; set; }

        /// <summary>
        /// STT model used for this connection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesSessionUpdatedMessageSessionModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::NariLabs.Realtime.ChannelsRealtimeMessagesSessionUpdatedMessageSessionModel Model { get; set; }

        /// <summary>
        /// Supported language code. Omit or use null for automatic language recognition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::NariLabs.Realtime.ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage Language { get; set; }

        /// <summary>
        /// Applied recognition context; empty when no prompt was supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Omit or use null for manual commit; use server_vad for automatic speech boundaries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_detection")]
        public global::NariLabs.Realtime.ServerVad? TurnDetection { get; set; }

        /// <summary>
        /// When true, request one `transcript.words` or `transcript.words.failed` event after each completed transcript.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_timestamps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool WordTimestamps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsRealtimeMessagesSessionUpdatedMessageSession" /> class.
        /// </summary>
        /// <param name="id">
        /// Opaque identifier of the WebSocket session. Reconnecting creates a new session.
        /// </param>
        /// <param name="limits"></param>
        /// <param name="model">
        /// STT model used for this connection.
        /// </param>
        /// <param name="language">
        /// Supported language code. Omit or use null for automatic language recognition.
        /// </param>
        /// <param name="prompt">
        /// Applied recognition context; empty when no prompt was supplied.
        /// </param>
        /// <param name="wordTimestamps">
        /// When true, request one `transcript.words` or `transcript.words.failed` event after each completed transcript.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="turnDetection">
        /// Omit or use null for manual commit; use server_vad for automatic speech boundaries.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChannelsRealtimeMessagesSessionUpdatedMessageSession(
            string id,
            global::NariLabs.Realtime.ChannelsRealtimeMessagesSessionUpdatedMessageSessionLimits limits,
            global::NariLabs.Realtime.ChannelsRealtimeMessagesSessionUpdatedMessageSessionModel model,
            global::NariLabs.Realtime.ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage language,
            string prompt,
            bool wordTimestamps,
            global::NariLabs.Realtime.ServerVad? turnDetection)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Limits = limits ?? throw new global::System.ArgumentNullException(nameof(limits));
            this.Model = model;
            this.Language = language;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.TurnDetection = turnDetection;
            this.WordTimestamps = wordTimestamps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsRealtimeMessagesSessionUpdatedMessageSession" /> class.
        /// </summary>
        public ChannelsRealtimeMessagesSessionUpdatedMessageSession()
        {
        }

    }
}