
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum ChannelsRealtimeMessagesSpeechStartedMessageType
    {
        /// <summary>
        ///
        /// </summary>
        InputAudioBufferSpeechStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsRealtimeMessagesSpeechStartedMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsRealtimeMessagesSpeechStartedMessageType value)
        {
            return value switch
            {
                ChannelsRealtimeMessagesSpeechStartedMessageType.InputAudioBufferSpeechStarted => "input_audio_buffer.speech_started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsRealtimeMessagesSpeechStartedMessageType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.speech_started" => ChannelsRealtimeMessagesSpeechStartedMessageType.InputAudioBufferSpeechStarted,
                _ => null,
            };
        }
    }
}