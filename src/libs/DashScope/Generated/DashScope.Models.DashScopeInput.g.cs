
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
        /// <param name="contents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DashScopeInput(
            global::System.Collections.Generic.IList<global::DashScope.Message>? messages,
            string? prompt,
            global::System.Collections.Generic.IList<object>? contents)
        {
            this.Messages = messages;
            this.Prompt = prompt;
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