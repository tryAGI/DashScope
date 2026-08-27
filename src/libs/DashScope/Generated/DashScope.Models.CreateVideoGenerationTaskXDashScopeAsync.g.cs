
#nullable enable

namespace DashScope
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateVideoGenerationTaskXDashScopeAsync
    {
        /// <summary>
        ///
        /// </summary>
        Enable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoGenerationTaskXDashScopeAsyncExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoGenerationTaskXDashScopeAsync value)
        {
            return value switch
            {
                CreateVideoGenerationTaskXDashScopeAsync.Enable => "enable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoGenerationTaskXDashScopeAsync? ToEnum(string value)
        {
            return value switch
            {
                "enable" => CreateVideoGenerationTaskXDashScopeAsync.Enable,
                _ => null,
            };
        }
    }
}