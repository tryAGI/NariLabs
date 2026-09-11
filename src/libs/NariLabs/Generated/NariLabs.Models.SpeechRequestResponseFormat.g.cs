
#nullable enable

namespace NariLabs
{
    /// <summary>
    /// `wav` includes a WAV header; `pcm` returns raw audio samples.<br/>
    /// Both formats support streaming.<br/>
    /// Default Value: wav
    /// </summary>
    public enum SpeechRequestResponseFormat
    {
        /// <summary>
        ///
        /// </summary>
        Pcm,
        /// <summary>
        ///
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechRequestResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechRequestResponseFormat value)
        {
            return value switch
            {
                SpeechRequestResponseFormat.Pcm => "pcm",
                SpeechRequestResponseFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechRequestResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "pcm" => SpeechRequestResponseFormat.Pcm,
                "wav" => SpeechRequestResponseFormat.Wav,
                _ => null,
            };
        }
    }
}