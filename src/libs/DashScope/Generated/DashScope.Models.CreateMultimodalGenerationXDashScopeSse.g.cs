
#nullable enable

namespace DashScope
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateMultimodalGenerationXDashScopeSse
    {
        /// <summary>
        ///
        /// </summary>
        Enable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateMultimodalGenerationXDashScopeSseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateMultimodalGenerationXDashScopeSse value)
        {
            return value switch
            {
                CreateMultimodalGenerationXDashScopeSse.Enable => "enable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateMultimodalGenerationXDashScopeSse? ToEnum(string value)
        {
            return value switch
            {
                "enable" => CreateMultimodalGenerationXDashScopeSse.Enable,
                _ => null,
            };
        }
    }
}