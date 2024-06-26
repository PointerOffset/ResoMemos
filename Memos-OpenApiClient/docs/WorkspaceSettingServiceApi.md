# Org.OpenAPITools.Api.WorkspaceSettingServiceApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**WorkspaceSettingServiceGetWorkspaceSetting**](WorkspaceSettingServiceApi.md#workspacesettingservicegetworkspacesetting) | **GET** /api/v1/workspace/{name} | GetWorkspaceSetting returns the setting by name. |
| [**WorkspaceSettingServiceSetWorkspaceSetting**](WorkspaceSettingServiceApi.md#workspacesettingservicesetworkspacesetting) | **PATCH** /api/v1/workspace/{setting.name} | SetWorkspaceSetting updates the setting. |

<a id="workspacesettingservicegetworkspacesetting"></a>
# **WorkspaceSettingServiceGetWorkspaceSetting**
> Apiv1WorkspaceSetting WorkspaceSettingServiceGetWorkspaceSetting (string name)

GetWorkspaceSetting returns the setting by name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WorkspaceSettingServiceGetWorkspaceSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new WorkspaceSettingServiceApi(config);
            var name = "name_example";  // string | The resource name of the workspace setting. Format: settings/{setting}

            try
            {
                // GetWorkspaceSetting returns the setting by name.
                Apiv1WorkspaceSetting result = apiInstance.WorkspaceSettingServiceGetWorkspaceSetting(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceSettingServiceApi.WorkspaceSettingServiceGetWorkspaceSetting: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkspaceSettingServiceGetWorkspaceSettingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetWorkspaceSetting returns the setting by name.
    ApiResponse<Apiv1WorkspaceSetting> response = apiInstance.WorkspaceSettingServiceGetWorkspaceSettingWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkspaceSettingServiceApi.WorkspaceSettingServiceGetWorkspaceSettingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | The resource name of the workspace setting. Format: settings/{setting} |  |

### Return type

[**Apiv1WorkspaceSetting**](Apiv1WorkspaceSetting.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workspacesettingservicesetworkspacesetting"></a>
# **WorkspaceSettingServiceSetWorkspaceSetting**
> Apiv1WorkspaceSetting WorkspaceSettingServiceSetWorkspaceSetting (string settingName, SettingIsTheSettingToUpdate setting)

SetWorkspaceSetting updates the setting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WorkspaceSettingServiceSetWorkspaceSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new WorkspaceSettingServiceApi(config);
            var settingName = "settingName_example";  // string | name is the name of the setting. Format: settings/{setting}
            var setting = new SettingIsTheSettingToUpdate(); // SettingIsTheSettingToUpdate | setting is the setting to update.

            try
            {
                // SetWorkspaceSetting updates the setting.
                Apiv1WorkspaceSetting result = apiInstance.WorkspaceSettingServiceSetWorkspaceSetting(settingName, setting);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceSettingServiceApi.WorkspaceSettingServiceSetWorkspaceSetting: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkspaceSettingServiceSetWorkspaceSettingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // SetWorkspaceSetting updates the setting.
    ApiResponse<Apiv1WorkspaceSetting> response = apiInstance.WorkspaceSettingServiceSetWorkspaceSettingWithHttpInfo(settingName, setting);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkspaceSettingServiceApi.WorkspaceSettingServiceSetWorkspaceSettingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **settingName** | **string** | name is the name of the setting. Format: settings/{setting} |  |
| **setting** | [**SettingIsTheSettingToUpdate**](SettingIsTheSettingToUpdate.md) | setting is the setting to update. |  |

### Return type

[**Apiv1WorkspaceSetting**](Apiv1WorkspaceSetting.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

