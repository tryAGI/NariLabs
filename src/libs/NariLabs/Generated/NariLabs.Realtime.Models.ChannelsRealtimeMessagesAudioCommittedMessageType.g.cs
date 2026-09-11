
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum ChannelsRealtimeMessagesAudioCommittedMessageType
    {
        /// <summary>
        ///
        /// </summary>
        InputAudioBufferCommitted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsRealtimeMessagesAudioCommittedMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsRealtimeMessagesAudioCommittedMessageType value)
        {
            return value switch
            {
                ChannelsRealtimeMessagesAudioCommittedMessageType.InputAudioBufferCommitted => "input_audio_buffer.committed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsRealtimeMessagesAudioCommittedMessageType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.committed" => ChannelsRealtimeMessagesAudioCommittedMessageType.InputAudioBufferCommitted,
                _ => null,
            };
        }
    }
}