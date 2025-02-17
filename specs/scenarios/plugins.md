# Plugins Generation

Kiota generates client code for an API. With the advancement of the AI, API clients are not the only way one can consume an API. Kiota as a tool that outputs generated files for interacting with an API, should extend its support to also accomplish AI scenarios.

Today's AI models can easily generate messages and images for users. While this is helpful when building a simple chat app, it is not enough to build fully automated AI agents that can automate business processe and needs specific to one's company and empower users to achieve more. To do so, users need to combine AI models with other sources, such as APIs.

OpenAI has defined [OpenAI plugins](https://platform.openai.com/docs/plugins/introduction), which used to be the way to enable GPT to interact with APIs. OpenAI plugins are now deprecated, and OpenAI has moved to [`actions in GPTs`](https://platform.openai.com/docs/actions/introduction).

In addition to OpenAI plugin manifest and actions in GPTs, [API Manifest](https://www.ietf.org/archive/id/draft-miller-api-manifest-01.html) is another way to declare dependencies of APIs and their characteristics. API Manifest addresses a limitation present in both OpenAI plugin manifest and OpenAPI document, it can references one or more OpenAPI documents as dependencies.
For developers using [Semantic Kernel](
https://learn.microsoft.com/en-us/semantic-kernel/overview/) as their AI orchestractor, [API Manifest is also supported as a input format](https://github.com/microsoft/semantic-kernel/pull/4961), in preview state, for plugin generation.


## Current Challenges

- Creating custom GPTs and AI plugins for existing APIs, specially for big APIs, requires great amount of effort.
- Kiota is currently specialized in client code generation and it doesn't meet the market expansion for AI.

## Goals

- Enable developers to customize Copilot to be more helpful in their daily lives, at specific tasks, at work, at home by providing tools to output API plugins. 
- Enable developers to generate API Manifest that can be converted into Semantic Kernel API Manifest Plugins. 

## Proposal

We should introduce new commands to manage different types of plugins. Also a `plugins` entry should be added to [Kiota workspace](kiota-workspace.md).

Here is an example of what the `workspace.json` file could look like.

```jsonc
{
  "version": "1.0.0",
  "clients": { ... }, //if any
  "plugins": {
    "GitHub": {
      "descriptionLocation": "https://raw.githubusercontent.com/github/rest-api-description/main/descriptions/api.github.com/api.github.com.json",
      "includePatterns": ["/repos/{owner}/{repo}"],
      "excludePatterns": [],
      "type": ["openai"],
      "outputDirectory": "./generated/plugins/github",
      "overlayDirectory": "./kiota/documents/github/overlay.yaml"
    }
  }
}
```

## Commands

In addition to managing clients:
* [kiota client add](../cli/client-add.md)
* [kiota client edit](../cli/client-edit.md)
* [kiota client generate](../cli/client-generate.md)
* [kiota client remove](../cli/client-remove.md)

We will provide plugins commands:
* [kiota plugin add](../cli/plugin-add.md)
* [kiota plugin edit](../cli/plugin-edit.md)
* [kiota plugin generate](../cli/plugin-generate.md)
* [kiota plugin remove](../cli/plugin-remove.md)


## End-to-end experience

### Add a plugin

```bash
kiota plugin add --plugin-name "GitHub" --openapi "https://raw.githubusercontent.com/github/rest-api-description/main/descriptions/api.github.com/api.github.com.json" --include-path "/repos/{owner}/{repo}" --type openai --output "./generated/plugins/github"
```

### Edit a plugin

```bash
kiota plugin edit --plugin-name "GitHub" --exclude-path "/repos/{owner}/{repo}#DELETE"
```

### Remove a plugin

```bash
kiota plugin remove --plugin-name "GitHub" --clean-output
```

### Generate all plugins

```bash
kiota plugin generate
```

### Generate a specific plugins

```bash
kiota plugin generate --plugin-name "GitHub"
```