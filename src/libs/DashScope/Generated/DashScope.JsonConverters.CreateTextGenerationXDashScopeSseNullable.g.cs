#nullable enable

namespace DashScope.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTextGenerationXDashScopeSseNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DashScope.CreateTextGenerationXDashScopeSse?>
    {
        /// <inheritdoc />
        public override global::DashScope.CreateTextGenerationXDashScopeSse? Read(
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
                        return global::DashScope.CreateTextGenerationXDashScopeSseExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DashScope.CreateTextGenerationXDashScopeSse)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DashScope.CreateTextGenerationXDashScopeSse?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DashScope.CreateTextGenerationXDashScopeSse? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DashScope.CreateTextGenerationXDashScopeSseExtensions.ToValueString(value.Value));
            }
        }
    }
}
