
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    /// Supported language code. Omit or use null for automatic language recognition.
    /// </summary>
    public enum ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage
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
    public static class ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage value)
        {
            return value switch
            {
                ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Ar => "ar",
                ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Cs => "cs",
                ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Da => "da",
                ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.De => "de",
                ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.El => "el",
                ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.En => "en",
                ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Es => "es",
                ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Fa => "fa",
                ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Fi => "fi",
                ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Fil => "fil",
                ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Fr => "fr",
                ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Hi => "hi",
                ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Hu => "hu",
                ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Id => "id",
                ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.It => "it",
                ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Ja => "ja",
                ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Ko => "ko",
                ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Mk => "mk",
                ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Ms => "ms",
                ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Nl => "nl",
                ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Pl => "pl",
                ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Pt => "pt",
                ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Ro => "ro",
                ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Ru => "ru",
                ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Sv => "sv",
                ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Th => "th",
                ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Tr => "tr",
                ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Vi => "vi",
                ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Yue => "yue",
                ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Ar,
                "cs" => ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Cs,
                "da" => ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Da,
                "de" => ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.De,
                "el" => ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.El,
                "en" => ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.En,
                "es" => ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Es,
                "fa" => ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Fa,
                "fi" => ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Fi,
                "fil" => ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Fil,
                "fr" => ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Fr,
                "hi" => ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Hi,
                "hu" => ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Hu,
                "id" => ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Id,
                "it" => ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.It,
                "ja" => ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Ja,
                "ko" => ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Ko,
                "mk" => ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Mk,
                "ms" => ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Ms,
                "nl" => ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Nl,
                "pl" => ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Pl,
                "pt" => ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Pt,
                "ro" => ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Ro,
                "ru" => ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Ru,
                "sv" => ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Sv,
                "th" => ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Th,
                "tr" => ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Tr,
                "vi" => ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Vi,
                "yue" => ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Yue,
                "zh" => ChannelsRealtimeMessagesSessionUpdatedMessageSessionLanguage.Zh,
                _ => null,
            };
        }
    }
}