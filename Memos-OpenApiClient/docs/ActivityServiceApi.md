# Org.OpenAPITools.Api.ActivityServiceApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ActivityServiceGetActivity**](ActivityServiceApi.md#activityservicegetactivity) | **GET** /api/v1/activities/{id} | GetActivity returns the activity with the given id. |

<a id="activityservicegetactivity"></a>
# **ActivityServiceGetActivity**
> V1Activity ActivityServiceGetActivity (int id)

GetActivity returns the activity with the given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivityServiceGetActivityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ActivityServiceApi(config);
            var id = 56;  // int | The system-generated unique identifier for the activity.

            try
            {
                // GetActivity returns the activity with the given id.
                V1Activity result = apiInstance.ActivityServiceGetActivity(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityServiceApi.ActivityServiceGetActivity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ActivityServiceGetActivityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetActivity returns the activity with the given id.
    ApiResponse<V1Activity> response = apiInstance.ActivityServiceGetActivityWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActivityServiceApi.ActivityServiceGetActivityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The system-generated unique identifier for the activity. |  |

### Return type

[**V1Activity**](V1Activity.md)

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

