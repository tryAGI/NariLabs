
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace NariLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.VoiceListObject? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.VoiceObject? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.VoiceAccent? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.VoiceGender? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.Voice? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.VoiceList? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::NariLabs.Voice>? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.ErrorResponseError? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.ErrorResponse? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.SpeechRequestModel? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.SpeechRequestResponseFormat? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::NariLabs.SpeechRequest? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type15 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::NariLabs.Voice>? ListType0 { get; set; }
    }
}