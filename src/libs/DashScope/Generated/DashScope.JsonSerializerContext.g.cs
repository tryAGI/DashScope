
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace DashScope
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::DashScope.JsonConverters.CreateTextGenerationXDashScopeSseJsonConverter),

            typeof(global::DashScope.JsonConverters.CreateTextGenerationXDashScopeSseNullableJsonConverter),

            typeof(global::DashScope.JsonConverters.CreateMultimodalGenerationXDashScopeSseJsonConverter),

            typeof(global::DashScope.JsonConverters.CreateMultimodalGenerationXDashScopeSseNullableJsonConverter),

            typeof(global::DashScope.JsonConverters.CreateImageGenerationTaskXDashScopeAsyncJsonConverter),

            typeof(global::DashScope.JsonConverters.CreateImageGenerationTaskXDashScopeAsyncNullableJsonConverter),

            typeof(global::DashScope.JsonConverters.CreateVideoGenerationTaskXDashScopeAsyncJsonConverter),

            typeof(global::DashScope.JsonConverters.CreateVideoGenerationTaskXDashScopeAsyncNullableJsonConverter),

            typeof(global::DashScope.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::DashScope.ContentPart>>),

            typeof(global::DashScope.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<object>, object>),

            typeof(global::DashScope.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DashScope.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DashScope.DashScopeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DashScope.DashScopeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DashScope.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DashScope.Message))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DashScope.DashScopeMedia>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DashScope.DashScopeMedia))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DashScope.OneOf<string, global::System.Collections.Generic.IList<global::DashScope.ContentPart>>), TypeInfoPropertyName = "OneOfStringIListContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DashScope.ContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DashScope.ContentPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DashScope.DashScopeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DashScope.DashScopeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DashScope.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DashScope.EmbeddingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DashScope.OneOf<string, global::System.Collections.Generic.IList<object>, object>), TypeInfoPropertyName = "OneOfStringIListObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DashScope.EmbeddingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DashScope.EmbeddingResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DashScope.EmbeddingObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DashScope.EmbeddingObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DashScope.CreateTextGenerationXDashScopeSse), TypeInfoPropertyName = "CreateTextGenerationXDashScopeSse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DashScope.CreateMultimodalGenerationXDashScopeSse), TypeInfoPropertyName = "CreateMultimodalGenerationXDashScopeSse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DashScope.CreateImageGenerationTaskXDashScopeAsync), TypeInfoPropertyName = "CreateImageGenerationTaskXDashScopeAsync2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DashScope.CreateVideoGenerationTaskXDashScopeAsync), TypeInfoPropertyName = "CreateVideoGenerationTaskXDashScopeAsync2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DashScope.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DashScope.DashScopeMedia>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DashScope.OneOf<string, global::System.Collections.Generic.List<global::DashScope.ContentPart>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DashScope.ContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DashScope.OneOf<string, global::System.Collections.Generic.List<object>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DashScope.EmbeddingObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<float>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}