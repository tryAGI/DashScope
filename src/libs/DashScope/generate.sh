#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

# Hand-maintained OpenAPI spec based on Alibaba Cloud Model Studio DashScope docs:
# https://www.alibabacloud.com/help/en/model-studio/qwen-api-via-dashscope
# https://www.alibabacloud.com/help/en/model-studio/text-to-video-api-reference
# https://www.alibabacloud.com/help/en/model-studio/image-to-video-general-api-reference
# https://www.alibabacloud.com/help/en/model-studio/legacy-image-to-video-api-reference
# https://www.alibabacloud.com/help/en/model-studio/wan-video-to-video-api-reference
# https://help.aliyun.com/zh/model-studio/wan-image-generation-api-reference
# https://help.aliyun.com/zh/model-studio/qwen-image-edit-api
install_autosdk_cli
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace DashScope \
  --clientClassName DashScopeClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
