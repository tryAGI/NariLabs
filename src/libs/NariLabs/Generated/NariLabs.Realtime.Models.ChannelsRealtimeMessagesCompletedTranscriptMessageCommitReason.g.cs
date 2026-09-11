
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    /// What finalized the utterance — client commit, VAD boundary, or accepted-audio duration limit.
    /// </summary>
    public enum ChannelsRealtimeMessagesCompletedTranscriptMessageCommitReason
    {
        /// <summary>
        ///
        /// </summary>
        Manual,
        /// <summary>
        ///
        /// </summary>
        MaxDuration,
        /// <summary>
        ///
        /// </summary>
        Vad,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsRealtimeMessagesCompletedTranscriptMessageCommitReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsRealtimeMessagesCompletedTranscriptMessageCommitReason value)
        {
            return value switch
            {
                ChannelsRealtimeMessagesCompletedTranscriptMessageCommitReason.Manual => "manual",
                ChannelsRealtimeMessagesCompletedTranscriptMessageCommitReason.MaxDuration => "max_duration",
                ChannelsRealtimeMessagesCompletedTranscriptMessageCommitReason.Vad => "vad",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsRealtimeMessagesCompletedTranscriptMessageCommitReason? ToEnum(string value)
        {
            return value switch
            {
                "manual" => ChannelsRealtimeMessagesCompletedTranscriptMessageCommitReason.Manual,
                "max_duration" => ChannelsRealtimeMessagesCompletedTranscriptMessageCommitReason.MaxDuration,
                "vad" => ChannelsRealtimeMessagesCompletedTranscriptMessageCommitReason.Vad,
                _ => null,
            };
        }
    }
}