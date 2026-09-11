
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChannelsRealtimeMessagesErrorEventMessageError
    {
        /// <summary>
        /// Machine-readable error code. See [Errors and troubleshooting](/errors#websocket-failures).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Human-readable explanation. Do not parse its wording for application logic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Connection identifier matching the x-request-id handshake response header.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsRealtimeMessagesErrorEventMessageError" /> class.
        /// </summary>
        /// <param name="code">
        /// Machine-readable error code. See [Errors and troubleshooting](/errors#websocket-failures).
        /// </param>
        /// <param name="message">
        /// Human-readable explanation. Do not parse its wording for application logic.
        /// </param>
        /// <param name="requestId">
        /// Connection identifier matching the x-request-id handshake response header.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChannelsRealtimeMessagesErrorEventMessageError(
            string code,
            string message,
            string requestId)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsRealtimeMessagesErrorEventMessageError" /> class.
        /// </summary>
        public ChannelsRealtimeMessagesErrorEventMessageError()
        {
        }

    }
}