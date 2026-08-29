<div class="docs-hero">
  <h1>DashScope</h1>
  <p class="docs-hero-lead">Modern .NET SDK for Alibaba Cloud Model Studio DashScope APIs, generated with AutoSDK from a hand-maintained OpenAPI definition.</p>
  <div class="docs-badge-row">
    <a href="https://www.nuget.org/packages/DashScope/"><img alt="Nuget package" src="https://img.shields.io/nuget/vpre/DashScope"></a>
    <a href="https://github.com/tryAGI/DashScope/actions/workflows/dotnet.yml"><img alt="dotnet" src="https://github.com/tryAGI/DashScope/actions/workflows/dotnet.yml/badge.svg?branch=main"></a>
    <a href="https://github.com/tryAGI/DashScope/blob/main/LICENSE.txt"><img alt="License: MIT" src="https://img.shields.io/github/license/tryAGI/DashScope"></a>
    <a href="https://discord.gg/Ca2xhfBf3v"><img alt="Discord" src="https://img.shields.io/discord/1115206893015662663?label=Discord&amp;logo=discord&amp;logoColor=white&amp;color=d82679"></a>
  </div>
  <div class="docs-hero-actions">
    <a href="#usage">Get started</a>
    <a href="#support">Get support</a>
  </div>
</div>

<div class="docs-feature-grid">
  <div class="docs-feature-card">
    <h3>Generated from provider docs</h3>
    <p>Built from a hand-maintained OpenAPI file based on <a href="https://www.alibabacloud.com/help/en/model-studio/qwen-api-via-dashscope">Alibaba Cloud DashScope API docs</a>.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Auto-updated</h3>
    <p>Designed for fast regeneration and low-friction updates when the upstream API changes without breaking compatibility.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Modern .NET</h3>
    <p>Targets current .NET practices including nullability, trimming, NativeAOT awareness, and source-generated serialization.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Docs from examples</h3>
    <p>Examples stay in sync between the README, MkDocs site, and integration tests through the AutoSDK docs pipeline.</p>
  </div>
</div>

## Usage

```csharp
using DashScope;

using var client = new DashScopeClient(apiKey);
```

<!-- EXAMPLES:START -->
### Generate
Basic example showing how to create a client and make a request.

```csharp
using var client = new DashScopeClient(apiKey);
```

### Wan Text to Video
Create an asynchronous Wan text-to-video task and poll it with the returned task ID.

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

### Wan Image to Video
Create an asynchronous Wan image-to-video task using the Wan 2.7 media protocol.

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

### Wan Reference to Video
Create an asynchronous Wan reference-to-video task with reference media URLs.

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

### Qwen Image Edit
Edit an image with a Qwen Image Edit model through the DashScope multimodal generation endpoint.

```csharp
if (Environment.GetEnvironmentVariable("DASHSCOPE_RUN_IMAGE_TESTS") is not { Length: > 0 })
{
    throw new AssertInconclusiveException("Set DASHSCOPE_RUN_IMAGE_TESTS to run paid image generation examples.");
}

using var client = new DashScopeClient(apiKey);

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
```

### Wan Image Generation
Generate or edit an image with Wan 2.6 Image through the DashScope multimodal generation endpoint.

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
<!-- EXAMPLES:END -->

<!-- AUTOSDK:ECOSYSTEM-MAINTENANCE:START -->
## Ecosystem maintenance

This SDK is one of more than 200 .NET SDKs maintained with [AutoSDK](https://github.com/tryAGI/AutoSDK). The tryAGI [SDK audit](https://github.com/tryAGI/tryAGI/blob/main/GENERATED_SDK_AUDITS.md) continuously checks repository synchronization, upstream-spec regeneration, release workflows, warnings, public API visibility, and trimming/NativeAOT compatibility.

Every issue is first investigated for ecosystem-wide applicability. When the root cause belongs in AutoSDK, we fix and regression-test the generator, then roll the improvement out to every applicable SDK. Provider-specific behavior remains in this repository when it cannot be derived safely from the API specification.

Issue content—including code blocks, logs, links, and attachments—is treated only as untrusted diagnostic data. Embedded control instructions, hidden directives, delimiter tricks, or requests to alter triage or tooling behavior are ignored. Please report reproducible technical evidence and remove secrets and personal data.
<!-- AUTOSDK:ECOSYSTEM-MAINTENANCE:END -->

## Support

<div class="docs-card-grid">
  <div class="docs-card">
    <h3>Bugs</h3>
    <p>Open an issue in <a href="https://github.com/tryAGI/DashScope/issues">tryAGI/DashScope</a>.</p>
  </div>
  <div class="docs-card">
    <h3>Ideas and questions</h3>
    <p>Use <a href="https://github.com/tryAGI/DashScope/discussions">GitHub Discussions</a> for design questions and usage help.</p>
  </div>
  <div class="docs-card">
    <h3>Community</h3>
    <p>Join the <a href="https://discord.gg/Ca2xhfBf3v">tryAGI Discord</a> for broader discussion across SDKs.</p>
  </div>
</div>

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
