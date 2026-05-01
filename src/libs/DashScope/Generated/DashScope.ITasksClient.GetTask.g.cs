#nullable enable

namespace DashScope
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Retrieve an asynchronous task result
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="xDashScopeWorkSpace"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DashScope.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DashScope.DashScopeResponse> GetTaskAsync(
            string taskId,
            string? xDashScopeWorkSpace = default,
            global::DashScope.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}