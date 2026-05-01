#nullable enable

namespace DashScope.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateImageGenerationTaskXDashScopeAsyncNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DashScope.CreateImageGenerationTaskXDashScopeAsync?>
    {
        /// <inheritdoc />
        public override global::DashScope.CreateImageGenerationTaskXDashScopeAsync? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::DashScope.CreateImageGenerationTaskXDashScopeAsyncExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DashScope.CreateImageGenerationTaskXDashScopeAsync)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DashScope.CreateImageGenerationTaskXDashScopeAsync?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DashScope.CreateImageGenerationTaskXDashScopeAsync? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DashScope.CreateImageGenerationTaskXDashScopeAsyncExtensions.ToValueString(value.Value));
            }
        }
    }
}
