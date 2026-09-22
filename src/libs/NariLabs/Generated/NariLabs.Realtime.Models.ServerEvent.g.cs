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
        public global::NariLabs.Realtime.RealtimeSessionUpdatedMessage PickRealtimeSessionUpdatedMessage() => IsRealtimeSessionUpdatedMessage
            ? RealtimeSessionUpdatedMessage!
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
        public global::NariLabs.Realtime.RealtimePartialTranscriptMessage PickRealtimePartialTranscriptMessage() => IsRealtimePartialTranscriptMessage
            ? RealtimePartialTranscriptMessage!
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
        public global::NariLabs.Realtime.RealtimeCompletedTranscriptMessage PickRealtimeCompletedTranscriptMessage() => IsRealtimeCompletedTranscriptMessage
            ? RealtimeCompletedTranscriptMessage!
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
        public global::NariLabs.Realtime.RealtimeWordTimestampsMessage PickRealtimeWordTimestampsMessage() => IsRealtimeWordTimestampsMessage
            ? RealtimeWordTimestampsMessage!
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
        public global::NariLabs.Realtime.RealtimeWordTimestampsFailedMessage PickRealtimeWordTimestampsFailedMessage() => IsRealtimeWordTimestampsFailedMessage
            ? RealtimeWordTimestampsFailedMessage!
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
        public global::NariLabs.Realtime.RealtimeAudioCommittedMessage PickRealtimeAudioCommittedMessage() => IsRealtimeAudioCommittedMessage
            ? RealtimeAudioCommittedMessage!
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
        public global::NariLabs.Realtime.RealtimeSpeechStartedMessage PickRealtimeSpeechStartedMessage() => IsRealtimeSpeechStartedMessage
            ? RealtimeSpeechStartedMessage!
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
        public global::NariLabs.Realtime.RealtimeSpeechStoppedMessage PickRealtimeSpeechStoppedMessage() => IsRealtimeSpeechStoppedMessage
            ? RealtimeSpeechStoppedMessage!
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
        public global::NariLabs.Realtime.RealtimeErrorEventMessage PickRealtimeErrorEventMessage() => IsRealtimeErrorEventMessage
            ? RealtimeErrorEventMessage!
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
        public global::NariLabs.Realtime.RealtimeCommitEmptyMessage PickRealtimeCommitEmptyMessage() => IsRealtimeCommitEmptyMessage
            ? RealtimeCommitEmptyMessage!
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

            if (IsRealtimeSessionUpdatedMessage && realtimeSessionUpdatedMessage != null)
            {
                return realtimeSessionUpdatedMessage(RealtimeSessionUpdatedMessage!);
            }
            else if (IsRealtimePartialTranscriptMessage && realtimePartialTranscriptMessage != null)
            {
                return realtimePartialTranscriptMessage(RealtimePartialTranscriptMessage!);
            }
            else if (IsRealtimeCompletedTranscriptMessage && realtimeCompletedTranscriptMessage != null)
            {
                return realtimeCompletedTranscriptMessage(RealtimeCompletedTranscriptMessage!);
            }
            else if (IsRealtimeWordTimestampsMessage && realtimeWordTimestampsMessage != null)
            {
                return realtimeWordTimestampsMessage(RealtimeWordTimestampsMessage!);
            }
            else if (IsRealtimeWordTimestampsFailedMessage && realtimeWordTimestampsFailedMessage != null)
            {
                return realtimeWordTimestampsFailedMessage(RealtimeWordTimestampsFailedMessage!);
            }
            else if (IsRealtimeAudioCommittedMessage && realtimeAudioCommittedMessage != null)
            {
                return realtimeAudioCommittedMessage(RealtimeAudioCommittedMessage!);
            }
            else if (IsRealtimeSpeechStartedMessage && realtimeSpeechStartedMessage != null)
            {
                return realtimeSpeechStartedMessage(RealtimeSpeechStartedMessage!);
            }
            else if (IsRealtimeSpeechStoppedMessage && realtimeSpeechStoppedMessage != null)
            {
                return realtimeSpeechStoppedMessage(RealtimeSpeechStoppedMessage!);
            }
            else if (IsRealtimeErrorEventMessage && realtimeErrorEventMessage != null)
            {
                return realtimeErrorEventMessage(RealtimeErrorEventMessage!);
            }
            else if (IsRealtimeCommitEmptyMessage && realtimeCommitEmptyMessage != null)
            {
                return realtimeCommitEmptyMessage(RealtimeCommitEmptyMessage!);
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

            if (IsRealtimeSessionUpdatedMessage)
            {
                realtimeSessionUpdatedMessage?.Invoke(RealtimeSessionUpdatedMessage!);
            }
            else if (IsRealtimePartialTranscriptMessage)
            {
                realtimePartialTranscriptMessage?.Invoke(RealtimePartialTranscriptMessage!);
            }
            else if (IsRealtimeCompletedTranscriptMessage)
            {
                realtimeCompletedTranscriptMessage?.Invoke(RealtimeCompletedTranscriptMessage!);
            }
            else if (IsRealtimeWordTimestampsMessage)
            {
                realtimeWordTimestampsMessage?.Invoke(RealtimeWordTimestampsMessage!);
            }
            else if (IsRealtimeWordTimestampsFailedMessage)
            {
                realtimeWordTimestampsFailedMessage?.Invoke(RealtimeWordTimestampsFailedMessage!);
            }
            else if (IsRealtimeAudioCommittedMessage)
            {
                realtimeAudioCommittedMessage?.Invoke(RealtimeAudioCommittedMessage!);
            }
            else if (IsRealtimeSpeechStartedMessage)
            {
                realtimeSpeechStartedMessage?.Invoke(RealtimeSpeechStartedMessage!);
            }
            else if (IsRealtimeSpeechStoppedMessage)
            {
                realtimeSpeechStoppedMessage?.Invoke(RealtimeSpeechStoppedMessage!);
            }
            else if (IsRealtimeErrorEventMessage)
            {
                realtimeErrorEventMessage?.Invoke(RealtimeErrorEventMessage!);
            }
            else if (IsRealtimeCommitEmptyMessage)
            {
                realtimeCommitEmptyMessage?.Invoke(RealtimeCommitEmptyMessage!);
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

            if (IsRealtimeSessionUpdatedMessage)
            {
                realtimeSessionUpdatedMessage?.Invoke(RealtimeSessionUpdatedMessage!);
            }
            else if (IsRealtimePartialTranscriptMessage)
            {
                realtimePartialTranscriptMessage?.Invoke(RealtimePartialTranscriptMessage!);
            }
            else if (IsRealtimeCompletedTranscriptMessage)
            {
                realtimeCompletedTranscriptMessage?.Invoke(RealtimeCompletedTranscriptMessage!);
            }
            else if (IsRealtimeWordTimestampsMessage)
            {
                realtimeWordTimestampsMessage?.Invoke(RealtimeWordTimestampsMessage!);
            }
            else if (IsRealtimeWordTimestampsFailedMessage)
            {
                realtimeWordTimestampsFailedMessage?.Invoke(RealtimeWordTimestampsFailedMessage!);
            }
            else if (IsRealtimeAudioCommittedMessage)
            {
                realtimeAudioCommittedMessage?.Invoke(RealtimeAudioCommittedMessage!);
            }
            else if (IsRealtimeSpeechStartedMessage)
            {
                realtimeSpeechStartedMessage?.Invoke(RealtimeSpeechStartedMessage!);
            }
            else if (IsRealtimeSpeechStoppedMessage)
            {
                realtimeSpeechStoppedMessage?.Invoke(RealtimeSpeechStoppedMessage!);
            }
            else if (IsRealtimeErrorEventMessage)
            {
                realtimeErrorEventMessage?.Invoke(RealtimeErrorEventMessage!);
            }
            else if (IsRealtimeCommitEmptyMessage)
            {
                realtimeCommitEmptyMessage?.Invoke(RealtimeCommitEmptyMessage!);
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
