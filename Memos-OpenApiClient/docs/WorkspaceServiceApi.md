# Org.OpenAPITools.Api.WorkspaceServiceApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**WorkspaceServiceGetWorkspaceProfile**](WorkspaceServiceApi.md#workspaceservicegetworkspaceprofile) | **GET** /api/v1/workspace/profile | GetWorkspaceProfile returns the workspace profile. |

<a id="workspaceservicegetworkspaceprofile"></a>
# **WorkspaceServiceGetWorkspaceProfile**
> V1WorkspaceProfile WorkspaceServiceGetWorkspaceProfile ()

GetWorkspaceProfile returns the workspace profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WorkspaceServiceGetWorkspaceProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new WorkspaceServiceApi(config);

            try
            {
                // GetWorkspaceProfile returns the workspace profile.
                V1WorkspaceProfile result = apiInstance.WorkspaceServiceGetWorkspaceProfile();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceServiceApi.WorkspaceServiceGetWorkspaceProfile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkspaceServiceGetWorkspaceProfileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetWorkspaceProfile returns the workspace profile.
    ApiResponse<V1WorkspaceProfile> response = apiInstance.WorkspaceServiceGetWorkspaceProfileWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkspaceServiceApi.WorkspaceServiceGetWorkspaceProfileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**V1WorkspaceProfile**](V1WorkspaceProfile.md)

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

