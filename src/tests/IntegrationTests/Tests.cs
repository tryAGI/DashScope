namespace DashScope.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static DashScopeClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("DASHSCOPE_API_KEY") is { Length: > 0 } dashScopeKeyValue
                ? dashScopeKeyValue
                : Environment.GetEnvironmentVariable("QWEN_API_KEY") is { Length: > 0 } qwenKeyValue
                ? qwenKeyValue
                : throw new AssertInconclusiveException("DASHSCOPE_API_KEY or QWEN_API_KEY environment variable is not found.");

        var client = new DashScopeClient(apiKey);
        
        return client;
    }
}
