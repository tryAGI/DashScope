/*
order: 30
title: Qwen Image Edit
slug: qwen-image-edit

Edit an image with a Qwen Image Edit model through the DashScope multimodal generation endpoint.
*/

using System.Collections.Generic;

namespace DashScope.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_QwenImageEdit()
    {
        if (Environment.GetEnvironmentVariable("DASHSCOPE_RUN_IMAGE_TESTS") is not { Length: > 0 })
        {
            throw new AssertInconclusiveException("Set DASHSCOPE_RUN_IMAGE_TESTS to run paid image generation examples.");
        }

        using var client = GetAuthenticatedClient();

        var response = await client.Generation.CreateMultimodalGenerationAsync(
            model: "qwen-image-edit-max",
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
                                Image = "https://help-static-aliyun-doc.aliyuncs.com/file-manage-files/zh-CN/20260310/jiydyi/image+%2818%29-2026-03-10-16-39-59.webp",
                            },
                            new()
                            {
                                Text = "Add a small handwritten title in the lower-right corner while preserving the ink-wash style.",
                            },
                        },
                    },
                },
            },
            parameters: new Dictionary<string, object>
            {
                ["n"] = 1,
                ["prompt_extend"] = true,
                ["watermark"] = false,
                ["size"] = "1024*1024",
            });

        response.Output.Should().NotBeNull();
    }
}
