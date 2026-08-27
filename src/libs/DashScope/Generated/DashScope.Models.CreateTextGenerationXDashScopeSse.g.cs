
#nullable enable

namespace DashScope
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateTextGenerationXDashScopeSse
    {
        /// <summary>
        ///
        /// </summary>
        Enable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextGenerationXDashScopeSseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextGenerationXDashScopeSse value)
        {
            return value switch
            {
                CreateTextGenerationXDashScopeSse.Enable => "enable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextGenerationXDashScopeSse? ToEnum(string value)
        {
            return value switch
            {
                "enable" => CreateTextGenerationXDashScopeSse.Enable,
                _ => null,
            };
        }
    }
}