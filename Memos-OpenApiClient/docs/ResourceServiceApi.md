# Org.OpenAPITools.Api.ResourceServiceApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ResourceServiceCreateResource**](ResourceServiceApi.md#resourceservicecreateresource) | **POST** /api/v1/resources | CreateResource creates a new resource. |
| [**ResourceServiceDeleteResource**](ResourceServiceApi.md#resourceservicedeleteresource) | **DELETE** /api/v1/{name_3} | DeleteResource deletes a resource by name. |
| [**ResourceServiceGetResource**](ResourceServiceApi.md#resourceservicegetresource) | **GET** /api/v1/{name_2} | GetResource returns a resource by name. |
| [**ResourceServiceGetResourceBinary**](ResourceServiceApi.md#resourceservicegetresourcebinary) | **GET** /file/{name}/{filename} | GetResourceBinary returns a resource binary by name. |
| [**ResourceServiceListResources**](ResourceServiceApi.md#resourceservicelistresources) | **GET** /api/v1/resources | ListResources lists all resources. |
| [**ResourceServiceSearchResources**](ResourceServiceApi.md#resourceservicesearchresources) | **GET** /api/v1/resources:search | SearchResources searches memos. |
| [**ResourceServiceUpdateResource**](ResourceServiceApi.md#resourceserviceupdateresource) | **PATCH** /api/v1/{resource.name} | UpdateResource updates a resource. |

<a id="resourceservicecreateresource"></a>
# **ResourceServiceCreateResource**
> V1Resource ResourceServiceCreateResource (V1Resource resource)

CreateResource creates a new resource.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ResourceServiceCreateResourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ResourceServiceApi(config);
            var resource = new V1Resource(); // V1Resource | 

            try
            {
                // CreateResource creates a new resource.
                V1Resource result = apiInstance.ResourceServiceCreateResource(resource);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResourceServiceApi.ResourceServiceCreateResource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResourceServiceCreateResourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CreateResource creates a new resource.
    ApiResponse<V1Resource> response = apiInstance.ResourceServiceCreateResourceWithHttpInfo(resource);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResourceServiceApi.ResourceServiceCreateResourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **resource** | [**V1Resource**](V1Resource.md) |  |  |

### Return type

[**V1Resource**](V1Resource.md)

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

<a id="resourceservicedeleteresource"></a>
# **ResourceServiceDeleteResource**
> Object ResourceServiceDeleteResource (string name3)

DeleteResource deletes a resource by name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ResourceServiceDeleteResourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ResourceServiceApi(config);
            var name3 = "name3_example";  // string | The name of the resource. Format: resources/{id} id is the system generated unique identifier.

            try
            {
                // DeleteResource deletes a resource by name.
                Object result = apiInstance.ResourceServiceDeleteResource(name3);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResourceServiceApi.ResourceServiceDeleteResource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResourceServiceDeleteResourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DeleteResource deletes a resource by name.
    ApiResponse<Object> response = apiInstance.ResourceServiceDeleteResourceWithHttpInfo(name3);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResourceServiceApi.ResourceServiceDeleteResourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name3** | **string** | The name of the resource. Format: resources/{id} id is the system generated unique identifier. |  |

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

<a id="resourceservicegetresource"></a>
# **ResourceServiceGetResource**
> V1Resource ResourceServiceGetResource (string name2)

GetResource returns a resource by name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ResourceServiceGetResourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ResourceServiceApi(config);
            var name2 = "name2_example";  // string | The name of the resource. Format: resources/{id} id is the system generated unique identifier.

            try
            {
                // GetResource returns a resource by name.
                V1Resource result = apiInstance.ResourceServiceGetResource(name2);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResourceServiceApi.ResourceServiceGetResource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResourceServiceGetResourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetResource returns a resource by name.
    ApiResponse<V1Resource> response = apiInstance.ResourceServiceGetResourceWithHttpInfo(name2);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResourceServiceApi.ResourceServiceGetResourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name2** | **string** | The name of the resource. Format: resources/{id} id is the system generated unique identifier. |  |

### Return type

[**V1Resource**](V1Resource.md)

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

<a id="resourceservicegetresourcebinary"></a>
# **ResourceServiceGetResourceBinary**
> ApiHttpBody ResourceServiceGetResourceBinary (string name, string filename)

GetResourceBinary returns a resource binary by name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ResourceServiceGetResourceBinaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ResourceServiceApi(config);
            var name = "name_example";  // string | The name of the resource. Format: resources/{id} id is the system generated unique identifier.
            var filename = "filename_example";  // string | The filename of the resource. Mainly used for downloading.

            try
            {
                // GetResourceBinary returns a resource binary by name.
                ApiHttpBody result = apiInstance.ResourceServiceGetResourceBinary(name, filename);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResourceServiceApi.ResourceServiceGetResourceBinary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResourceServiceGetResourceBinaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetResourceBinary returns a resource binary by name.
    ApiResponse<ApiHttpBody> response = apiInstance.ResourceServiceGetResourceBinaryWithHttpInfo(name, filename);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResourceServiceApi.ResourceServiceGetResourceBinaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | The name of the resource. Format: resources/{id} id is the system generated unique identifier. |  |
| **filename** | **string** | The filename of the resource. Mainly used for downloading. |  |

### Return type

[**ApiHttpBody**](ApiHttpBody.md)

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

<a id="resourceservicelistresources"></a>
# **ResourceServiceListResources**
> V1ListResourcesResponse ResourceServiceListResources ()

ListResources lists all resources.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ResourceServiceListResourcesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ResourceServiceApi(config);

            try
            {
                // ListResources lists all resources.
                V1ListResourcesResponse result = apiInstance.ResourceServiceListResources();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResourceServiceApi.ResourceServiceListResources: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResourceServiceListResourcesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListResources lists all resources.
    ApiResponse<V1ListResourcesResponse> response = apiInstance.ResourceServiceListResourcesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResourceServiceApi.ResourceServiceListResourcesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**V1ListResourcesResponse**](V1ListResourcesResponse.md)

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

<a id="resourceservicesearchresources"></a>
# **ResourceServiceSearchResources**
> V1SearchResourcesResponse ResourceServiceSearchResources (string? filter = null)

SearchResources searches memos.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ResourceServiceSearchResourcesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ResourceServiceApi(config);
            var filter = "filter_example";  // string? |  (optional) 

            try
            {
                // SearchResources searches memos.
                V1SearchResourcesResponse result = apiInstance.ResourceServiceSearchResources(filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResourceServiceApi.ResourceServiceSearchResources: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResourceServiceSearchResourcesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // SearchResources searches memos.
    ApiResponse<V1SearchResourcesResponse> response = apiInstance.ResourceServiceSearchResourcesWithHttpInfo(filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResourceServiceApi.ResourceServiceSearchResourcesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filter** | **string?** |  | [optional]  |

### Return type

[**V1SearchResourcesResponse**](V1SearchResourcesResponse.md)

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

<a id="resourceserviceupdateresource"></a>
# **ResourceServiceUpdateResource**
> V1Resource ResourceServiceUpdateResource (string resourceName, ResourceServiceUpdateResourceRequest resource)

UpdateResource updates a resource.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ResourceServiceUpdateResourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ResourceServiceApi(config);
            var resourceName = "resourceName_example";  // string | The name of the resource. Format: resources/{id} id is the system generated unique identifier.
            var resource = new ResourceServiceUpdateResourceRequest(); // ResourceServiceUpdateResourceRequest | 

            try
            {
                // UpdateResource updates a resource.
                V1Resource result = apiInstance.ResourceServiceUpdateResource(resourceName, resource);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResourceServiceApi.ResourceServiceUpdateResource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResourceServiceUpdateResourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpdateResource updates a resource.
    ApiResponse<V1Resource> response = apiInstance.ResourceServiceUpdateResourceWithHttpInfo(resourceName, resource);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResourceServiceApi.ResourceServiceUpdateResourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **resourceName** | **string** | The name of the resource. Format: resources/{id} id is the system generated unique identifier. |  |
| **resource** | [**ResourceServiceUpdateResourceRequest**](ResourceServiceUpdateResourceRequest.md) |  |  |

### Return type

[**V1Resource**](V1Resource.md)

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

