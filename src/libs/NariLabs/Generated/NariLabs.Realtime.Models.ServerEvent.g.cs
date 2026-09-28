#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ServerEvent : global::System.IEquatable<ServerEvent>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::NariLabs.Realtime.RealtimeSessionUpdatedMessage? RealtimeSessionUpdatedMessage { get; init; }
#else
        public global::NariLabs.Realtime.RealtimeSessionUpdatedMessage? RealtimeSessionUpdatedMessage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RealtimeSessionUpdatedMessage))]
#endif
        public bool IsRealtimeSessionUpdatedMessage => RealtimeSessionUpdatedMessage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRealtimeSessionUpdatedMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::NariLabs.Realtime.RealtimeSessionUpdatedMessage? value)
        {
            value = RealtimeSessionUpdatedMessage;
            return IsRealtimeSessionUpdatedMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.RealtimeSessionUpdatedMessage PickRealtimeSessionUpdatedMessage() => RealtimeSessionUpdatedMessage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RealtimeSessionUpdatedMessage' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::NariLabs.Realtime.RealtimePartialTranscriptMessage? RealtimePartialTranscriptMessage { get; init; }
#else
        public global::NariLabs.Realtime.RealtimePartialTranscriptMessage? RealtimePartialTranscriptMessage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RealtimePartialTranscriptMessage))]
#endif
        public bool IsRealtimePartialTranscriptMessage => RealtimePartialTranscriptMessage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRealtimePartialTranscriptMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::NariLabs.Realtime.RealtimePartialTranscriptMessage? value)
        {
            value = RealtimePartialTranscriptMessage;
            return IsRealtimePartialTranscriptMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.RealtimePartialTranscriptMessage PickRealtimePartialTranscriptMessage() => RealtimePartialTranscriptMessage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RealtimePartialTranscriptMessage' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::NariLabs.Realtime.RealtimeCompletedTranscriptMessage? RealtimeCompletedTranscriptMessage { get; init; }
#else
        public global::NariLabs.Realtime.RealtimeCompletedTranscriptMessage? RealtimeCompletedTranscriptMessage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RealtimeCompletedTranscriptMessage))]
#endif
        public bool IsRealtimeCompletedTranscriptMessage => RealtimeCompletedTranscriptMessage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRealtimeCompletedTranscriptMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::NariLabs.Realtime.RealtimeCompletedTranscriptMessage? value)
        {
            value = RealtimeCompletedTranscriptMessage;
            return IsRealtimeCompletedTranscriptMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.RealtimeCompletedTranscriptMessage PickRealtimeCompletedTranscriptMessage() => RealtimeCompletedTranscriptMessage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RealtimeCompletedTranscriptMessage' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::NariLabs.Realtime.RealtimeWordTimestampsMessage? RealtimeWordTimestampsMessage { get; init; }
#else
        public global::NariLabs.Realtime.RealtimeWordTimestampsMessage? RealtimeWordTimestampsMessage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RealtimeWordTimestampsMessage))]
#endif
        public bool IsRealtimeWordTimestampsMessage => RealtimeWordTimestampsMessage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRealtimeWordTimestampsMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::NariLabs.Realtime.RealtimeWordTimestampsMessage? value)
        {
            value = RealtimeWordTimestampsMessage;
            return IsRealtimeWordTimestampsMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.RealtimeWordTimestampsMessage PickRealtimeWordTimestampsMessage() => RealtimeWordTimestampsMessage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RealtimeWordTimestampsMessage' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::NariLabs.Realtime.RealtimeWordTimestampsFailedMessage? RealtimeWordTimestampsFailedMessage { get; init; }
#else
        public global::NariLabs.Realtime.RealtimeWordTimestampsFailedMessage? RealtimeWordTimestampsFailedMessage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RealtimeWordTimestampsFailedMessage))]
#endif
        public bool IsRealtimeWordTimestampsFailedMessage => RealtimeWordTimestampsFailedMessage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRealtimeWordTimestampsFailedMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::NariLabs.Realtime.RealtimeWordTimestampsFailedMessage? value)
        {
            value = RealtimeWordTimestampsFailedMessage;
            return IsRealtimeWordTimestampsFailedMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.RealtimeWordTimestampsFailedMessage PickRealtimeWordTimestampsFailedMessage() => RealtimeWordTimestampsFailedMessage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RealtimeWordTimestampsFailedMessage' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::NariLabs.Realtime.RealtimeAudioCommittedMessage? RealtimeAudioCommittedMessage { get; init; }
#else
        public global::NariLabs.Realtime.RealtimeAudioCommittedMessage? RealtimeAudioCommittedMessage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RealtimeAudioCommittedMessage))]
