
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    /// Use server-side voice activity detection.
    /// </summary>
    public enum ServerVadType
    {
        /// <summary>
        ///
        /// </summary>
        ServerVad,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerVadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerVadType value)
        {
            return value switch
            {
                ServerVadType.ServerVad => "server_vad",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerVadType? ToEnum(string value)
        {
            return value switch
            {
                "server_vad" => ServerVadType.ServerVad,
                _ => null,
            };
        }
    }
}