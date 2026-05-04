/*
order: 21
title: Wan Image to Video
slug: wan-image-to-video

Create an asynchronous Wan image-to-video task using the Wan 2.7 media protocol.
*/

using System.Collections.Generic;

namespace DashScope.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_WanImageToVideo()
    {
        if (Environment.GetEnvironmentVariable("DASHSCOPE_RUN_VIDEO_TESTS") is not { Length: > 0 })
        {
            throw new AssertInconclusiveException("Set DASHSCOPE_RUN_VIDEO_TESTS to run paid video generation examples.");
        }

        using var client = GetAuthenticatedClient();

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

        response.Output.Should().NotBeNull();
        response.Output!.TaskId.Should().NotBeNullOrWhiteSpace();
    }
}
