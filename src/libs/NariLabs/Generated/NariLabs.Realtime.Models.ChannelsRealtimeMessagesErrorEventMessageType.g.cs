
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum ChannelsRealtimeMessagesErrorEventMessageType
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsRealtimeMessagesErrorEventMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsRealtimeMessagesErrorEventMessageType value)
        {
            return value switch
            {
                ChannelsRealtimeMessagesErrorEventMessageType.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsRealtimeMessagesErrorEventMessageType? ToEnum(string value)
        {
            return value switch
            {
                "error" => ChannelsRealtimeMessagesErrorEventMessageType.Error,
                _ => null,
            };
        }
    }
}