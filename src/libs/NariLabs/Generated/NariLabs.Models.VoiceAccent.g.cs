
#nullable enable

namespace NariLabs
{
    /// <summary>
    /// Optional accent metadata for display and filtering.
    /// </summary>
    public enum VoiceAccent
    {
        /// <summary>
        ///
        /// </summary>
        American,
        /// <summary>
        ///
        /// </summary>
        Australian,
        /// <summary>
        ///
        /// </summary>
        British,
        /// <summary>
        ///
        /// </summary>
        Canadian,
        /// <summary>
        ///
        /// </summary>
        Castilian,
        /// <summary>
        ///
        /// </summary>
        Indian,
        /// <summary>
        ///
        /// </summary>
        Irish,
        /// <summary>
        ///
        /// </summary>
        Jamaican,
        /// <summary>
        ///
        /// </summary>
        NewZealand,
        /// <summary>
        ///
        /// </summary>
        Nigerian,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceAccentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceAccent value)
        {
            return value switch
            {
                VoiceAccent.American => "american",
                VoiceAccent.Australian => "australian",
                VoiceAccent.British => "british",
                VoiceAccent.Canadian => "canadian",
                VoiceAccent.Castilian => "castilian",
                VoiceAccent.Indian => "indian",
                VoiceAccent.Irish => "irish",
                VoiceAccent.Jamaican => "jamaican",
                VoiceAccent.NewZealand => "new_zealand",
                VoiceAccent.Nigerian => "nigerian",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceAccent? ToEnum(string value)
        {
            return value switch
            {
                "american" => VoiceAccent.American,
                "australian" => VoiceAccent.Australian,
                "british" => VoiceAccent.British,
                "canadian" => VoiceAccent.Canadian,
                "castilian" => VoiceAccent.Castilian,
                "indian" => VoiceAccent.Indian,
                "irish" => VoiceAccent.Irish,
                "jamaican" => VoiceAccent.Jamaican,
                "new_zealand" => VoiceAccent.NewZealand,
                "nigerian" => VoiceAccent.Nigerian,
                _ => null,
            };
        }
    }
}