
#nullable enable

namespace DashScope
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding")]
        public global::System.Collections.Generic.IList<float>? Embedding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_index")]
        public int? TextIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingObject" /> class.
        /// </summary>
        /// <param name="embedding"></param>
        /// <param name="textIndex"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingObject(
            global::System.Collections.Generic.IList<float>? embedding,
            int? textIndex)
        {
            this.Embedding = embedding;
            this.TextIndex = textIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingObject" /> class.
        /// </summary>
        public EmbeddingObject()
        {
        }
    }
}