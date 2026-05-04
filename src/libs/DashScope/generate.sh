#!/usr/bin/env bash
set -euo pipefail

# Hand-maintained OpenAPI spec based on Alibaba Cloud Model Studio DashScope docs:
# https://www.alibabacloud.com/help/en/model-studio/qwen-api-via-dashscope
# https://www.alibabacloud.com/help/en/model-studio/text-to-video-api-reference

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace DashScope \
  --clientClassName DashScopeClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
