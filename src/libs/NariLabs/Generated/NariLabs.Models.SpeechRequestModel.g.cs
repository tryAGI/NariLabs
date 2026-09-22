
#nullable enable

namespace NariLabs
{
    /// <summary>
    /// Select Standard or Fast.
    /// </summary>
    public enum SpeechRequestModel
    {
        /// <summary>
        ///
        /// </summary>
        Qwen3Tts,
        /// <summary>
        ///
        /// </summary>
        Qwen3TtsFast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechRequestModel value)
        {
            return value switch
            {
                SpeechRequestModel.Qwen3Tts => "qwen3-tts",
                SpeechRequestModel.Qwen3TtsFast => "qwen3-tts-fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "qwen3-tts" => SpeechRequestModel.Qwen3Tts,
                "qwen3-tts-fast" => SpeechRequestModel.Qwen3TtsFast,
                _ => null,
            };
        }
    }
}