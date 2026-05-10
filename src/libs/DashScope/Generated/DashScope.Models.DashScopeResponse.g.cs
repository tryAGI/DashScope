
#nullable enable

namespace DashScope
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DashScopeResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::DashScope.DashScopeOutput? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::DashScope.Usage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DashScopeResponse" /> class.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="output"></param>
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DashScopeResponse(
            string? requestId,
            string? code,
            string? message,
            global::DashScope.DashScopeOutput? output,
            global::DashScope.Usage? usage)
        {
            this.RequestId = requestId;
            this.Code = code;
            this.Message = message;
            this.Output = output;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DashScopeResponse" /> class.
        /// </summary>
        public DashScopeResponse()
        {
        }

    }
}