#endif
        public bool IsRealtimeAudioCommittedMessage => RealtimeAudioCommittedMessage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRealtimeAudioCommittedMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::NariLabs.Realtime.RealtimeAudioCommittedMessage? value)
        {
            value = RealtimeAudioCommittedMessage;
            return IsRealtimeAudioCommittedMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.RealtimeAudioCommittedMessage PickRealtimeAudioCommittedMessage() => RealtimeAudioCommittedMessage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RealtimeAudioCommittedMessage' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::NariLabs.Realtime.RealtimeSpeechStartedMessage? RealtimeSpeechStartedMessage { get; init; }
#else
        public global::NariLabs.Realtime.RealtimeSpeechStartedMessage? RealtimeSpeechStartedMessage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RealtimeSpeechStartedMessage))]
#endif
        public bool IsRealtimeSpeechStartedMessage => RealtimeSpeechStartedMessage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRealtimeSpeechStartedMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::NariLabs.Realtime.RealtimeSpeechStartedMessage? value)
        {
            value = RealtimeSpeechStartedMessage;
            return IsRealtimeSpeechStartedMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.RealtimeSpeechStartedMessage PickRealtimeSpeechStartedMessage() => RealtimeSpeechStartedMessage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RealtimeSpeechStartedMessage' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::NariLabs.Realtime.RealtimeSpeechStoppedMessage? RealtimeSpeechStoppedMessage { get; init; }
#else
        public global::NariLabs.Realtime.RealtimeSpeechStoppedMessage? RealtimeSpeechStoppedMessage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RealtimeSpeechStoppedMessage))]
#endif
        public bool IsRealtimeSpeechStoppedMessage => RealtimeSpeechStoppedMessage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRealtimeSpeechStoppedMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::NariLabs.Realtime.RealtimeSpeechStoppedMessage? value)
        {
            value = RealtimeSpeechStoppedMessage;
            return IsRealtimeSpeechStoppedMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.RealtimeSpeechStoppedMessage PickRealtimeSpeechStoppedMessage() => RealtimeSpeechStoppedMessage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RealtimeSpeechStoppedMessage' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::NariLabs.Realtime.RealtimeErrorEventMessage? RealtimeErrorEventMessage { get; init; }
#else
        public global::NariLabs.Realtime.RealtimeErrorEventMessage? RealtimeErrorEventMessage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RealtimeErrorEventMessage))]
#endif
        public bool IsRealtimeErrorEventMessage => RealtimeErrorEventMessage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRealtimeErrorEventMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::NariLabs.Realtime.RealtimeErrorEventMessage? value)
        {
            value = RealtimeErrorEventMessage;
            return IsRealtimeErrorEventMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.RealtimeErrorEventMessage PickRealtimeErrorEventMessage() => RealtimeErrorEventMessage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RealtimeErrorEventMessage' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::NariLabs.Realtime.RealtimeCommitEmptyMessage? RealtimeCommitEmptyMessage { get; init; }
#else
        public global::NariLabs.Realtime.RealtimeCommitEmptyMessage? RealtimeCommitEmptyMessage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RealtimeCommitEmptyMessage))]
