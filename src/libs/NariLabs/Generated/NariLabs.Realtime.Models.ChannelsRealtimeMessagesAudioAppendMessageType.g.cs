
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum ChannelsRealtimeMessagesAudioAppendMessageType
    {
        /// <summary>
        ///
        /// </summary>
        InputAudioBufferAppend,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsRealtimeMessagesAudioAppendMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsRealtimeMessagesAudioAppendMessageType value)
        {
            return value switch
            {
                ChannelsRealtimeMessagesAudioAppendMessageType.InputAudioBufferAppend => "input_audio_buffer.append",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsRealtimeMessagesAudioAppendMessageType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.append" => ChannelsRealtimeMessagesAudioAppendMessageType.InputAudioBufferAppend,
                _ => null,
            };
        }
    }
}