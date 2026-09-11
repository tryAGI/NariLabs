
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    /// STT model used for this connection.
    /// </summary>
    public enum ChannelsRealtimeMessagesSessionUpdatedMessageSessionModel
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
    public static class ChannelsRealtimeMessagesSessionUpdatedMessageSessionModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsRealtimeMessagesSessionUpdatedMessageSessionModel value)
        {
            return value switch
            {
                ChannelsRealtimeMessagesSessionUpdatedMessageSessionModel.Qwen3Asr => "qwen3-asr",
                ChannelsRealtimeMessagesSessionUpdatedMessageSessionModel.Qwen3AsrFast => "qwen3-asr-fast",
                ChannelsRealtimeMessagesSessionUpdatedMessageSessionModel.Qwen3AsrFast_free => "qwen3-asr-fast:free",
                ChannelsRealtimeMessagesSessionUpdatedMessageSessionModel.Qwen3Asr_free => "qwen3-asr:free",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsRealtimeMessagesSessionUpdatedMessageSessionModel? ToEnum(string value)
        {
            return value switch
            {
                "qwen3-asr" => ChannelsRealtimeMessagesSessionUpdatedMessageSessionModel.Qwen3Asr,
                "qwen3-asr-fast" => ChannelsRealtimeMessagesSessionUpdatedMessageSessionModel.Qwen3AsrFast,
                "qwen3-asr-fast:free" => ChannelsRealtimeMessagesSessionUpdatedMessageSessionModel.Qwen3AsrFast_free,
                "qwen3-asr:free" => ChannelsRealtimeMessagesSessionUpdatedMessageSessionModel.Qwen3Asr_free,
                _ => null,
            };
        }
    }
}