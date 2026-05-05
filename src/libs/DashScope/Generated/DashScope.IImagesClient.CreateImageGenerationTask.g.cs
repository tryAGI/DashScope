#nullable enable

namespace DashScope
{
    public partial interface IImagesClient
    {
        /// <summary>
        /// Create an asynchronous image generation task
        /// </summary>
        /// <param name="xDashScopeAsync"></param>
        /// <param name="xDashScopeWorkSpace"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DashScope.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DashScope.DashScopeResponse> CreateImageGenerationTaskAsync(

            global::DashScope.DashScopeRequest request,
            global::DashScope.CreateImageGenerationTaskXDashScopeAsync? xDashScopeAsync = default,
            string? xDashScopeWorkSpace = default,
            global::DashScope.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an asynchronous image generation task
        /// </summary>
        /// <param name="xDashScopeAsync"></param>
        /// <param name="xDashScopeWorkSpace"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DashScope.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DashScope.AutoSDKHttpResponse<global::DashScope.DashScopeResponse>> CreateImageGenerationTaskAsResponseAsync(

            global::DashScope.DashScopeRequest request,
            global::DashScope.CreateImageGenerationTaskXDashScopeAsync? xDashScopeAsync = default,
            string? xDashScopeWorkSpace = default,
            global::DashScope.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an asynchronous image generation task
        /// </summary>
        /// <param name="xDashScopeAsync"></param>
        /// <param name="xDashScopeWorkSpace"></param>
        /// <param name="model"></param>
        /// <param name="input"></param>
        /// <param name="parameters"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DashScope.DashScopeResponse> CreateImageGenerationTaskAsync(
            string model,
            global::DashScope.DashScopeInput input,
            global::DashScope.CreateImageGenerationTaskXDashScopeAsync? xDashScopeAsync = default,
            string? xDashScopeWorkSpace = default,
            object? parameters = default,
            global::DashScope.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}