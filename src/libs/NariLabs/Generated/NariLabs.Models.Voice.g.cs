
#nullable enable

namespace NariLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Voice
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::NariLabs.JsonConverters.VoiceObjectJsonConverter))]
        public global::NariLabs.VoiceObject Object { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Assigned generation language code. Omitted or auto speech language resolves to this value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// Optional accent metadata for display and filtering.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::NariLabs.JsonConverters.VoiceAccentJsonConverter))]
        public global::NariLabs.VoiceAccent? Accent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::NariLabs.JsonConverters.VoiceGenderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::NariLabs.VoiceGender Gender { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Optional HTTPS URL of a prerecorded sample.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_url")]
        public string? PreviewUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Voice" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="displayName"></param>
        /// <param name="language">
        /// Assigned generation language code. Omitted or auto speech language resolves to this value.
        /// </param>
        /// <param name="gender"></param>
        /// <param name="description"></param>
        /// <param name="object"></param>
        /// <param name="accent">
        /// Optional accent metadata for display and filtering.
        /// </param>
        /// <param name="previewUrl">
        /// Optional HTTPS URL of a prerecorded sample.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Voice(
            string id,
            string displayName,
            string language,
            global::NariLabs.VoiceGender gender,
            string description,
            global::NariLabs.VoiceObject @object,
            global::NariLabs.VoiceAccent? accent,
            string? previewUrl)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Accent = accent;
            this.Gender = gender;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.PreviewUrl = previewUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Voice" /> class.
        /// </summary>
        public Voice()
        {
        }

    }
}