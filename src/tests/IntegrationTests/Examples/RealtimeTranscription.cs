/*
order: 30
title: Realtime transcription client
slug: realtime-transcription-client

The realtime namespace contains a typed WebSocket client generated from Nari Labs' AsyncAPI contract.
*/

namespace NariLabs.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_RealtimeClientShape()
    {
        //// The API key is stored on the client and applied as a Bearer header when connecting.
        using var client = new Realtime.NariLabsRealtimeClient(apiKey: "test-key");

        client.IsConnected.Should().BeFalse();
        Realtime.NariLabsRealtimeClient.DefaultBaseUrl.Should()
            .Be("wss://api.narilabs.com/v1/realtime?intent=transcription");

        //// Typed messages cover session configuration, PCM16 audio append, and commit.
        var configure = new Realtime.RealtimeSessionUpdateMessage
        {
            Session = new Realtime.SessionConfig
            {
                Model = Realtime.SessionConfigModel.Qwen3AsrFast,
                Language = Realtime.SessionConfigLanguage.En,
            },
        };

        configure.Session.Model.Should().Be(Realtime.SessionConfigModel.Qwen3AsrFast);
        await Task.CompletedTask;
    }

    [TestMethod]
    public void Realtime_ServerEventCoversDocumentedVariants()
    {
        var serverEvent = default(Realtime.ServerEvent);

        serverEvent.IsRealtimeSessionUpdatedMessage.Should().BeFalse();
        serverEvent.IsRealtimePartialTranscriptMessage.Should().BeFalse();
        serverEvent.IsRealtimeCompletedTranscriptMessage.Should().BeFalse();
        serverEvent.IsRealtimeAudioCommittedMessage.Should().BeFalse();
        serverEvent.IsRealtimeSpeechStartedMessage.Should().BeFalse();
        serverEvent.IsRealtimeSpeechStoppedMessage.Should().BeFalse();
        serverEvent.IsRealtimeErrorEventMessage.Should().BeFalse();
        serverEvent.IsRealtimeCommitEmptyMessage.Should().BeFalse();
    }

    [TestMethod]
    public void Realtime_CompletedTranscriptDeserializesFromWireFormat()
    {
        const string json = """
            {
              "type": "transcript.completed",
              "event_id": "event-1",
              "item_id": "item-1",
              "transcript": "Hello from realtime transcription.",
              "language": "en",
              "commit_reason": "manual",
              "usage": { "input_audio_seconds": 1.25 }
            }
            """;

        var serverEvent = Realtime.ServerEvent.FromJson(json);

        serverEvent.Should().NotBeNull();
        serverEvent!.Value.IsRealtimeCompletedTranscriptMessage.Should().BeTrue();
        serverEvent.Value.RealtimeCompletedTranscriptMessage!.Transcript.Should()
            .Be("Hello from realtime transcription.");
    }
}
