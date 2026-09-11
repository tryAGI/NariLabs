
#nullable enable

namespace NariLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum VoiceListObject
    {
        /// <summary>
        ///
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceListObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceListObject value)
        {
            return value switch
            {
                VoiceListObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceListObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => VoiceListObject.List,
                _ => null,
            };
        }
    }
}