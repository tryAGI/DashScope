
#nullable enable

namespace DashScope
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Usage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public int? InputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        public int? OutputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_count")]
        public int? ImageCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }

        /// <summary>
        /// Total billable video duration, in seconds, when returned by video tasks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public float? Duration { get; set; }

        /// <summary>
        /// Input video duration, in seconds, when returned by video tasks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_video_duration")]
        public float? InputVideoDuration { get; set; }

        /// <summary>
        /// Output video duration, in seconds, when returned by video tasks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_video_duration")]
        public float? OutputVideoDuration { get; set; }

        /// <summary>
        /// Generated video duration, in seconds, for legacy video task responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_duration")]
        public int? VideoDuration { get; set; }

        /// <summary>
        /// Generated video aspect-ratio label for legacy video task responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_ratio")]
        public string? VideoRatio { get; set; }

        /// <summary>
        /// Number of generated videos.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_count")]
        public int? VideoCount { get; set; }

        /// <summary>
        /// Resolution tier returned by Wan video task responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("SR")]
        public int? Sr { get; set; }

        /// <summary>
        /// Indicates whether a generated video includes audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public bool? Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        /// <param name="inputTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="totalTokens"></param>
        /// <param name="imageCount"></param>
        /// <param name="size"></param>
        /// <param name="duration">
        /// Total billable video duration, in seconds, when returned by video tasks.
        /// </param>
        /// <param name="inputVideoDuration">
        /// Input video duration, in seconds, when returned by video tasks.
        /// </param>
        /// <param name="outputVideoDuration">
        /// Output video duration, in seconds, when returned by video tasks.
        /// </param>
        /// <param name="videoDuration">
        /// Generated video duration, in seconds, for legacy video task responses.
        /// </param>
        /// <param name="videoRatio">
        /// Generated video aspect-ratio label for legacy video task responses.
        /// </param>
        /// <param name="videoCount">
        /// Number of generated videos.
        /// </param>
        /// <param name="sr">
        /// Resolution tier returned by Wan video task responses.
        /// </param>
        /// <param name="audio">
        /// Indicates whether a generated video includes audio.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Usage(
            int? inputTokens,
            int? outputTokens,
            int? totalTokens,
            int? imageCount,
            string? size,
            float? duration,
            float? inputVideoDuration,
            float? outputVideoDuration,
            int? videoDuration,
            string? videoRatio,
            int? videoCount,
            int? sr,
            bool? audio)
        {
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.TotalTokens = totalTokens;
            this.ImageCount = imageCount;
            this.Size = size;
            this.Duration = duration;
            this.InputVideoDuration = inputVideoDuration;
            this.OutputVideoDuration = outputVideoDuration;
            this.VideoDuration = videoDuration;
            this.VideoRatio = videoRatio;
            this.VideoCount = videoCount;
            this.Sr = sr;
            this.Audio = audio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        public Usage()
        {
        }

    }
}