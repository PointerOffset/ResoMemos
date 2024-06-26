# Org.OpenAPITools.Api.MarkdownServiceApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**MarkdownServiceGetLinkMetadata**](MarkdownServiceApi.md#markdownservicegetlinkmetadata) | **GET** /api/v1/markdown/link:metadata | GetLinkMetadata returns metadata for a given link. |
| [**MarkdownServiceParseMarkdown**](MarkdownServiceApi.md#markdownserviceparsemarkdown) | **POST** /api/v1/markdown/parse | Parses the given markdown content and returns a list of nodes. |
| [**MarkdownServiceRestoreMarkdown**](MarkdownServiceApi.md#markdownservicerestoremarkdown) | **POST** /api/v1/markdown:restore | Restores the given nodes to markdown content. |

<a id="markdownservicegetlinkmetadata"></a>
# **MarkdownServiceGetLinkMetadata**
> V1LinkMetadata MarkdownServiceGetLinkMetadata (string? link = null)

GetLinkMetadata returns metadata for a given link.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MarkdownServiceGetLinkMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MarkdownServiceApi(config);
            var link = "link_example";  // string? |  (optional) 

            try
            {
                // GetLinkMetadata returns metadata for a given link.
                V1LinkMetadata result = apiInstance.MarkdownServiceGetLinkMetadata(link);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarkdownServiceApi.MarkdownServiceGetLinkMetadata: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MarkdownServiceGetLinkMetadataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetLinkMetadata returns metadata for a given link.
    ApiResponse<V1LinkMetadata> response = apiInstance.MarkdownServiceGetLinkMetadataWithHttpInfo(link);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarkdownServiceApi.MarkdownServiceGetLinkMetadataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **link** | **string?** |  | [optional]  |

### Return type

[**V1LinkMetadata**](V1LinkMetadata.md)

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

<a id="markdownserviceparsemarkdown"></a>
# **MarkdownServiceParseMarkdown**
> V1ParseMarkdownResponse MarkdownServiceParseMarkdown (V1ParseMarkdownRequest body)

Parses the given markdown content and returns a list of nodes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MarkdownServiceParseMarkdownExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MarkdownServiceApi(config);
            var body = new V1ParseMarkdownRequest(); // V1ParseMarkdownRequest | 

            try
            {
                // Parses the given markdown content and returns a list of nodes.
                V1ParseMarkdownResponse result = apiInstance.MarkdownServiceParseMarkdown(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarkdownServiceApi.MarkdownServiceParseMarkdown: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MarkdownServiceParseMarkdownWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Parses the given markdown content and returns a list of nodes.
    ApiResponse<V1ParseMarkdownResponse> response = apiInstance.MarkdownServiceParseMarkdownWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarkdownServiceApi.MarkdownServiceParseMarkdownWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**V1ParseMarkdownRequest**](V1ParseMarkdownRequest.md) |  |  |

### Return type

[**V1ParseMarkdownResponse**](V1ParseMarkdownResponse.md)

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

<a id="markdownservicerestoremarkdown"></a>
# **MarkdownServiceRestoreMarkdown**
> V1RestoreMarkdownResponse MarkdownServiceRestoreMarkdown (V1RestoreMarkdownRequest body)

Restores the given nodes to markdown content.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MarkdownServiceRestoreMarkdownExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MarkdownServiceApi(config);
            var body = new V1RestoreMarkdownRequest(); // V1RestoreMarkdownRequest | 

            try
            {
                // Restores the given nodes to markdown content.
                V1RestoreMarkdownResponse result = apiInstance.MarkdownServiceRestoreMarkdown(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarkdownServiceApi.MarkdownServiceRestoreMarkdown: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MarkdownServiceRestoreMarkdownWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Restores the given nodes to markdown content.
    ApiResponse<V1RestoreMarkdownResponse> response = apiInstance.MarkdownServiceRestoreMarkdownWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarkdownServiceApi.MarkdownServiceRestoreMarkdownWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**V1RestoreMarkdownRequest**](V1RestoreMarkdownRequest.md) |  |  |

### Return type

[**V1RestoreMarkdownResponse**](V1RestoreMarkdownResponse.md)

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

