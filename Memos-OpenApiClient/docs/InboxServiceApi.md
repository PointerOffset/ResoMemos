# Org.OpenAPITools.Api.InboxServiceApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InboxServiceDeleteInbox**](InboxServiceApi.md#inboxservicedeleteinbox) | **DELETE** /api/v1/{name_2} | DeleteInbox deletes an inbox. |
| [**InboxServiceListInboxes**](InboxServiceApi.md#inboxservicelistinboxes) | **GET** /api/v1/inboxes | ListInboxes lists inboxes for a user. |
| [**InboxServiceUpdateInbox**](InboxServiceApi.md#inboxserviceupdateinbox) | **PATCH** /api/v1/{inbox.name} | UpdateInbox updates an inbox. |

<a id="inboxservicedeleteinbox"></a>
# **InboxServiceDeleteInbox**
> Object InboxServiceDeleteInbox (string name2)

DeleteInbox deletes an inbox.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InboxServiceDeleteInboxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new InboxServiceApi(config);
            var name2 = "name2_example";  // string | The name of the inbox to delete. Format: inboxes/{id}

            try
            {
                // DeleteInbox deletes an inbox.
                Object result = apiInstance.InboxServiceDeleteInbox(name2);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxServiceApi.InboxServiceDeleteInbox: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InboxServiceDeleteInboxWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DeleteInbox deletes an inbox.
    ApiResponse<Object> response = apiInstance.InboxServiceDeleteInboxWithHttpInfo(name2);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InboxServiceApi.InboxServiceDeleteInboxWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name2** | **string** | The name of the inbox to delete. Format: inboxes/{id} |  |

### Return type

**Object**

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

<a id="inboxservicelistinboxes"></a>
# **InboxServiceListInboxes**
> V1ListInboxesResponse InboxServiceListInboxes (string? user = null)

ListInboxes lists inboxes for a user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InboxServiceListInboxesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new InboxServiceApi(config);
            var user = "user_example";  // string? | Format: users/{id} (optional) 

            try
            {
                // ListInboxes lists inboxes for a user.
                V1ListInboxesResponse result = apiInstance.InboxServiceListInboxes(user);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxServiceApi.InboxServiceListInboxes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InboxServiceListInboxesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListInboxes lists inboxes for a user.
    ApiResponse<V1ListInboxesResponse> response = apiInstance.InboxServiceListInboxesWithHttpInfo(user);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InboxServiceApi.InboxServiceListInboxesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **user** | **string?** | Format: users/{id} | [optional]  |

### Return type

[**V1ListInboxesResponse**](V1ListInboxesResponse.md)

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

<a id="inboxserviceupdateinbox"></a>
# **InboxServiceUpdateInbox**
> V1Inbox InboxServiceUpdateInbox (string inboxName, InboxServiceUpdateInboxRequest inbox)

UpdateInbox updates an inbox.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InboxServiceUpdateInboxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new InboxServiceApi(config);
            var inboxName = "inboxName_example";  // string | The name of the inbox. Format: inboxes/{id}
            var inbox = new InboxServiceUpdateInboxRequest(); // InboxServiceUpdateInboxRequest | 

            try
            {
                // UpdateInbox updates an inbox.
                V1Inbox result = apiInstance.InboxServiceUpdateInbox(inboxName, inbox);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxServiceApi.InboxServiceUpdateInbox: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InboxServiceUpdateInboxWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpdateInbox updates an inbox.
    ApiResponse<V1Inbox> response = apiInstance.InboxServiceUpdateInboxWithHttpInfo(inboxName, inbox);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InboxServiceApi.InboxServiceUpdateInboxWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inboxName** | **string** | The name of the inbox. Format: inboxes/{id} |  |
| **inbox** | [**InboxServiceUpdateInboxRequest**](InboxServiceUpdateInboxRequest.md) |  |  |

### Return type

[**V1Inbox**](V1Inbox.md)

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

