# Generate speech

Generate WAV audio with Nari Labs' free Qwen3-TTS model.

This example assumes `using NariLabs;` is in scope and `apiKey` contains your NariLabs API key.

```csharp
using var client = new NariLabsClient(apiKey);

// Voice IDs are model-specific, so discover the current catalog first.
var voices = await client.Voices.ListVoicesAsync(model: "qwen3-tts:free");
var voice = voices.Data.First();

// Generate complete WAV audio. The free model can be replaced with
// SpeechRequestModel.Qwen3Tts for the paid Standard endpoint.
var audio = await client.Speech.GenerateSpeechAsync(
    model: SpeechRequestModel.Qwen3Tts_free,
    input: "Hello from the Nari Labs .NET SDK!",
    voice: voice.Id,
    responseFormat: SpeechRequestResponseFormat.Wav);
```