#endif
        public bool IsRealtimeCommitEmptyMessage => RealtimeCommitEmptyMessage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRealtimeCommitEmptyMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::NariLabs.Realtime.RealtimeCommitEmptyMessage? value)
        {
            value = RealtimeCommitEmptyMessage;
            return IsRealtimeCommitEmptyMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Realtime.RealtimeCommitEmptyMessage PickRealtimeCommitEmptyMessage() => RealtimeCommitEmptyMessage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RealtimeCommitEmptyMessage' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::NariLabs.Realtime.RealtimeSessionUpdatedMessage value) => new ServerEvent((global::NariLabs.Realtime.RealtimeSessionUpdatedMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::NariLabs.Realtime.RealtimeSessionUpdatedMessage?(ServerEvent @this) => @this.RealtimeSessionUpdatedMessage;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::NariLabs.Realtime.RealtimeSessionUpdatedMessage? value)
        {
            RealtimeSessionUpdatedMessage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromRealtimeSessionUpdatedMessage(global::NariLabs.Realtime.RealtimeSessionUpdatedMessage? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::NariLabs.Realtime.RealtimePartialTranscriptMessage value) => new ServerEvent((global::NariLabs.Realtime.RealtimePartialTranscriptMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::NariLabs.Realtime.RealtimePartialTranscriptMessage?(ServerEvent @this) => @this.RealtimePartialTranscriptMessage;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::NariLabs.Realtime.RealtimePartialTranscriptMessage? value)
        {
            RealtimePartialTranscriptMessage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromRealtimePartialTranscriptMessage(global::NariLabs.Realtime.RealtimePartialTranscriptMessage? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::NariLabs.Realtime.RealtimeCompletedTranscriptMessage value) => new ServerEvent((global::NariLabs.Realtime.RealtimeCompletedTranscriptMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::NariLabs.Realtime.RealtimeCompletedTranscriptMessage?(ServerEvent @this) => @this.RealtimeCompletedTranscriptMessage;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::NariLabs.Realtime.RealtimeCompletedTranscriptMessage? value)
        {
            RealtimeCompletedTranscriptMessage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromRealtimeCompletedTranscriptMessage(global::NariLabs.Realtime.RealtimeCompletedTranscriptMessage? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::NariLabs.Realtime.RealtimeWordTimestampsMessage value) => new ServerEvent((global::NariLabs.Realtime.RealtimeWordTimestampsMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::NariLabs.Realtime.RealtimeWordTimestampsMessage?(ServerEvent @this) => @this.RealtimeWordTimestampsMessage;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::NariLabs.Realtime.RealtimeWordTimestampsMessage? value)
        {
            RealtimeWordTimestampsMessage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromRealtimeWordTimestampsMessage(global::NariLabs.Realtime.RealtimeWordTimestampsMessage? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::NariLabs.Realtime.RealtimeWordTimestampsFailedMessage value) => new ServerEvent((global::NariLabs.Realtime.RealtimeWordTimestampsFailedMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::NariLabs.Realtime.RealtimeWordTimestampsFailedMessage?(ServerEvent @this) => @this.RealtimeWordTimestampsFailedMessage;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::NariLabs.Realtime.RealtimeWordTimestampsFailedMessage? value)
        {
            RealtimeWordTimestampsFailedMessage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromRealtimeWordTimestampsFailedMessage(global::NariLabs.Realtime.RealtimeWordTimestampsFailedMessage? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::NariLabs.Realtime.RealtimeAudioCommittedMessage value) => new ServerEvent((global::NariLabs.Realtime.RealtimeAudioCommittedMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::NariLabs.Realtime.RealtimeAudioCommittedMessage?(ServerEvent @this) => @this.RealtimeAudioCommittedMessage;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::NariLabs.Realtime.RealtimeAudioCommittedMessage? value)
        {
            RealtimeAudioCommittedMessage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromRealtimeAudioCommittedMessage(global::NariLabs.Realtime.RealtimeAudioCommittedMessage? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::NariLabs.Realtime.RealtimeSpeechStartedMessage value) => new ServerEvent((global::NariLabs.Realtime.RealtimeSpeechStartedMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::NariLabs.Realtime.RealtimeSpeechStartedMessage?(ServerEvent @this) => @this.RealtimeSpeechStartedMessage;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::NariLabs.Realtime.RealtimeSpeechStartedMessage? value)
        {
            RealtimeSpeechStartedMessage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromRealtimeSpeechStartedMessage(global::NariLabs.Realtime.RealtimeSpeechStartedMessage? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::NariLabs.Realtime.RealtimeSpeechStoppedMessage value) => new ServerEvent((global::NariLabs.Realtime.RealtimeSpeechStoppedMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::NariLabs.Realtime.RealtimeSpeechStoppedMessage?(ServerEvent @this) => @this.RealtimeSpeechStoppedMessage;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::NariLabs.Realtime.RealtimeSpeechStoppedMessage? value)
        {
            RealtimeSpeechStoppedMessage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromRealtimeSpeechStoppedMessage(global::NariLabs.Realtime.RealtimeSpeechStoppedMessage? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::NariLabs.Realtime.RealtimeErrorEventMessage value) => new ServerEvent((global::NariLabs.Realtime.RealtimeErrorEventMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::NariLabs.Realtime.RealtimeErrorEventMessage?(ServerEvent @this) => @this.RealtimeErrorEventMessage;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::NariLabs.Realtime.RealtimeErrorEventMessage? value)
        {
            RealtimeErrorEventMessage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromRealtimeErrorEventMessage(global::NariLabs.Realtime.RealtimeErrorEventMessage? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::NariLabs.Realtime.RealtimeCommitEmptyMessage value) => new ServerEvent((global::NariLabs.Realtime.RealtimeCommitEmptyMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::NariLabs.Realtime.RealtimeCommitEmptyMessage?(ServerEvent @this) => @this.RealtimeCommitEmptyMessage;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::NariLabs.Realtime.RealtimeCommitEmptyMessage? value)
        {
            RealtimeCommitEmptyMessage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromRealtimeCommitEmptyMessage(global::NariLabs.Realtime.RealtimeCommitEmptyMessage? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(
            global::NariLabs.Realtime.RealtimeSessionUpdatedMessage? realtimeSessionUpdatedMessage,
            global::NariLabs.Realtime.RealtimePartialTranscriptMessage? realtimePartialTranscriptMessage,
            global::NariLabs.Realtime.RealtimeCompletedTranscriptMessage? realtimeCompletedTranscriptMessage,
            global::NariLabs.Realtime.RealtimeWordTimestampsMessage? realtimeWordTimestampsMessage,
            global::NariLabs.Realtime.RealtimeWordTimestampsFailedMessage? realtimeWordTimestampsFailedMessage,
            global::NariLabs.Realtime.RealtimeAudioCommittedMessage? realtimeAudioCommittedMessage,
            global::NariLabs.Realtime.RealtimeSpeechStartedMessage? realtimeSpeechStartedMessage,
            global::NariLabs.Realtime.RealtimeSpeechStoppedMessage? realtimeSpeechStoppedMessage,
            global::NariLabs.Realtime.RealtimeErrorEventMessage? realtimeErrorEventMessage,
            global::NariLabs.Realtime.RealtimeCommitEmptyMessage? realtimeCommitEmptyMessage
            )
        {
            RealtimeSessionUpdatedMessage = realtimeSessionUpdatedMessage;
            RealtimePartialTranscriptMessage = realtimePartialTranscriptMessage;
            RealtimeCompletedTranscriptMessage = realtimeCompletedTranscriptMessage;
            RealtimeWordTimestampsMessage = realtimeWordTimestampsMessage;
            RealtimeWordTimestampsFailedMessage = realtimeWordTimestampsFailedMessage;
            RealtimeAudioCommittedMessage = realtimeAudioCommittedMessage;
            RealtimeSpeechStartedMessage = realtimeSpeechStartedMessage;
            RealtimeSpeechStoppedMessage = realtimeSpeechStoppedMessage;
            RealtimeErrorEventMessage = realtimeErrorEventMessage;
            RealtimeCommitEmptyMessage = realtimeCommitEmptyMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            RealtimeCommitEmptyMessage as object ??
            RealtimeErrorEventMessage as object ??
            RealtimeSpeechStoppedMessage as object ??
            RealtimeSpeechStartedMessage as object ??
            RealtimeAudioCommittedMessage as object ??
            RealtimeWordTimestampsFailedMessage as object ??
            RealtimeWordTimestampsMessage as object ??
            RealtimeCompletedTranscriptMessage as object ??
            RealtimePartialTranscriptMessage as object ??
            RealtimeSessionUpdatedMessage as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            RealtimeSessionUpdatedMessage?.ToString() ??
            RealtimePartialTranscriptMessage?.ToString() ??
            RealtimeCompletedTranscriptMessage?.ToString() ??
            RealtimeWordTimestampsMessage?.ToString() ??
            RealtimeWordTimestampsFailedMessage?.ToString() ??
            RealtimeAudioCommittedMessage?.ToString() ??
            RealtimeSpeechStartedMessage?.ToString() ??
            RealtimeSpeechStoppedMessage?.ToString() ??
            RealtimeErrorEventMessage?.ToString() ??
            RealtimeCommitEmptyMessage?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRealtimeSessionUpdatedMessage && !IsRealtimePartialTranscriptMessage && !IsRealtimeCompletedTranscriptMessage && !IsRealtimeWordTimestampsMessage && !IsRealtimeWordTimestampsFailedMessage && !IsRealtimeAudioCommittedMessage && !IsRealtimeSpeechStartedMessage && !IsRealtimeSpeechStoppedMessage && !IsRealtimeErrorEventMessage && !IsRealtimeCommitEmptyMessage || !IsRealtimeSessionUpdatedMessage && IsRealtimePartialTranscriptMessage && !IsRealtimeCompletedTranscriptMessage && !IsRealtimeWordTimestampsMessage && !IsRealtimeWordTimestampsFailedMessage && !IsRealtimeAudioCommittedMessage && !IsRealtimeSpeechStartedMessage && !IsRealtimeSpeechStoppedMessage && !IsRealtimeErrorEventMessage && !IsRealtimeCommitEmptyMessage || !IsRealtimeSessionUpdatedMessage && !IsRealtimePartialTranscriptMessage && IsRealtimeCompletedTranscriptMessage && !IsRealtimeWordTimestampsMessage && !IsRealtimeWordTimestampsFailedMessage && !IsRealtimeAudioCommittedMessage && !IsRealtimeSpeechStartedMessage && !IsRealtimeSpeechStoppedMessage && !IsRealtimeErrorEventMessage && !IsRealtimeCommitEmptyMessage || !IsRealtimeSessionUpdatedMessage && !IsRealtimePartialTranscriptMessage && !IsRealtimeCompletedTranscriptMessage && IsRealtimeWordTimestampsMessage && !IsRealtimeWordTimestampsFailedMessage && !IsRealtimeAudioCommittedMessage && !IsRealtimeSpeechStartedMessage && !IsRealtimeSpeechStoppedMessage && !IsRealtimeErrorEventMessage && !IsRealtimeCommitEmptyMessage || !IsRealtimeSessionUpdatedMessage && !IsRealtimePartialTranscriptMessage && !IsRealtimeCompletedTranscriptMessage && !IsRealtimeWordTimestampsMessage && IsRealtimeWordTimestampsFailedMessage && !IsRealtimeAudioCommittedMessage && !IsRealtimeSpeechStartedMessage && !IsRealtimeSpeechStoppedMessage && !IsRealtimeErrorEventMessage && !IsRealtimeCommitEmptyMessage || !IsRealtimeSessionUpdatedMessage && !IsRealtimePartialTranscriptMessage && !IsRealtimeCompletedTranscriptMessage && !IsRealtimeWordTimestampsMessage && !IsRealtimeWordTimestampsFailedMessage && IsRealtimeAudioCommittedMessage && !IsRealtimeSpeechStartedMessage && !IsRealtimeSpeechStoppedMessage && !IsRealtimeErrorEventMessage && !IsRealtimeCommitEmptyMessage || !IsRealtimeSessionUpdatedMessage && !IsRealtimePartialTranscriptMessage && !IsRealtimeCompletedTranscriptMessage && !IsRealtimeWordTimestampsMessage && !IsRealtimeWordTimestampsFailedMessage && !IsRealtimeAudioCommittedMessage && IsRealtimeSpeechStartedMessage && !IsRealtimeSpeechStoppedMessage && !IsRealtimeErrorEventMessage && !IsRealtimeCommitEmptyMessage || !IsRealtimeSessionUpdatedMessage && !IsRealtimePartialTranscriptMessage && !IsRealtimeCompletedTranscriptMessage && !IsRealtimeWordTimestampsMessage && !IsRealtimeWordTimestampsFailedMessage && !IsRealtimeAudioCommittedMessage && !IsRealtimeSpeechStartedMessage && IsRealtimeSpeechStoppedMessage && !IsRealtimeErrorEventMessage && !IsRealtimeCommitEmptyMessage || !IsRealtimeSessionUpdatedMessage && !IsRealtimePartialTranscriptMessage && !IsRealtimeCompletedTranscriptMessage && !IsRealtimeWordTimestampsMessage && !IsRealtimeWordTimestampsFailedMessage && !IsRealtimeAudioCommittedMessage && !IsRealtimeSpeechStartedMessage && !IsRealtimeSpeechStoppedMessage && IsRealtimeErrorEventMessage && !IsRealtimeCommitEmptyMessage || !IsRealtimeSessionUpdatedMessage && !IsRealtimePartialTranscriptMessage && !IsRealtimeCompletedTranscriptMessage && !IsRealtimeWordTimestampsMessage && !IsRealtimeWordTimestampsFailedMessage && !IsRealtimeAudioCommittedMessage && !IsRealtimeSpeechStartedMessage && !IsRealtimeSpeechStoppedMessage && !IsRealtimeErrorEventMessage && IsRealtimeCommitEmptyMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::NariLabs.Realtime.RealtimeSessionUpdatedMessage, TResult>? realtimeSessionUpdatedMessage = null,
            global::System.Func<global::NariLabs.Realtime.RealtimePartialTranscriptMessage, TResult>? realtimePartialTranscriptMessage = null,
            global::System.Func<global::NariLabs.Realtime.RealtimeCompletedTranscriptMessage, TResult>? realtimeCompletedTranscriptMessage = null,
            global::System.Func<global::NariLabs.Realtime.RealtimeWordTimestampsMessage, TResult>? realtimeWordTimestampsMessage = null,
            global::System.Func<global::NariLabs.Realtime.RealtimeWordTimestampsFailedMessage, TResult>? realtimeWordTimestampsFailedMessage = null,
            global::System.Func<global::NariLabs.Realtime.RealtimeAudioCommittedMessage, TResult>? realtimeAudioCommittedMessage = null,
            global::System.Func<global::NariLabs.Realtime.RealtimeSpeechStartedMessage, TResult>? realtimeSpeechStartedMessage = null,
            global::System.Func<global::NariLabs.Realtime.RealtimeSpeechStoppedMessage, TResult>? realtimeSpeechStoppedMessage = null,
            global::System.Func<global::NariLabs.Realtime.RealtimeErrorEventMessage, TResult>? realtimeErrorEventMessage = null,
            global::System.Func<global::NariLabs.Realtime.RealtimeCommitEmptyMessage, TResult>? realtimeCommitEmptyMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RealtimeSessionUpdatedMessage is { } __value0 && realtimeSessionUpdatedMessage != null)
            {
                return realtimeSessionUpdatedMessage(__value0);
            }
            else if (RealtimePartialTranscriptMessage is { } __value1 && realtimePartialTranscriptMessage != null)
            {
                return realtimePartialTranscriptMessage(__value1);
            }
            else if (RealtimeCompletedTranscriptMessage is { } __value2 && realtimeCompletedTranscriptMessage != null)
            {
                return realtimeCompletedTranscriptMessage(__value2);
            }
            else if (RealtimeWordTimestampsMessage is { } __value3 && realtimeWordTimestampsMessage != null)
            {
                return realtimeWordTimestampsMessage(__value3);
            }
            else if (RealtimeWordTimestampsFailedMessage is { } __value4 && realtimeWordTimestampsFailedMessage != null)
            {
                return realtimeWordTimestampsFailedMessage(__value4);
            }
            else if (RealtimeAudioCommittedMessage is { } __value5 && realtimeAudioCommittedMessage != null)
            {
                return realtimeAudioCommittedMessage(__value5);
            }
            else if (RealtimeSpeechStartedMessage is { } __value6 && realtimeSpeechStartedMessage != null)
            {
                return realtimeSpeechStartedMessage(__value6);
            }
            else if (RealtimeSpeechStoppedMessage is { } __value7 && realtimeSpeechStoppedMessage != null)
            {
                return realtimeSpeechStoppedMessage(__value7);
            }
            else if (RealtimeErrorEventMessage is { } __value8 && realtimeErrorEventMessage != null)
            {
                return realtimeErrorEventMessage(__value8);
            }
            else if (RealtimeCommitEmptyMessage is { } __value9 && realtimeCommitEmptyMessage != null)
            {
                return realtimeCommitEmptyMessage(__value9);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::NariLabs.Realtime.RealtimeSessionUpdatedMessage>? realtimeSessionUpdatedMessage = null,

            global::System.Action<global::NariLabs.Realtime.RealtimePartialTranscriptMessage>? realtimePartialTranscriptMessage = null,

            global::System.Action<global::NariLabs.Realtime.RealtimeCompletedTranscriptMessage>? realtimeCompletedTranscriptMessage = null,

            global::System.Action<global::NariLabs.Realtime.RealtimeWordTimestampsMessage>? realtimeWordTimestampsMessage = null,

            global::System.Action<global::NariLabs.Realtime.RealtimeWordTimestampsFailedMessage>? realtimeWordTimestampsFailedMessage = null,

            global::System.Action<global::NariLabs.Realtime.RealtimeAudioCommittedMessage>? realtimeAudioCommittedMessage = null,

            global::System.Action<global::NariLabs.Realtime.RealtimeSpeechStartedMessage>? realtimeSpeechStartedMessage = null,

            global::System.Action<global::NariLabs.Realtime.RealtimeSpeechStoppedMessage>? realtimeSpeechStoppedMessage = null,

            global::System.Action<global::NariLabs.Realtime.RealtimeErrorEventMessage>? realtimeErrorEventMessage = null,

            global::System.Action<global::NariLabs.Realtime.RealtimeCommitEmptyMessage>? realtimeCommitEmptyMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RealtimeSessionUpdatedMessage is { } __value0)
            {
                realtimeSessionUpdatedMessage?.Invoke(__value0);
            }
            else if (RealtimePartialTranscriptMessage is { } __value1)
            {
                realtimePartialTranscriptMessage?.Invoke(__value1);
            }
            else if (RealtimeCompletedTranscriptMessage is { } __value2)
            {
                realtimeCompletedTranscriptMessage?.Invoke(__value2);
            }
            else if (RealtimeWordTimestampsMessage is { } __value3)
            {
                realtimeWordTimestampsMessage?.Invoke(__value3);
            }
            else if (RealtimeWordTimestampsFailedMessage is { } __value4)
            {
                realtimeWordTimestampsFailedMessage?.Invoke(__value4);
            }
            else if (RealtimeAudioCommittedMessage is { } __value5)
            {
                realtimeAudioCommittedMessage?.Invoke(__value5);
            }
            else if (RealtimeSpeechStartedMessage is { } __value6)
            {
                realtimeSpeechStartedMessage?.Invoke(__value6);
            }
            else if (RealtimeSpeechStoppedMessage is { } __value7)
            {
                realtimeSpeechStoppedMessage?.Invoke(__value7);
            }
            else if (RealtimeErrorEventMessage is { } __value8)
            {
                realtimeErrorEventMessage?.Invoke(__value8);
            }
            else if (RealtimeCommitEmptyMessage is { } __value9)
            {
                realtimeCommitEmptyMessage?.Invoke(__value9);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::NariLabs.Realtime.RealtimeSessionUpdatedMessage>? realtimeSessionUpdatedMessage = null,
            global::System.Action<global::NariLabs.Realtime.RealtimePartialTranscriptMessage>? realtimePartialTranscriptMessage = null,
            global::System.Action<global::NariLabs.Realtime.RealtimeCompletedTranscriptMessage>? realtimeCompletedTranscriptMessage = null,
            global::System.Action<global::NariLabs.Realtime.RealtimeWordTimestampsMessage>? realtimeWordTimestampsMessage = null,
            global::System.Action<global::NariLabs.Realtime.RealtimeWordTimestampsFailedMessage>? realtimeWordTimestampsFailedMessage = null,
            global::System.Action<global::NariLabs.Realtime.RealtimeAudioCommittedMessage>? realtimeAudioCommittedMessage = null,
            global::System.Action<global::NariLabs.Realtime.RealtimeSpeechStartedMessage>? realtimeSpeechStartedMessage = null,
            global::System.Action<global::NariLabs.Realtime.RealtimeSpeechStoppedMessage>? realtimeSpeechStoppedMessage = null,
            global::System.Action<global::NariLabs.Realtime.RealtimeErrorEventMessage>? realtimeErrorEventMessage = null,
            global::System.Action<global::NariLabs.Realtime.RealtimeCommitEmptyMessage>? realtimeCommitEmptyMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RealtimeSessionUpdatedMessage is { } __value0)
            {
                realtimeSessionUpdatedMessage?.Invoke(__value0);
            }
            else if (RealtimePartialTranscriptMessage is { } __value1)
            {
                realtimePartialTranscriptMessage?.Invoke(__value1);
            }
            else if (RealtimeCompletedTranscriptMessage is { } __value2)
            {
                realtimeCompletedTranscriptMessage?.Invoke(__value2);
            }
            else if (RealtimeWordTimestampsMessage is { } __value3)
            {
                realtimeWordTimestampsMessage?.Invoke(__value3);
            }
            else if (RealtimeWordTimestampsFailedMessage is { } __value4)
            {
                realtimeWordTimestampsFailedMessage?.Invoke(__value4);
            }
            else if (RealtimeAudioCommittedMessage is { } __value5)
            {
                realtimeAudioCommittedMessage?.Invoke(__value5);
            }
            else if (RealtimeSpeechStartedMessage is { } __value6)
            {
                realtimeSpeechStartedMessage?.Invoke(__value6);
            }
            else if (RealtimeSpeechStoppedMessage is { } __value7)
            {
                realtimeSpeechStoppedMessage?.Invoke(__value7);
            }
            else if (RealtimeErrorEventMessage is { } __value8)
            {
                realtimeErrorEventMessage?.Invoke(__value8);
            }
            else if (RealtimeCommitEmptyMessage is { } __value9)
            {
                realtimeCommitEmptyMessage?.Invoke(__value9);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RealtimeSessionUpdatedMessage,
                typeof(global::NariLabs.Realtime.RealtimeSessionUpdatedMessage),
                RealtimePartialTranscriptMessage,
                typeof(global::NariLabs.Realtime.RealtimePartialTranscriptMessage),
                RealtimeCompletedTranscriptMessage,
                typeof(global::NariLabs.Realtime.RealtimeCompletedTranscriptMessage),
                RealtimeWordTimestampsMessage,
                typeof(global::NariLabs.Realtime.RealtimeWordTimestampsMessage),
                RealtimeWordTimestampsFailedMessage,
                typeof(global::NariLabs.Realtime.RealtimeWordTimestampsFailedMessage),
                RealtimeAudioCommittedMessage,
                typeof(global::NariLabs.Realtime.RealtimeAudioCommittedMessage),
                RealtimeSpeechStartedMessage,
                typeof(global::NariLabs.Realtime.RealtimeSpeechStartedMessage),
                RealtimeSpeechStoppedMessage,
                typeof(global::NariLabs.Realtime.RealtimeSpeechStoppedMessage),
                RealtimeErrorEventMessage,
                typeof(global::NariLabs.Realtime.RealtimeErrorEventMessage),
                RealtimeCommitEmptyMessage,
                typeof(global::NariLabs.Realtime.RealtimeCommitEmptyMessage),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ServerEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::NariLabs.Realtime.RealtimeSessionUpdatedMessage?>.Default.Equals(RealtimeSessionUpdatedMessage, other.RealtimeSessionUpdatedMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::NariLabs.Realtime.RealtimePartialTranscriptMessage?>.Default.Equals(RealtimePartialTranscriptMessage, other.RealtimePartialTranscriptMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::NariLabs.Realtime.RealtimeCompletedTranscriptMessage?>.Default.Equals(RealtimeCompletedTranscriptMessage, other.RealtimeCompletedTranscriptMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::NariLabs.Realtime.RealtimeWordTimestampsMessage?>.Default.Equals(RealtimeWordTimestampsMessage, other.RealtimeWordTimestampsMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::NariLabs.Realtime.RealtimeWordTimestampsFailedMessage?>.Default.Equals(RealtimeWordTimestampsFailedMessage, other.RealtimeWordTimestampsFailedMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::NariLabs.Realtime.RealtimeAudioCommittedMessage?>.Default.Equals(RealtimeAudioCommittedMessage, other.RealtimeAudioCommittedMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::NariLabs.Realtime.RealtimeSpeechStartedMessage?>.Default.Equals(RealtimeSpeechStartedMessage, other.RealtimeSpeechStartedMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::NariLabs.Realtime.RealtimeSpeechStoppedMessage?>.Default.Equals(RealtimeSpeechStoppedMessage, other.RealtimeSpeechStoppedMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::NariLabs.Realtime.RealtimeErrorEventMessage?>.Default.Equals(RealtimeErrorEventMessage, other.RealtimeErrorEventMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::NariLabs.Realtime.RealtimeCommitEmptyMessage?>.Default.Equals(RealtimeCommitEmptyMessage, other.RealtimeCommitEmptyMessage)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ServerEvent obj1, ServerEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ServerEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ServerEvent obj1, ServerEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ServerEvent o && Equals(o);
        }
    }
}
