#nullable enable

namespace DashScope
{
    public partial interface IGenerationClient
    {
        /// <summary>
        /// Create a multimodal generation request<br/>
        /// Creates synchronous multimodal generation requests, including Qwen image-edit models and Wan 2.6 image generation/editing models.
        /// </summary>
        /// <param name="xDashScopeSse"></param>
        /// <param name="xDashScopeWorkSpace"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DashScope.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DashScope.DashScopeResponse> CreateMultimodalGenerationAsync(

            global::DashScope.DashScopeRequest request,
            global::DashScope.CreateMultimodalGenerationXDashScopeSse? xDashScopeSse = default,
            string? xDashScopeWorkSpace = default,
            global::DashScope.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a multimodal generation request<br/>
        /// Creates synchronous multimodal generation requests, including Qwen image-edit models and Wan 2.6 image generation/editing models.
        /// </summary>
        /// <param name="xDashScopeSse"></param>
        /// <param name="xDashScopeWorkSpace"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DashScope.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DashScope.AutoSDKHttpResponse<global::DashScope.DashScopeResponse>> CreateMultimodalGenerationAsResponseAsync(

            global::DashScope.DashScopeRequest request,
            global::DashScope.CreateMultimodalGenerationXDashScopeSse? xDashScopeSse = default,
            string? xDashScopeWorkSpace = default,
            global::DashScope.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a multimodal generation request<br/>
        /// Creates synchronous multimodal generation requests, including Qwen image-edit models and Wan 2.6 image generation/editing models.
        /// </summary>
        /// <param name="xDashScopeSse"></param>
        /// <param name="xDashScopeWorkSpace"></param>
        /// <param name="model"></param>
        /// <param name="input"></param>
        /// <param name="parameters"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DashScope.DashScopeResponse> CreateMultimodalGenerationAsync(
            string model,
            global::DashScope.DashScopeInput input,
            global::DashScope.CreateMultimodalGenerationXDashScopeSse? xDashScopeSse = default,
            string? xDashScopeWorkSpace = default,
            object? parameters = default,
            global::DashScope.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}