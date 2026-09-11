
#nullable enable

namespace NariLabs.Realtime
{
    /// <summary>
    /// Supported language code. Omit or use null for automatic language recognition.
    /// </summary>
    public enum SessionConfigLanguage
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
    public static class SessionConfigLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionConfigLanguage value)
        {
            return value switch
            {
                SessionConfigLanguage.Ar => "ar",
                SessionConfigLanguage.Cs => "cs",
                SessionConfigLanguage.Da => "da",
                SessionConfigLanguage.De => "de",
                SessionConfigLanguage.El => "el",
                SessionConfigLanguage.En => "en",
                SessionConfigLanguage.Es => "es",
                SessionConfigLanguage.Fa => "fa",
                SessionConfigLanguage.Fi => "fi",
                SessionConfigLanguage.Fil => "fil",
                SessionConfigLanguage.Fr => "fr",
                SessionConfigLanguage.Hi => "hi",
                SessionConfigLanguage.Hu => "hu",
                SessionConfigLanguage.Id => "id",
                SessionConfigLanguage.It => "it",
                SessionConfigLanguage.Ja => "ja",
                SessionConfigLanguage.Ko => "ko",
                SessionConfigLanguage.Mk => "mk",
                SessionConfigLanguage.Ms => "ms",
                SessionConfigLanguage.Nl => "nl",
                SessionConfigLanguage.Pl => "pl",
                SessionConfigLanguage.Pt => "pt",
                SessionConfigLanguage.Ro => "ro",
                SessionConfigLanguage.Ru => "ru",
                SessionConfigLanguage.Sv => "sv",
                SessionConfigLanguage.Th => "th",
                SessionConfigLanguage.Tr => "tr",
                SessionConfigLanguage.Vi => "vi",
                SessionConfigLanguage.Yue => "yue",
                SessionConfigLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionConfigLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => SessionConfigLanguage.Ar,
                "cs" => SessionConfigLanguage.Cs,
                "da" => SessionConfigLanguage.Da,
                "de" => SessionConfigLanguage.De,
                "el" => SessionConfigLanguage.El,
                "en" => SessionConfigLanguage.En,
                "es" => SessionConfigLanguage.Es,
                "fa" => SessionConfigLanguage.Fa,
                "fi" => SessionConfigLanguage.Fi,
                "fil" => SessionConfigLanguage.Fil,
                "fr" => SessionConfigLanguage.Fr,
                "hi" => SessionConfigLanguage.Hi,
                "hu" => SessionConfigLanguage.Hu,
                "id" => SessionConfigLanguage.Id,
                "it" => SessionConfigLanguage.It,
                "ja" => SessionConfigLanguage.Ja,
                "ko" => SessionConfigLanguage.Ko,
                "mk" => SessionConfigLanguage.Mk,
                "ms" => SessionConfigLanguage.Ms,
                "nl" => SessionConfigLanguage.Nl,
                "pl" => SessionConfigLanguage.Pl,
                "pt" => SessionConfigLanguage.Pt,
                "ro" => SessionConfigLanguage.Ro,
                "ru" => SessionConfigLanguage.Ru,
                "sv" => SessionConfigLanguage.Sv,
                "th" => SessionConfigLanguage.Th,
                "tr" => SessionConfigLanguage.Tr,
                "vi" => SessionConfigLanguage.Vi,
                "yue" => SessionConfigLanguage.Yue,
                "zh" => SessionConfigLanguage.Zh,
                _ => null,
            };
        }
    }
}