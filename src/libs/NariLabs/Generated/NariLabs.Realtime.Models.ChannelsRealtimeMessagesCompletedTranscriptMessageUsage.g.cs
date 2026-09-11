
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChannelsRealtimeMessagesCompletedTranscriptMessageUsage
    {
        /// <summary>
        /// Audio duration for this utterance in seconds, excluding silence discarded by VAD. Not billable duration; billing includes all audio accepted by the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double InputAudioSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsRealtimeMessagesCompletedTranscriptMessageUsage" /> class.
        /// </summary>
        /// <param name="inputAudioSeconds">
        /// Audio duration for this utterance in seconds, excluding silence discarded by VAD. Not billable duration; billing includes all audio accepted by the API.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChannelsRealtimeMessagesCompletedTranscriptMessageUsage(
            double inputAudioSeconds)
        {
            this.InputAudioSeconds = inputAudioSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsRealtimeMessagesCompletedTranscriptMessageUsage" /> class.
        /// </summary>
        public ChannelsRealtimeMessagesCompletedTranscriptMessageUsage()
        {
        }

    }
}