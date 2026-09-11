
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum ChannelsRealtimeMessagesPartialTranscriptMessageType
    {
        /// <summary>
        ///
        /// </summary>
        TranscriptPartial,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsRealtimeMessagesPartialTranscriptMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsRealtimeMessagesPartialTranscriptMessageType value)
        {
            return value switch
            {
                ChannelsRealtimeMessagesPartialTranscriptMessageType.TranscriptPartial => "transcript.partial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsRealtimeMessagesPartialTranscriptMessageType? ToEnum(string value)
        {
            return value switch
            {
                "transcript.partial" => ChannelsRealtimeMessagesPartialTranscriptMessageType.TranscriptPartial,
                _ => null,
            };
        }
    }
}