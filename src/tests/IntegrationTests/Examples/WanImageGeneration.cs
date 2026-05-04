/*
order: 40
title: Wan Image Generation
slug: wan-image-generation

Generate or edit an image with Wan 2.6 Image through the DashScope multimodal generation endpoint.
*/

using System.Collections.Generic;

namespace DashScope.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_WanImageGeneration()
    {
        if (Environment.GetEnvironmentVariable("DASHSCOPE_RUN_IMAGE_TESTS") is not { Length: > 0 })
        {
            throw new AssertInconclusiveException("Set DASHSCOPE_RUN_IMAGE_TESTS to run paid image generation examples.");
        }

        using var client = GetAuthenticatedClient();

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

        response.Output.Should().NotBeNull();
    }
}
