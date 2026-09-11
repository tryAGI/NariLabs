
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum ChannelsRealtimeMessagesAudioCommitMessageType
    {
        /// <summary>
        ///
        /// </summary>
        InputAudioBufferCommit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsRealtimeMessagesAudioCommitMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsRealtimeMessagesAudioCommitMessageType value)
        {
            return value switch
            {
                ChannelsRealtimeMessagesAudioCommitMessageType.InputAudioBufferCommit => "input_audio_buffer.commit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsRealtimeMessagesAudioCommitMessageType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.commit" => ChannelsRealtimeMessagesAudioCommitMessageType.InputAudioBufferCommit,
                _ => null,
            };
        }
    }
}