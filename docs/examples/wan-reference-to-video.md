# Wan Reference to Video

Create an asynchronous Wan reference-to-video task with reference media URLs.

This example assumes `using DashScope;` is in scope and `apiKey` contains your DashScope API key.

```csharp
if (Environment.GetEnvironmentVariable("DASHSCOPE_RUN_VIDEO_TESTS") is not { Length: > 0 })
{
    throw new AssertInconclusiveException("Set DASHSCOPE_RUN_VIDEO_TESTS to run paid video generation examples.");
}

using var client = new DashScopeClient(apiKey);

var response = await client.Videos.CreateVideoGenerationTaskAsync(
    model: "wan2.6-r2v-flash",
    input: new DashScopeInput
    {
        Prompt = "character1 walks through a studio and lifts a cup toward the camera.",
        ReferenceUrls = new List<string>
        {
            "https://cdn.wanxai.com/static/demo-wan26/vace.mp4",
        },
    },
    xDashScopeAsync: CreateVideoGenerationTaskXDashScopeAsync.Enable,
    parameters: new Dictionary<string, object>
    {
        ["size"] = "1280*720",
        ["duration"] = 5,
        ["audio"] = false,
        ["shot_type"] = "multi",
    });
```