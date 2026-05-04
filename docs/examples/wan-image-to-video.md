# Wan Image to Video

Create an asynchronous Wan image-to-video task using the Wan 2.7 media protocol.

This example assumes `using DashScope;` is in scope and `apiKey` contains your DashScope API key.

```csharp
if (Environment.GetEnvironmentVariable("DASHSCOPE_RUN_VIDEO_TESTS") is not { Length: > 0 })
{
    throw new AssertInconclusiveException("Set DASHSCOPE_RUN_VIDEO_TESTS to run paid video generation examples.");
}

using var client = new DashScopeClient(apiKey);

var response = await client.Videos.CreateVideoGenerationTaskAsync(
    model: "wan2.7-i2v",
    input: new DashScopeInput
    {
        Prompt = "A street-style performer steps forward from the wall art and turns toward the camera.",
        Media = new List<DashScopeMedia>
        {
            new()
            {
                Type = "first_frame",
                Url = "https://help-static-aliyun-doc.aliyuncs.com/file-manage-files/zh-CN/20250925/wpimhv/rap.png",
            },
        },
    },
    xDashScopeAsync: CreateVideoGenerationTaskXDashScopeAsync.Enable,
    parameters: new Dictionary<string, object>
    {
        ["resolution"] = "720P",
        ["duration"] = 5,
        ["prompt_extend"] = true,
    });
```