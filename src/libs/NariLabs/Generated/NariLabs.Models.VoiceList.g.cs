
#nullable enable

namespace NariLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VoiceList
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::NariLabs.JsonConverters.VoiceListObjectJsonConverter))]
        public global::NariLabs.VoiceListObject Object { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalog_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CatalogVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::NariLabs.Voice> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceList" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="catalogVersion"></param>
        /// <param name="data"></param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceList(
            string model,
            string catalogVersion,
            global::System.Collections.Generic.IList<global::NariLabs.Voice> data,
            global::NariLabs.VoiceListObject @object)
        {
            this.Object = @object;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.CatalogVersion = catalogVersion ?? throw new global::System.ArgumentNullException(nameof(catalogVersion));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceList" /> class.
        /// </summary>
        public VoiceList()
        {
        }

    }
}