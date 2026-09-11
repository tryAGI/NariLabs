
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    /// Recognized language code, or null if undetermined.
    /// </summary>
    public enum ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage
    {
        /// <summary>
        ///
        /// </summary>
        Ar,
        /// <summary>
        ///
        /// </summary>
        Cs,
        /// <summary>
        ///
        /// </summary>
        Da,
        /// <summary>
        ///
        /// </summary>
        De,
        /// <summary>
        ///
        /// </summary>
        El,
        /// <summary>
        ///
        /// </summary>
        En,
        /// <summary>
        ///
        /// </summary>
        Es,
        /// <summary>
        ///
        /// </summary>
        Fa,
        /// <summary>
        ///
        /// </summary>
        Fi,
        /// <summary>
        ///
        /// </summary>
        Fil,
        /// <summary>
        ///
        /// </summary>
        Fr,
        /// <summary>
        ///
        /// </summary>
        Hi,
        /// <summary>
        ///
        /// </summary>
        Hu,
        /// <summary>
        ///
        /// </summary>
        Id,
        /// <summary>
        ///
        /// </summary>
        It,
        /// <summary>
        ///
        /// </summary>
        Ja,
        /// <summary>
        ///
        /// </summary>
        Ko,
        /// <summary>
        ///
        /// </summary>
        Mk,
        /// <summary>
        ///
        /// </summary>
        Ms,
        /// <summary>
        ///
        /// </summary>
        Nl,
        /// <summary>
        ///
        /// </summary>
        Pl,
        /// <summary>
        ///
        /// </summary>
        Pt,
        /// <summary>
        ///
        /// </summary>
        Ro,
        /// <summary>
        ///
        /// </summary>
        Ru,
        /// <summary>
        ///
        /// </summary>
        Sv,
        /// <summary>
        ///
        /// </summary>
        Th,
        /// <summary>
        ///
        /// </summary>
        Tr,
        /// <summary>
        ///
        /// </summary>
        Vi,
        /// <summary>
        ///
        /// </summary>
        Yue,
        /// <summary>
        ///
        /// </summary>
        Zh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsRealtimeMessagesCompletedTranscriptMessageLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage value)
        {
            return value switch
            {
                ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Ar => "ar",
                ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Cs => "cs",
                ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Da => "da",
                ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.De => "de",
                ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.El => "el",
                ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.En => "en",
                ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Es => "es",
                ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Fa => "fa",
                ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Fi => "fi",
                ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Fil => "fil",
                ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Fr => "fr",
                ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Hi => "hi",
                ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Hu => "hu",
                ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Id => "id",
                ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.It => "it",
                ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Ja => "ja",
                ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Ko => "ko",
                ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Mk => "mk",
                ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Ms => "ms",
                ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Nl => "nl",
                ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Pl => "pl",
                ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Pt => "pt",
                ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Ro => "ro",
                ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Ru => "ru",
                ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Sv => "sv",
                ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Th => "th",
                ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Tr => "tr",
                ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Vi => "vi",
                ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Yue => "yue",
                ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Ar,
                "cs" => ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Cs,
                "da" => ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Da,
                "de" => ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.De,
                "el" => ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.El,
                "en" => ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.En,
                "es" => ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Es,
                "fa" => ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Fa,
                "fi" => ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Fi,
                "fil" => ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Fil,
                "fr" => ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Fr,
                "hi" => ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Hi,
                "hu" => ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Hu,
                "id" => ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Id,
                "it" => ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.It,
                "ja" => ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Ja,
                "ko" => ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Ko,
                "mk" => ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Mk,
                "ms" => ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Ms,
                "nl" => ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Nl,
                "pl" => ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Pl,
                "pt" => ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Pt,
                "ro" => ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Ro,
                "ru" => ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Ru,
                "sv" => ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Sv,
                "th" => ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Th,
                "tr" => ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Tr,
                "vi" => ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Vi,
                "yue" => ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Yue,
                "zh" => ChannelsRealtimeMessagesCompletedTranscriptMessageLanguage.Zh,
                _ => null,
            };
        }
    }
}