/*
order: 20
title: Stream speech
slug: stream-speech

Start processing audio as Nari Labs produces it instead of buffering the entire response.
*/

namespace NariLabs.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [Timeout(60_000)]
    public async Task Example_StreamSpeech()
    {
        using var client = GetAuthenticatedClient();

        var voices = await client.Voices.ListVoicesAsync(model: "qwen3-tts-fast:free");
        var voice = voices.Data.First();

        //// GenerateSpeechAsStreamAsync exposes the response body immediately.
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

        received.Length.Should().BeGreaterThan(0);
    }
}
