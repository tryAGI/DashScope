/*
order: 20
title: Wan Text to Video
slug: wan-text-to-video

Create an asynchronous Wan text-to-video task and poll it with the returned task ID.
*/

using System.Collections.Generic;

namespace DashScope.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_WanTextToVideo()
    {
        if (Environment.GetEnvironmentVariable("DASHSCOPE_RUN_VIDEO_TESTS") is not { Length: > 0 })
        {
            throw new AssertInconclusiveException("Set DASHSCOPE_RUN_VIDEO_TESTS to run paid video generation examples.");
        }

        using var client = GetAuthenticatedClient();

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

        response.Output.Should().NotBeNull();
        response.Output!.TaskId.Should().NotBeNullOrWhiteSpace();
    }
}
