
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum ChannelsRealtimeMessagesCompletedTranscriptMessageType
    {
        /// <summary>
        ///
        /// </summary>
        TranscriptCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsRealtimeMessagesCompletedTranscriptMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsRealtimeMessagesCompletedTranscriptMessageType value)
        {
            return value switch
            {
                ChannelsRealtimeMessagesCompletedTranscriptMessageType.TranscriptCompleted => "transcript.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsRealtimeMessagesCompletedTranscriptMessageType? ToEnum(string value)
        {
            return value switch
            {
                "transcript.completed" => ChannelsRealtimeMessagesCompletedTranscriptMessageType.TranscriptCompleted,
                _ => null,
            };
        }
    }
}