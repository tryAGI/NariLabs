#nullable enable

namespace NariLabs
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// List voices<br/>
        /// Returns the complete voice catalog for a TTS model.<br/>
        /// Requires an API key and does not consume generation allowance or credits.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::NariLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::NariLabs.VoiceList> ListVoicesAsync(
            string model,
            global::NariLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List voices<br/>
        /// Returns the complete voice catalog for a TTS model.<br/>
        /// Requires an API key and does not consume generation allowance or credits.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::NariLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::NariLabs.AutoSDKHttpResponse<global::NariLabs.VoiceList>> ListVoicesAsResponseAsync(
            string model,
            global::NariLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}