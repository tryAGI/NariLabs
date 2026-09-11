
#nullable enable

namespace NariLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum VoiceObject
    {
        /// <summary>
        ///
        /// </summary>
        Voice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceObject value)
        {
            return value switch
            {
                VoiceObject.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceObject? ToEnum(string value)
        {
            return value switch
            {
                "voice" => VoiceObject.Voice,
                _ => null,
            };
        }
    }
}