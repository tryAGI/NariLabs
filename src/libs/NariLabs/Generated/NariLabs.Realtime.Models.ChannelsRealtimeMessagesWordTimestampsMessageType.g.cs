
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum ChannelsRealtimeMessagesWordTimestampsMessageType
    {
        /// <summary>
        ///
        /// </summary>
        TranscriptWords,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsRealtimeMessagesWordTimestampsMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsRealtimeMessagesWordTimestampsMessageType value)
        {
            return value switch
            {
                ChannelsRealtimeMessagesWordTimestampsMessageType.TranscriptWords => "transcript.words",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsRealtimeMessagesWordTimestampsMessageType? ToEnum(string value)
        {
            return value switch
            {
                "transcript.words" => ChannelsRealtimeMessagesWordTimestampsMessageType.TranscriptWords,
                _ => null,
            };
        }
    }
}