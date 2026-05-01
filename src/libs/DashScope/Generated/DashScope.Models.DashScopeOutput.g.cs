
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
            global::System.Collections.Generic.IList<object>? results,
            bool? finished)
        {
            this.Text = text;
            this.FinishReason = finishReason;
            this.Choices = choices;
            this.TaskId = taskId;
            this.TaskStatus = taskStatus;
            this.TaskMetrics = taskMetrics;
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