
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum ChannelsRealtimeMessagesWordTimestampsFailedMessageType
    {
        /// <summary>
        ///
        /// </summary>
        TranscriptWordsFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsRealtimeMessagesWordTimestampsFailedMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsRealtimeMessagesWordTimestampsFailedMessageType value)
        {
            return value switch
            {
                ChannelsRealtimeMessagesWordTimestampsFailedMessageType.TranscriptWordsFailed => "transcript.words.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsRealtimeMessagesWordTimestampsFailedMessageType? ToEnum(string value)
        {
            return value switch
            {
                "transcript.words.failed" => ChannelsRealtimeMessagesWordTimestampsFailedMessageType.TranscriptWordsFailed,
                _ => null,
            };
        }
    }
}