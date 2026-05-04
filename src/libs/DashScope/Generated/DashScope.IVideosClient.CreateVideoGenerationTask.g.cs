#nullable enable

namespace DashScope
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Create an asynchronous Wan video generation task<br/>
        /// Creates a DashScope Wan text-to-video generation task. Poll `/tasks/{task_id}` with the returned task ID to retrieve the result.
        /// </summary>
        /// <param name="xDashScopeAsync"></param>
        /// <param name="xDashScopeWorkSpace"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DashScope.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DashScope.DashScopeResponse> CreateVideoGenerationTaskAsync(

            global::DashScope.DashScopeRequest request,
            global::DashScope.CreateVideoGenerationTaskXDashScopeAsync? xDashScopeAsync = default,
            string? xDashScopeWorkSpace = default,
            global::DashScope.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an asynchronous Wan video generation task<br/>
        /// Creates a DashScope Wan text-to-video generation task. Poll `/tasks/{task_id}` with the returned task ID to retrieve the result.
        /// </summary>
        /// <param name="xDashScopeAsync"></param>
        /// <param name="xDashScopeWorkSpace"></param>
        /// <param name="model"></param>
        /// <param name="input"></param>
        /// <param name="parameters"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DashScope.DashScopeResponse> CreateVideoGenerationTaskAsync(
            string model,
            global::DashScope.DashScopeInput input,
            global::DashScope.CreateVideoGenerationTaskXDashScopeAsync? xDashScopeAsync = default,
            string? xDashScopeWorkSpace = default,
            object? parameters = default,
            global::DashScope.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}