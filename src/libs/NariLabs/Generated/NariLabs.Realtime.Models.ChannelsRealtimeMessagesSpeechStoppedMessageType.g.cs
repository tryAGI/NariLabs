
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum ChannelsRealtimeMessagesSpeechStoppedMessageType
    {
        /// <summary>
        ///
        /// </summary>
        InputAudioBufferSpeechStopped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsRealtimeMessagesSpeechStoppedMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsRealtimeMessagesSpeechStoppedMessageType value)
        {
            return value switch
            {
                ChannelsRealtimeMessagesSpeechStoppedMessageType.InputAudioBufferSpeechStopped => "input_audio_buffer.speech_stopped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsRealtimeMessagesSpeechStoppedMessageType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.speech_stopped" => ChannelsRealtimeMessagesSpeechStoppedMessageType.InputAudioBufferSpeechStopped,
                _ => null,
            };
        }
    }
}