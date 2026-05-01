
#nullable enable

namespace DashScope
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingResponseOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embeddings")]
        public global::System.Collections.Generic.IList<global::DashScope.EmbeddingObject>? Embeddings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingResponseOutput" /> class.
        /// </summary>
        /// <param name="embeddings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingResponseOutput(
            global::System.Collections.Generic.IList<global::DashScope.EmbeddingObject>? embeddings)
        {
            this.Embeddings = embeddings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingResponseOutput" /> class.
        /// </summary>
        public EmbeddingResponseOutput()
        {
        }
    }
}