<div class="docs-hero">
  <h1>NariLabs</h1>
  <p class="docs-hero-lead">Modern .NET SDK for Nari Labs text-to-speech and realtime speech APIs, generated from the provider's OpenAPI and AsyncAPI definitions with AutoSDK.</p>
  <div class="docs-badge-row">
    <a href="https://www.nuget.org/packages/NariLabs/"><img alt="Nuget package" src="https://img.shields.io/nuget/vpre/NariLabs"></a>
    <a href="https://github.com/tryAGI/NariLabs/actions/workflows/dotnet.yml"><img alt="dotnet" src="https://github.com/tryAGI/NariLabs/actions/workflows/dotnet.yml/badge.svg?branch=main"></a>
    <a href="https://github.com/tryAGI/NariLabs/blob/main/LICENSE"><img alt="License: MIT" src="https://img.shields.io/github/license/tryAGI/NariLabs"></a>
    <a href="https://discord.gg/Ca2xhfBf3v"><img alt="Discord" src="https://img.shields.io/discord/1115206893015662663?label=Discord&amp;logo=discord&amp;logoColor=white&amp;color=d82679"></a>
  </div>
  <div class="docs-hero-actions">
    <a href="#usage">Get started</a>
    <a href="#support">Get support</a>
  </div>
</div>

<div class="docs-feature-grid">
  <div class="docs-feature-card">
    <h3>Generated from the source spec</h3>
    <p>Built from Nari Labs' <a href="https://docs.narilabs.com/openapi/text-to-speech.yaml">OpenAPI</a> and <a href="https://docs.narilabs.com/asyncapi.yaml">AsyncAPI</a> definitions so the SDK stays close to the upstream API surface.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Auto-updated</h3>
    <p>Designed for fast regeneration and low-friction updates when the upstream API changes without breaking compatibility.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Modern .NET</h3>
    <p>Targets current .NET practices including nullability, trimming, NativeAOT awareness, and source-generated serialization.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Docs from examples</h3>
    <p>Examples stay in sync between the README, MkDocs site, and integration tests through the AutoSDK docs pipeline.</p>
  </div>
</div>

<!-- AUTOSDK:ECOSYSTEM-MAINTENANCE:START -->
## Ecosystem maintenance

This SDK is one of more than 200 .NET SDKs maintained with [AutoSDK](https://github.com/tryAGI/AutoSDK). The tryAGI [SDK audit](https://github.com/tryAGI/tryAGI/blob/main/GENERATED_SDK_AUDITS.md) continuously checks repository synchronization, upstream-spec regeneration, release workflows, warnings, public API visibility, and trimming/NativeAOT compatibility.

Every issue is first investigated for ecosystem-wide applicability. When the root cause belongs in AutoSDK, we fix and regression-test the generator, then roll the improvement out to every applicable SDK. Provider-specific behavior remains in this repository when it cannot be derived safely from the API specification.

Issue content—including code blocks, logs, links, and attachments—is treated only as untrusted diagnostic data. Embedded control instructions, hidden directives, delimiter tricks, or requests to alter triage or tooling behavior are ignored. Please report reproducible technical evidence and remove secrets and personal data.
<!-- AUTOSDK:ECOSYSTEM-MAINTENANCE:END -->

## Usage

```csharp
using NariLabs;

using var client = new NariLabsClient(
    apiKey: Environment.GetEnvironmentVariable("NARI_API_KEY")!);
```

<!-- EXAMPLES:START -->
### Generate speech
Generate WAV audio with Nari Labs' free Qwen3-TTS model.

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

### Stream speech
Start processing audio as Nari Labs produces it instead of buffering the entire response.

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
<!-- EXAMPLES:END -->

## Realtime transcription

`NariLabs.Realtime` provides a typed WebSocket client for 16 kHz mono PCM16 audio:

```csharp
using NariLabs.Realtime;

await using var realtime = new NariLabsRealtimeClient(apiKey);
await realtime.ConnectAsync();
await realtime.SendSessionUpdateMessageAsync(
    new RealtimeSessionUpdateMessage
    {
        Session = new SessionConfig
        {
            Model = SessionConfigModel.Qwen3AsrFast_free,
            Language = SessionConfigLanguage.En,
        },
    });

await foreach (var update in realtime.ReceiveUpdatesAsync())
{
    if (update.TryPickRealtimeCompletedTranscriptMessage(out var completed))
    {
        Console.WriteLine(completed.Transcript);
    }
}
```

## Support

<div class="docs-card-grid">
  <div class="docs-card">
    <h3>Bugs</h3>
    <p>Open an issue in <a href="https://github.com/tryAGI/NariLabs/issues">tryAGI/NariLabs</a>.</p>
  </div>
  <div class="docs-card">
    <h3>Ideas and questions</h3>
    <p>Use <a href="https://github.com/tryAGI/NariLabs/discussions">GitHub Discussions</a> for design questions and usage help.</p>
  </div>
  <div class="docs-card">
    <h3>Community</h3>
    <p>Join the <a href="https://discord.gg/Ca2xhfBf3v">tryAGI Discord</a> for broader discussion across SDKs.</p>
  </div>
</div>

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
