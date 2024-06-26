# ResoMemos
A WebSocket-Based Bridge for Resonite to the [Memos](https://github.com/usememos/memos) API.

## ⚠️ Status
This is very incomplete! While this application will run and some calls to the MemoService endpoints are working, this is a heavy work-in-progress. **I do not advise using this software as-is.**

## Features
The current plan is to support the basics needed to list tags, search memos, and provide their associated resources in a way that's suitable to a client built in Resonite. This ideally will include translating [Memos' Markdown Syntax](https://www.usememos.com/docs/getting-started/content-syntax) to Resonite's in-engine Rich Text formatting or supplementing it with UIX templates. However, the first public release will likely just display raw markdown as a start.

## Structure
There are two C# projects in this codebase:

### Memos-OpenApiClient
This project can be largely ignored. This is autogenerated using the [OpenApi Generator](https://openapi-generator.tech/docs/installation/) with the Memos [OpenApi Spec YAML as input](https://memos.apidocumentation.com/reference). I've barely looked at this code and is soley here as a dependency to interact with the [Memos API](https://memos.apidocumentation.com/reference).

### ResoMemos
This is the main project which uses `Memos-OpenApiClient` as a dependency.

Using [WebSocket Sharp](https://github.com/sta/websocket-sharp), this application acts as a websocket server to proxy the Memos API into Resonite. This is done with "Op Codes" that mimmic the API endpoints provided by Memos. The intent is to resemble the normal output of the Memos API over websockets while taking Resonite's current limitations into consideration. Namely, the lack of collections support which would make constructing and parsing JSON much easier.

The intent is also to provide some level of security while interacting with the Memos API through Resonite. Storing API keys or other such credentials within Resonite is not currently recommended. Until Resonite can better support secure credentials, this websocket proxy can keep the process of authenticating with the Memos API away from Resonite itself.

### Resonite In-Engine Client
Outside of this codebase, there is a work-in-progress client for use in-engine. I plan to release this client as a `.resonitepackage` along with compiled binaries for the websocket proxy.

## Building
You will need a recent .Net SDK installed. For this project I simply used .Net 8 and it's what I would recommend for consistency.

1. Clone the Repository:
    ```
    git clone https://github.com/PointerOffset/ResoMemos.git
    ```
2. Change to the project directory for `ResoMemos`. The `Memos-OpenApiClient` should build automatically as a depdency for `ResoMemos`.
   ```
   cd ./ResoMemos/ResoMemos
   ```
3. Restore packages and build the project:
   ```
   dotnet restore
   dotnet build
   ```

## Running the Websocket Proxy:
Once you've built the project (or if you are running a precompiled binary), you will need to configure the application to authenticate with your Memos instance.

Create a file named `appsettings.json` that lives in the same directory as the ResoMemos executable. You can copy and rename `appsettings.example.json` as a template. Update the contents to point to the url and port for your Memos instance and [add a token for authentication](https://www.usememos.com/docs/security/access-tokens).
```json
{
    "ResoMemosSettings": {
      "BasePath": "https://memos.server",
      "Token": "your-token-here",
      "WebsocketPort": 5555
    }
}
```

## Usage
Within Resonite, create a `WebSocketClient` component configured to connect to your websocket server and service endpoint.

For example, your connection endpoint might look like `ws://localhost.local:5555/MemoService`. This connection will accept and respond to calls made for the `ResoMemos.WSMemoServiceApi` class.