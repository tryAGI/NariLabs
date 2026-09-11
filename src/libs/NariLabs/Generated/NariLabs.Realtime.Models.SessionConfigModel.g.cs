
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    /// STT model used for this connection.
    /// </summary>
    public enum SessionConfigModel
    {
        /// <summary>
        ///
        /// </summary>
        Qwen3Asr,
        /// <summary>
        ///
        /// </summary>
        Qwen3AsrFast,
        /// <summary>
        ///
        /// </summary>
        Qwen3AsrFast_free,
        /// <summary>
        ///
        /// </summary>
        Qwen3Asr_free,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionConfigModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionConfigModel value)
        {
            return value switch
            {
                SessionConfigModel.Qwen3Asr => "qwen3-asr",
                SessionConfigModel.Qwen3AsrFast => "qwen3-asr-fast",
                SessionConfigModel.Qwen3AsrFast_free => "qwen3-asr-fast:free",
                SessionConfigModel.Qwen3Asr_free => "qwen3-asr:free",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionConfigModel? ToEnum(string value)
        {
            return value switch
            {
                "qwen3-asr" => SessionConfigModel.Qwen3Asr,
                "qwen3-asr-fast" => SessionConfigModel.Qwen3AsrFast,
                "qwen3-asr-fast:free" => SessionConfigModel.Qwen3AsrFast_free,
                "qwen3-asr:free" => SessionConfigModel.Qwen3Asr_free,
                _ => null,
            };
        }
    }
}