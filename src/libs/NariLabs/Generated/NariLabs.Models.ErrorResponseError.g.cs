
#nullable enable

namespace NariLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ErrorResponseError
    {
        /// <summary>
        /// Machine-readable error code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Human-readable explanation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Request identifier, also returned in the x-request-id header.
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
        /// Initializes a new instance of the <see cref="ErrorResponseError" /> class.
        /// </summary>
        /// <param name="code">
        /// Machine-readable error code.
        /// </param>
        /// <param name="message">
        /// Human-readable explanation.
        /// </param>
        /// <param name="requestId">
        /// Request identifier, also returned in the x-request-id header.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorResponseError(
            string code,
            string message,
            string requestId)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponseError" /> class.
        /// </summary>
        public ErrorResponseError()
        {
        }

    }
}