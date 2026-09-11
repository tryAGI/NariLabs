
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RealtimeSessionUpdateMessage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::NariLabs.Realtime.JsonConverters.ChannelsRealtimeMessagesSessionUpdateMessageTypeJsonConverter))]
        public global::NariLabs.Realtime.ChannelsRealtimeMessagesSessionUpdateMessageType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::NariLabs.Realtime.SessionConfig Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionUpdateMessage" /> class.
        /// </summary>
        /// <param name="session"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSessionUpdateMessage(
            global::NariLabs.Realtime.SessionConfig session,
            global::NariLabs.Realtime.ChannelsRealtimeMessagesSessionUpdateMessageType type)
        {
            this.Type = type;
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionUpdateMessage" /> class.
        /// </summary>
        public RealtimeSessionUpdateMessage()
        {
        }

    }
}