#nullable enable

namespace DashScope
{
    public partial interface IGenerationClient
    {
        /// <summary>
        /// Create a text generation request
        /// </summary>
        /// <param name="xDashScopeSse"></param>
        /// <param name="xDashScopeWorkSpace"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DashScope.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DashScope.DashScopeResponse> CreateTextGenerationAsync(

            global::DashScope.DashScopeRequest request,
            global::DashScope.CreateTextGenerationXDashScopeSse? xDashScopeSse = default,
            string? xDashScopeWorkSpace = default,
            global::DashScope.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a text generation request
        /// </summary>
        /// <param name="xDashScopeSse"></param>
        /// <param name="xDashScopeWorkSpace"></param>
        /// <param name="model"></param>
        /// <param name="input"></param>
        /// <param name="parameters"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DashScope.DashScopeResponse> CreateTextGenerationAsync(
            string model,
            global::DashScope.DashScopeInput input,
            global::DashScope.CreateTextGenerationXDashScopeSse? xDashScopeSse = default,
            string? xDashScopeWorkSpace = default,
            object? parameters = default,
            global::DashScope.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}