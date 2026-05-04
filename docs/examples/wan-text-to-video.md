# Wan Text to Video

Create an asynchronous Wan text-to-video task and poll it with the returned task ID.

This example assumes `using DashScope;` is in scope and `apiKey` contains your DashScope API key.

```csharp
if (Environment.GetEnvironmentVariable("DASHSCOPE_RUN_VIDEO_TESTS") is not { Length: > 0 })
{
    throw new AssertInconclusiveException("Set DASHSCOPE_RUN_VIDEO_TESTS to run paid video generation examples.");
}

using var client = new DashScopeClient(apiKey);

var response = await client.Videos.CreateVideoGenerationTaskAsync(
    model: "wan2.6-t2v",
    input: new DashScopeInput
    {
        Prompt = "A cinematic product reveal of a silver smartwatch on a dark glass table.",
    },
    xDashScopeAsync: CreateVideoGenerationTaskXDashScopeAsync.Enable,
    parameters: new Dictionary<string, object>
    {
        ["size"] = "832*480",
        ["prompt_extend"] = true,
    });
```