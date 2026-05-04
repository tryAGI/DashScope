# Wan Image Generation

Generate or edit an image with Wan 2.6 Image through the DashScope multimodal generation endpoint.

This example assumes `using DashScope;` is in scope and `apiKey` contains your DashScope API key.

```csharp
if (Environment.GetEnvironmentVariable("DASHSCOPE_RUN_IMAGE_TESTS") is not { Length: > 0 })
{
    throw new AssertInconclusiveException("Set DASHSCOPE_RUN_IMAGE_TESTS to run paid image generation examples.");
}

using var client = new DashScopeClient(apiKey);

var response = await client.Generation.CreateMultimodalGenerationAsync(
    model: "wan2.6-image",
    input: new DashScopeInput
    {
        Messages = new List<Message>
        {
            new()
            {
                Role = "user",
                Content = new List<ContentPart>
                {
                    new()
                    {
                        Text = "Using the reference image style, create a clean product hero image of a ceramic espresso cup.",
                    },
                    new()
                    {
                        Image = "https://cdn.wanx.aliyuncs.com/tmp/pressure/umbrella1.png",
                    },
                },
            },
        },
    },
    parameters: new Dictionary<string, object>
    {
        ["prompt_extend"] = true,
        ["watermark"] = false,
        ["n"] = 1,
        ["enable_interleave"] = false,
        ["size"] = "1K",
    });
```