#nullable enable

namespace NariLabs
{
    public partial interface ISpeechClient
    {
        /// <summary>
        /// Generate speech<br/>
        /// Converts complete text to WAV or raw PCM audio. Set `stream: true` for progressive delivery.<br/>
        /// The JSON body must fit within 64 KiB. Unknown fields, explicit `null` values, and<br/>
        /// incorrect field types return `400`. Omit optional fields to use their defaults.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::NariLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GenerateSpeechAsync(

            global::NariLabs.SpeechRequest request,
            global::NariLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate speech<br/>
        /// Converts complete text to WAV or raw PCM audio. Set `stream: true` for progressive delivery.<br/>
        /// The JSON body must fit within 64 KiB. Unknown fields, explicit `null` values, and<br/>
        /// incorrect field types return `400`. Omit optional fields to use their defaults.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::NariLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> GenerateSpeechAsStreamAsync(

            global::NariLabs.SpeechRequest request,
            global::NariLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate speech<br/>
        /// Converts complete text to WAV or raw PCM audio. Set `stream: true` for progressive delivery.<br/>
        /// The JSON body must fit within 64 KiB. Unknown fields, explicit `null` values, and<br/>
        /// incorrect field types return `400`. Omit optional fields to use their defaults.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::NariLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::NariLabs.AutoSDKHttpResponse<byte[]>> GenerateSpeechAsResponseAsync(

            global::NariLabs.SpeechRequest request,
            global::NariLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate speech<br/>
        /// Converts complete text to WAV or raw PCM audio. Set `stream: true` for progressive delivery.<br/>
        /// The JSON body must fit within 64 KiB. Unknown fields, explicit `null` values, and<br/>
        /// incorrect field types return `400`. Omit optional fields to use their defaults.
        /// </summary>
        /// <param name="model">
        /// Select Standard or Fast.
        /// </param>
        /// <param name="input">
        /// Complete text. Surrounding whitespace is removed before validation, synthesis and usage<br/>
        /// measurement. The trimmed text must contain 1–2,048 Unicode code points; otherwise the<br/>
        /// request returns 400 INVALID_SPEECH_REQUEST. Split longer text at sentence boundaries.<br/>
        /// Use [normal capitalization and punctuation](/generate-speech#prepare-your-text);<br/>
        /// all-lowercase or unpunctuated text can severely degrade speech quality.
        /// </param>
        /// <param name="voice">
        /// Case-sensitive voice ID from [List voices](/api-reference/text-to-speech/voices/list-voices)<br/>
        /// for the same model. The selected voice determines the language.
        /// </param>
        /// <param name="language">
        /// Use `auto` or omit to use the voice's language. An explicit code, such as `en` or `es`,<br/>
        /// must match the selected voice's language. This does not translate the input.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="seed">
        /// Send a different seed to request another variation. The seed used is returned in `x-nari-seed`.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="stream">
        /// `false` returns audio after generation finishes; `true` sends audio as it is generated.<br/>
        /// Send the complete text in one request in either mode.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="responseFormat">
        /// `wav` includes a WAV header; `pcm` returns raw audio samples.<br/>
        /// Both formats support streaming.<br/>
        /// Default Value: wav
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GenerateSpeechAsync(
            global::NariLabs.SpeechRequestModel model,
            string input,
            string voice,
            string? language = default,
            long? seed = default,
            bool? stream = default,
            global::NariLabs.SpeechRequestResponseFormat? responseFormat = default,
            global::NariLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}