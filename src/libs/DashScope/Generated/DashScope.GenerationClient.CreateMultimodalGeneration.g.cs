
#nullable enable

namespace DashScope
{
    public partial class GenerationClient
    {


        private static readonly global::DashScope.EndPointSecurityRequirement s_CreateMultimodalGenerationSecurityRequirement0 =
            new global::DashScope.EndPointSecurityRequirement
            {
                Authorizations = new global::DashScope.EndPointAuthorizationRequirement[]
                {                    new global::DashScope.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "BearerAuth",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::DashScope.EndPointSecurityRequirement[] s_CreateMultimodalGenerationSecurityRequirements =
            new global::DashScope.EndPointSecurityRequirement[]
            {                s_CreateMultimodalGenerationSecurityRequirement0,
            };
        partial void PrepareCreateMultimodalGenerationArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::DashScope.CreateMultimodalGenerationXDashScopeSse? xDashScopeSse,
            ref string? xDashScopeWorkSpace,
            global::DashScope.DashScopeRequest request);
        partial void PrepareCreateMultimodalGenerationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::DashScope.CreateMultimodalGenerationXDashScopeSse? xDashScopeSse,
            string? xDashScopeWorkSpace,
            global::DashScope.DashScopeRequest request);
        partial void ProcessCreateMultimodalGenerationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateMultimodalGenerationResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::DashScope.DashScopeResponse> CreateMultimodalGenerationAsync(

            global::DashScope.DashScopeRequest request,
            global::DashScope.CreateMultimodalGenerationXDashScopeSse? xDashScopeSse = default,
            string? xDashScopeWorkSpace = default,
            global::DashScope.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateMultimodalGenerationArguments(
                httpClient: HttpClient,
                xDashScopeSse: ref xDashScopeSse,
                xDashScopeWorkSpace: ref xDashScopeWorkSpace,
                request: request);


            var __authorizations = global::DashScope.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateMultimodalGenerationSecurityRequirements,
                operationName: "CreateMultimodalGenerationAsync");

            using var __timeoutCancellationTokenSource = global::DashScope.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::DashScope.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::DashScope.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::DashScope.PathBuilder(
                                path: "/services/aigc/multimodal-generation/generation",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::DashScope.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }

            if (xDashScopeSse != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("X-DashScope-SSE", xDashScopeSse?.ToValueString() ?? string.Empty);
            }
            if (xDashScopeWorkSpace != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("X-DashScope-WorkSpace", xDashScopeWorkSpace.ToString());
            }

                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::DashScope.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateMultimodalGenerationRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    xDashScopeSse: xDashScopeSse,
                    xDashScopeWorkSpace: xDashScopeWorkSpace,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::DashScope.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::DashScope.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateMultimodalGeneration",
                                methodName: "CreateMultimodalGenerationAsync",
                                pathTemplate: "\"/services/aigc/multimodal-generation/generation\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::DashScope.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::DashScope.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateMultimodalGeneration",
                                methodName: "CreateMultimodalGenerationAsync",
                                pathTemplate: "\"/services/aigc/multimodal-generation/generation\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::DashScope.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::DashScope.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::DashScope.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::DashScope.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateMultimodalGeneration",
                                methodName: "CreateMultimodalGenerationAsync",
                                pathTemplate: "\"/services/aigc/multimodal-generation/generation\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::DashScope.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessCreateMultimodalGenerationResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::DashScope.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::DashScope.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateMultimodalGeneration",
                                methodName: "CreateMultimodalGenerationAsync",
                                pathTemplate: "\"/services/aigc/multimodal-generation/generation\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::DashScope.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::DashScope.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateMultimodalGeneration",
                                methodName: "CreateMultimodalGenerationAsync",
                                pathTemplate: "\"/services/aigc/multimodal-generation/generation\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessCreateMultimodalGenerationResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::DashScope.DashScopeResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw new global::DashScope.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::DashScope.DashScopeResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw new global::DashScope.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
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
        public async global::System.Threading.Tasks.Task<global::DashScope.DashScopeResponse> CreateMultimodalGenerationAsync(
            string model,
            global::DashScope.DashScopeInput input,
            global::DashScope.CreateMultimodalGenerationXDashScopeSse? xDashScopeSse = default,
            string? xDashScopeWorkSpace = default,
            object? parameters = default,
            global::DashScope.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::DashScope.DashScopeRequest
            {
                Model = model,
                Input = input,
                Parameters = parameters,
            };

            return await CreateMultimodalGenerationAsync(
                xDashScopeSse: xDashScopeSse,
                xDashScopeWorkSpace: xDashScopeWorkSpace,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}