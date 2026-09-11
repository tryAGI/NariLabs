# Stream speech

Start processing audio as Nari Labs produces it instead of buffering the entire response.

This example assumes `using NariLabs;` is in scope and `apiKey` contains your NariLabs API key.

```csharp
using var client = new NariLabsClient(apiKey);

var voices = await client.Voices.ListVoicesAsync(model: "qwen3-tts-fast:free");
var voice = voices.Data.First();

// GenerateSpeechAsStreamAsync exposes the response body immediately.
await using var audio = await client.Speech.GenerateSpeechAsStreamAsync(
    new SpeechRequest
    {
        Model = SpeechRequestModel.Qwen3TtsFast_free,
        Input = "This audio is delivered progressively.",
        Voice = voice.Id,
        Stream = true,
        ResponseFormat = SpeechRequestResponseFormat.Pcm,
    });

using var received = new MemoryStream();
await audio.CopyToAsync(received);
```