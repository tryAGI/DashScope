/*
order: 22
title: Wan Reference to Video
slug: wan-reference-to-video

Create an asynchronous Wan reference-to-video task with reference media URLs.
*/

using System.Collections.Generic;

namespace DashScope.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_WanReferenceToVideo()
    {
        if (Environment.GetEnvironmentVariable("DASHSCOPE_RUN_VIDEO_TESTS") is not { Length: > 0 })
        {
            throw new AssertInconclusiveException("Set DASHSCOPE_RUN_VIDEO_TESTS to run paid video generation examples.");
        }

        using var client = GetAuthenticatedClient();

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

        response.Output.Should().NotBeNull();
        response.Output!.TaskId.Should().NotBeNullOrWhiteSpace();
    }
}
