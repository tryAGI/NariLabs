
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum ChannelsRealtimeMessagesSessionUpdatedMessageType
    {
        /// <summary>
        ///
        /// </summary>
        SessionConfigured,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsRealtimeMessagesSessionUpdatedMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsRealtimeMessagesSessionUpdatedMessageType value)
        {
            return value switch
            {
                ChannelsRealtimeMessagesSessionUpdatedMessageType.SessionConfigured => "session.configured",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsRealtimeMessagesSessionUpdatedMessageType? ToEnum(string value)
        {
            return value switch
            {
                "session.configured" => ChannelsRealtimeMessagesSessionUpdatedMessageType.SessionConfigured,
                _ => null,
            };
        }
    }
}