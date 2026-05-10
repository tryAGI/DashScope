
#nullable enable

namespace DashScope
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DashScopeOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        public string? FinishReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        public global::System.Collections.Generic.IList<object>? Choices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_status")]
        public string? TaskStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_metrics")]
        public object? TaskMetrics { get; set; }

        /// <summary>
        /// Time when the asynchronous task was submitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submit_time")]
        public string? SubmitTime { get; set; }

        /// <summary>
        /// Time when the asynchronous task started running.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduled_time")]
        public string? ScheduledTime { get; set; }

        /// <summary>
        /// Time when the asynchronous task finished.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// Generated video URL returned after a successful Wan video task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_url")]
        public string? VideoUrl { get; set; }

        /// <summary>
        /// Original prompt submitted with the task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orig_prompt")]
        public string? OrigPrompt { get; set; }

        /// <summary>
        /// Prompt used by the model after prompt rewriting, when returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actual_prompt")]
        public string? ActualPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<object>? Results { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finished")]
        public bool? Finished { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DashScopeOutput" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="finishReason"></param>
        /// <param name="choices"></param>
        /// <param name="taskId"></param>
        /// <param name="taskStatus"></param>
        /// <param name="taskMetrics"></param>
        /// <param name="submitTime">
        /// Time when the asynchronous task was submitted.
        /// </param>
        /// <param name="scheduledTime">
        /// Time when the asynchronous task started running.
        /// </param>
        /// <param name="endTime">
        /// Time when the asynchronous task finished.
        /// </param>
        /// <param name="videoUrl">
        /// Generated video URL returned after a successful Wan video task.
        /// </param>
        /// <param name="origPrompt">
        /// Original prompt submitted with the task.
        /// </param>
        /// <param name="actualPrompt">
        /// Prompt used by the model after prompt rewriting, when returned.
        /// </param>
        /// <param name="results"></param>
        /// <param name="finished"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DashScopeOutput(
            string? text,
            string? finishReason,
            global::System.Collections.Generic.IList<object>? choices,
            string? taskId,
            string? taskStatus,
            object? taskMetrics,
            string? submitTime,
            string? scheduledTime,
            string? endTime,
            string? videoUrl,
            string? origPrompt,
            string? actualPrompt,
            global::System.Collections.Generic.IList<object>? results,
            bool? finished)
        {
            this.Text = text;
            this.FinishReason = finishReason;
            this.Choices = choices;
            this.TaskId = taskId;
            this.TaskStatus = taskStatus;
            this.TaskMetrics = taskMetrics;
            this.SubmitTime = submitTime;
            this.ScheduledTime = scheduledTime;
            this.EndTime = endTime;
            this.VideoUrl = videoUrl;
            this.OrigPrompt = origPrompt;
            this.ActualPrompt = actualPrompt;
            this.Results = results;
            this.Finished = finished;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DashScopeOutput" /> class.
        /// </summary>
        public DashScopeOutput()
        {
        }

    }
}