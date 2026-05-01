
#nullable enable

namespace DashScope
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateImageGenerationTaskXDashScopeAsync
    {
        /// <summary>
        /// 
        /// </summary>
        Enable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageGenerationTaskXDashScopeAsyncExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageGenerationTaskXDashScopeAsync value)
        {
            return value switch
            {
                CreateImageGenerationTaskXDashScopeAsync.Enable => "enable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageGenerationTaskXDashScopeAsync? ToEnum(string value)
        {
            return value switch
            {
                "enable" => CreateImageGenerationTaskXDashScopeAsync.Enable,
                _ => null,
            };
        }
    }
}