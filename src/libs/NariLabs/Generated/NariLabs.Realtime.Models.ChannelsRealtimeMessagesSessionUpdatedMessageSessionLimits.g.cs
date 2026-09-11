
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChannelsRealtimeMessagesSessionUpdatedMessageSessionLimits
    {
        /// <summary>
        /// Input audio duration limit per utterance, default 36 seconds. Applies with or without VAD and does not end the connection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_duration_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxDurationSeconds { get; set; }

        /// <summary>
        /// Idle timeout in seconds, default 60. Waiting for final inference is exempt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idle_timeout_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double IdleTimeoutSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsRealtimeMessagesSessionUpdatedMessageSessionLimits" /> class.
        /// </summary>
        /// <param name="maxDurationSeconds">
        /// Input audio duration limit per utterance, default 36 seconds. Applies with or without VAD and does not end the connection.
        /// </param>
        /// <param name="idleTimeoutSeconds">
        /// Idle timeout in seconds, default 60. Waiting for final inference is exempt.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChannelsRealtimeMessagesSessionUpdatedMessageSessionLimits(
            double maxDurationSeconds,
            double idleTimeoutSeconds)
        {
            this.MaxDurationSeconds = maxDurationSeconds;
            this.IdleTimeoutSeconds = idleTimeoutSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsRealtimeMessagesSessionUpdatedMessageSessionLimits" /> class.
        /// </summary>
        public ChannelsRealtimeMessagesSessionUpdatedMessageSessionLimits()
        {
        }

    }
}