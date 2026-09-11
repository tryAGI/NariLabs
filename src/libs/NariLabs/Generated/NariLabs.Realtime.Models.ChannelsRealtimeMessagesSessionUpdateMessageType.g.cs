
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum ChannelsRealtimeMessagesSessionUpdateMessageType
    {
        /// <summary>
        ///
        /// </summary>
        SessionConfigure,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsRealtimeMessagesSessionUpdateMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsRealtimeMessagesSessionUpdateMessageType value)
        {
            return value switch
            {
                ChannelsRealtimeMessagesSessionUpdateMessageType.SessionConfigure => "session.configure",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsRealtimeMessagesSessionUpdateMessageType? ToEnum(string value)
        {
            return value switch
            {
                "session.configure" => ChannelsRealtimeMessagesSessionUpdateMessageType.SessionConfigure,
                _ => null,
            };
        }
    }
}