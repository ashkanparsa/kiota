# kiota client remove

## Description

`kiota client remove` allows a developer to remove an existing client from the `workspace.json` file. The command will remove the entry from the `clients` section of `workspace.json` file. The command has a single required parameters; the name of the client. 

The command also has one optional parameter, the ability to remove the generated client. If provided, kiota will delete the folder and its content specified at the `outputPath` from the client configuration. It will also remove the local version of the OpenAPI description file (specified by the `x-ms-kiotaHash` property in the API Manifest). The API Manifest is also updated to remove the dependency from the list of dependencies.

| Parameters | Required | Example | Description | Telemetry | 
| -- | -- | -- | -- | -- |
| `--client-name \| --cn` | Yes | graphDelegated | Name of the client | Yes, without its value |
| `--clean-output \| --co` | No |  | Cleans the generated client | Yes |

#### Using kiota client remove

```bash
kiota client remove --client-name "GraphClient" --clean-output
```

The resulting `workspace.json` file will look like this:

```jsonc
{
  "version": "1.0.0",
  "clients": { }
}
```

_The resulting `apimanifest.json` file will look like this:_

```jsonc
{
  "apiDependencies": { }
}
```

## File structure
```bash
/
 └─.kiota
    └─workspace.json
    └─apimanifest.json
 └─generated
    └─graph
```
