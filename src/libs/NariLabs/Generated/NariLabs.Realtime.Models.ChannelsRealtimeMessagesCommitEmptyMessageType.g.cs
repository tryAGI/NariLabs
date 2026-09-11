
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum ChannelsRealtimeMessagesCommitEmptyMessageType
    {
        /// <summary>
        ///
        /// </summary>
        InputAudioBufferCommitEmpty,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsRealtimeMessagesCommitEmptyMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsRealtimeMessagesCommitEmptyMessageType value)
        {
            return value switch
            {
                ChannelsRealtimeMessagesCommitEmptyMessageType.InputAudioBufferCommitEmpty => "input_audio_buffer.commit_empty",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsRealtimeMessagesCommitEmptyMessageType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.commit_empty" => ChannelsRealtimeMessagesCommitEmptyMessageType.InputAudioBufferCommitEmpty,
                _ => null,
            };
        }
    }
}