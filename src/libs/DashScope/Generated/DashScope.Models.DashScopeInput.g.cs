
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DashScope
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DashScopeInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::DashScope.Message>? Messages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Prompt content to exclude from generated video or image output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// Public audio URL for Wan video models that accept driving or custom audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// First-frame image URL for legacy Wan image-to-video models such as wan2.6-i2v.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("img_url")]
        public string? ImgUrl { get; set; }

        /// <summary>
        /// Media assets for Wan 2.7 image-to-video tasks. Supported type values include first_frame, last_frame, driving_audio, and first_clip.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media")]
        public global::System.Collections.Generic.IList<global::DashScope.DashScopeMedia>? Media { get; set; }

        /// <summary>
        /// Reference image or video URLs for Wan reference-to-video models such as wan2.6-r2v.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_urls")]
        public global::System.Collections.Generic.IList<string>? ReferenceUrls { get; set; }

        /// <summary>
        /// Deprecated Wan reference-to-video field. Use reference_urls instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_video_urls")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? ReferenceVideoUrls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        public global::System.Collections.Generic.IList<object>? Contents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DashScopeInput" /> class.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="prompt"></param>
        /// <param name="negativePrompt">
        /// Prompt content to exclude from generated video or image output.
        /// </param>
        /// <param name="audioUrl">
        /// Public audio URL for Wan video models that accept driving or custom audio.
        /// </param>
        /// <param name="imgUrl">
        /// First-frame image URL for legacy Wan image-to-video models such as wan2.6-i2v.
        /// </param>
        /// <param name="media">
        /// Media assets for Wan 2.7 image-to-video tasks. Supported type values include first_frame, last_frame, driving_audio, and first_clip.
        /// </param>
        /// <param name="referenceUrls">
        /// Reference image or video URLs for Wan reference-to-video models such as wan2.6-r2v.
        /// </param>
        /// <param name="contents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DashScopeInput(
            global::System.Collections.Generic.IList<global::DashScope.Message>? messages,
            string? prompt,
            string? negativePrompt,
            string? audioUrl,
            string? imgUrl,
            global::System.Collections.Generic.IList<global::DashScope.DashScopeMedia>? media,
            global::System.Collections.Generic.IList<string>? referenceUrls,
            global::System.Collections.Generic.IList<object>? contents)
        {
            this.Messages = messages;
            this.Prompt = prompt;
            this.NegativePrompt = negativePrompt;
            this.AudioUrl = audioUrl;
            this.ImgUrl = imgUrl;
            this.Media = media;
            this.ReferenceUrls = referenceUrls;
            this.Contents = contents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DashScopeInput" /> class.
        /// </summary>
        public DashScopeInput()
        {
        }
    }
}