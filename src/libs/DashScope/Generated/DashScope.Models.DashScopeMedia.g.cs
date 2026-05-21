
#nullable enable

namespace DashScope
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DashScopeMedia
    {
        /// <summary>
        /// Wan media role such as first_frame, last_frame, driving_audio, or first_clip.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Public HTTP or HTTPS URL for the media asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DashScopeMedia" /> class.
        /// </summary>
        /// <param name="type">
        /// Wan media role such as first_frame, last_frame, driving_audio, or first_clip.
        /// </param>
        /// <param name="url">
        /// Public HTTP or HTTPS URL for the media asset.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DashScopeMedia(
            string type,
            string url)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DashScopeMedia" /> class.
        /// </summary>
        public DashScopeMedia()
        {
        }

    }
}