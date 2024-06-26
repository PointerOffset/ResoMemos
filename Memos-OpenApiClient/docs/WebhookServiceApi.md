# Org.OpenAPITools.Api.WebhookServiceApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**WebhookServiceCreateWebhook**](WebhookServiceApi.md#webhookservicecreatewebhook) | **POST** /api/v1/webhooks | CreateWebhook creates a new webhook. |
| [**WebhookServiceDeleteWebhook**](WebhookServiceApi.md#webhookservicedeletewebhook) | **DELETE** /api/v1/webhooks/{id} | DeleteWebhook deletes a webhook by id. |
| [**WebhookServiceGetWebhook**](WebhookServiceApi.md#webhookservicegetwebhook) | **GET** /api/v1/webhooks/{id} | GetWebhook returns a webhook by id. |
| [**WebhookServiceListWebhooks**](WebhookServiceApi.md#webhookservicelistwebhooks) | **GET** /api/v1/webhooks | ListWebhooks returns a list of webhooks. |
| [**WebhookServiceUpdateWebhook**](WebhookServiceApi.md#webhookserviceupdatewebhook) | **PATCH** /api/v1/webhooks/{webhook.id} | UpdateWebhook updates a webhook. |

<a id="webhookservicecreatewebhook"></a>
# **WebhookServiceCreateWebhook**
> V1Webhook WebhookServiceCreateWebhook (V1CreateWebhookRequest body)

CreateWebhook creates a new webhook.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WebhookServiceCreateWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new WebhookServiceApi(config);
            var body = new V1CreateWebhookRequest(); // V1CreateWebhookRequest | 

            try
            {
                // CreateWebhook creates a new webhook.
                V1Webhook result = apiInstance.WebhookServiceCreateWebhook(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookServiceApi.WebhookServiceCreateWebhook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebhookServiceCreateWebhookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CreateWebhook creates a new webhook.
    ApiResponse<V1Webhook> response = apiInstance.WebhookServiceCreateWebhookWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookServiceApi.WebhookServiceCreateWebhookWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**V1CreateWebhookRequest**](V1CreateWebhookRequest.md) |  |  |

### Return type

[**V1Webhook**](V1Webhook.md)

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

<a id="webhookservicedeletewebhook"></a>
# **WebhookServiceDeleteWebhook**
> Object WebhookServiceDeleteWebhook (int id)

DeleteWebhook deletes a webhook by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WebhookServiceDeleteWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new WebhookServiceApi(config);
            var id = 56;  // int | 

            try
            {
                // DeleteWebhook deletes a webhook by id.
                Object result = apiInstance.WebhookServiceDeleteWebhook(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookServiceApi.WebhookServiceDeleteWebhook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebhookServiceDeleteWebhookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DeleteWebhook deletes a webhook by id.
    ApiResponse<Object> response = apiInstance.WebhookServiceDeleteWebhookWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookServiceApi.WebhookServiceDeleteWebhookWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

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

<a id="webhookservicegetwebhook"></a>
# **WebhookServiceGetWebhook**
> V1Webhook WebhookServiceGetWebhook (int id)

GetWebhook returns a webhook by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WebhookServiceGetWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new WebhookServiceApi(config);
            var id = 56;  // int | 

            try
            {
                // GetWebhook returns a webhook by id.
                V1Webhook result = apiInstance.WebhookServiceGetWebhook(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookServiceApi.WebhookServiceGetWebhook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebhookServiceGetWebhookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetWebhook returns a webhook by id.
    ApiResponse<V1Webhook> response = apiInstance.WebhookServiceGetWebhookWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookServiceApi.WebhookServiceGetWebhookWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**V1Webhook**](V1Webhook.md)

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

<a id="webhookservicelistwebhooks"></a>
# **WebhookServiceListWebhooks**
> V1ListWebhooksResponse WebhookServiceListWebhooks (int? creatorId = null)

ListWebhooks returns a list of webhooks.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WebhookServiceListWebhooksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new WebhookServiceApi(config);
            var creatorId = 56;  // int? |  (optional) 

            try
            {
                // ListWebhooks returns a list of webhooks.
                V1ListWebhooksResponse result = apiInstance.WebhookServiceListWebhooks(creatorId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookServiceApi.WebhookServiceListWebhooks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebhookServiceListWebhooksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListWebhooks returns a list of webhooks.
    ApiResponse<V1ListWebhooksResponse> response = apiInstance.WebhookServiceListWebhooksWithHttpInfo(creatorId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookServiceApi.WebhookServiceListWebhooksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **creatorId** | **int?** |  | [optional]  |

### Return type

[**V1ListWebhooksResponse**](V1ListWebhooksResponse.md)

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

<a id="webhookserviceupdatewebhook"></a>
# **WebhookServiceUpdateWebhook**
> V1Webhook WebhookServiceUpdateWebhook (int webhookId, WebhookServiceUpdateWebhookRequest webhook)

UpdateWebhook updates a webhook.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WebhookServiceUpdateWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new WebhookServiceApi(config);
            var webhookId = 56;  // int | 
            var webhook = new WebhookServiceUpdateWebhookRequest(); // WebhookServiceUpdateWebhookRequest | 

            try
            {
                // UpdateWebhook updates a webhook.
                V1Webhook result = apiInstance.WebhookServiceUpdateWebhook(webhookId, webhook);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookServiceApi.WebhookServiceUpdateWebhook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebhookServiceUpdateWebhookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpdateWebhook updates a webhook.
    ApiResponse<V1Webhook> response = apiInstance.WebhookServiceUpdateWebhookWithHttpInfo(webhookId, webhook);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookServiceApi.WebhookServiceUpdateWebhookWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhookId** | **int** |  |  |
| **webhook** | [**WebhookServiceUpdateWebhookRequest**](WebhookServiceUpdateWebhookRequest.md) |  |  |

### Return type

[**V1Webhook**](V1Webhook.md)

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

