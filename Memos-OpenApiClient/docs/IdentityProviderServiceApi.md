# Org.OpenAPITools.Api.IdentityProviderServiceApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**IdentityProviderServiceCreateIdentityProvider**](IdentityProviderServiceApi.md#identityproviderservicecreateidentityprovider) | **POST** /api/v1/identityProviders | CreateIdentityProvider creates an identity provider. |
| [**IdentityProviderServiceDeleteIdentityProvider**](IdentityProviderServiceApi.md#identityproviderservicedeleteidentityprovider) | **DELETE** /api/v1/{name_1} | DeleteIdentityProvider deletes an identity provider. |
| [**IdentityProviderServiceGetIdentityProvider**](IdentityProviderServiceApi.md#identityproviderservicegetidentityprovider) | **GET** /api/v1/{name_1} | GetIdentityProvider gets an identity provider. |
| [**IdentityProviderServiceListIdentityProviders**](IdentityProviderServiceApi.md#identityproviderservicelistidentityproviders) | **GET** /api/v1/identityProviders | ListIdentityProviders lists identity providers. |
| [**IdentityProviderServiceUpdateIdentityProvider**](IdentityProviderServiceApi.md#identityproviderserviceupdateidentityprovider) | **PATCH** /api/v1/{identityProvider.name} | UpdateIdentityProvider updates an identity provider. |

<a id="identityproviderservicecreateidentityprovider"></a>
# **IdentityProviderServiceCreateIdentityProvider**
> Apiv1IdentityProvider IdentityProviderServiceCreateIdentityProvider (Apiv1IdentityProvider identityProvider)

CreateIdentityProvider creates an identity provider.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IdentityProviderServiceCreateIdentityProviderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new IdentityProviderServiceApi(config);
            var identityProvider = new Apiv1IdentityProvider(); // Apiv1IdentityProvider | The identityProvider to create.

            try
            {
                // CreateIdentityProvider creates an identity provider.
                Apiv1IdentityProvider result = apiInstance.IdentityProviderServiceCreateIdentityProvider(identityProvider);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProviderServiceApi.IdentityProviderServiceCreateIdentityProvider: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IdentityProviderServiceCreateIdentityProviderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CreateIdentityProvider creates an identity provider.
    ApiResponse<Apiv1IdentityProvider> response = apiInstance.IdentityProviderServiceCreateIdentityProviderWithHttpInfo(identityProvider);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IdentityProviderServiceApi.IdentityProviderServiceCreateIdentityProviderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identityProvider** | [**Apiv1IdentityProvider**](Apiv1IdentityProvider.md) | The identityProvider to create. |  |

### Return type

[**Apiv1IdentityProvider**](Apiv1IdentityProvider.md)

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

<a id="identityproviderservicedeleteidentityprovider"></a>
# **IdentityProviderServiceDeleteIdentityProvider**
> Object IdentityProviderServiceDeleteIdentityProvider (string name1)

DeleteIdentityProvider deletes an identity provider.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IdentityProviderServiceDeleteIdentityProviderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new IdentityProviderServiceApi(config);
            var name1 = "name1_example";  // string | The name of the identityProvider to delete. Format: identityProviders/{id}

            try
            {
                // DeleteIdentityProvider deletes an identity provider.
                Object result = apiInstance.IdentityProviderServiceDeleteIdentityProvider(name1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProviderServiceApi.IdentityProviderServiceDeleteIdentityProvider: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IdentityProviderServiceDeleteIdentityProviderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DeleteIdentityProvider deletes an identity provider.
    ApiResponse<Object> response = apiInstance.IdentityProviderServiceDeleteIdentityProviderWithHttpInfo(name1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IdentityProviderServiceApi.IdentityProviderServiceDeleteIdentityProviderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name1** | **string** | The name of the identityProvider to delete. Format: identityProviders/{id} |  |

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

<a id="identityproviderservicegetidentityprovider"></a>
# **IdentityProviderServiceGetIdentityProvider**
> Apiv1IdentityProvider IdentityProviderServiceGetIdentityProvider (string name1)

GetIdentityProvider gets an identity provider.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IdentityProviderServiceGetIdentityProviderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new IdentityProviderServiceApi(config);
            var name1 = "name1_example";  // string | The name of the identityProvider to get. Format: identityProviders/{id}

            try
            {
                // GetIdentityProvider gets an identity provider.
                Apiv1IdentityProvider result = apiInstance.IdentityProviderServiceGetIdentityProvider(name1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProviderServiceApi.IdentityProviderServiceGetIdentityProvider: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IdentityProviderServiceGetIdentityProviderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetIdentityProvider gets an identity provider.
    ApiResponse<Apiv1IdentityProvider> response = apiInstance.IdentityProviderServiceGetIdentityProviderWithHttpInfo(name1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IdentityProviderServiceApi.IdentityProviderServiceGetIdentityProviderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name1** | **string** | The name of the identityProvider to get. Format: identityProviders/{id} |  |

### Return type

[**Apiv1IdentityProvider**](Apiv1IdentityProvider.md)

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

<a id="identityproviderservicelistidentityproviders"></a>
# **IdentityProviderServiceListIdentityProviders**
> V1ListIdentityProvidersResponse IdentityProviderServiceListIdentityProviders ()

ListIdentityProviders lists identity providers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IdentityProviderServiceListIdentityProvidersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new IdentityProviderServiceApi(config);

            try
            {
                // ListIdentityProviders lists identity providers.
                V1ListIdentityProvidersResponse result = apiInstance.IdentityProviderServiceListIdentityProviders();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProviderServiceApi.IdentityProviderServiceListIdentityProviders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IdentityProviderServiceListIdentityProvidersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListIdentityProviders lists identity providers.
    ApiResponse<V1ListIdentityProvidersResponse> response = apiInstance.IdentityProviderServiceListIdentityProvidersWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IdentityProviderServiceApi.IdentityProviderServiceListIdentityProvidersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**V1ListIdentityProvidersResponse**](V1ListIdentityProvidersResponse.md)

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

<a id="identityproviderserviceupdateidentityprovider"></a>
# **IdentityProviderServiceUpdateIdentityProvider**
> Apiv1IdentityProvider IdentityProviderServiceUpdateIdentityProvider (string identityProviderName, TheIdentityProviderToUpdate identityProvider)

UpdateIdentityProvider updates an identity provider.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IdentityProviderServiceUpdateIdentityProviderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new IdentityProviderServiceApi(config);
            var identityProviderName = "identityProviderName_example";  // string | The name of the identityProvider. Format: identityProviders/{id}
            var identityProvider = new TheIdentityProviderToUpdate(); // TheIdentityProviderToUpdate | The identityProvider to update.

            try
            {
                // UpdateIdentityProvider updates an identity provider.
                Apiv1IdentityProvider result = apiInstance.IdentityProviderServiceUpdateIdentityProvider(identityProviderName, identityProvider);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProviderServiceApi.IdentityProviderServiceUpdateIdentityProvider: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IdentityProviderServiceUpdateIdentityProviderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpdateIdentityProvider updates an identity provider.
    ApiResponse<Apiv1IdentityProvider> response = apiInstance.IdentityProviderServiceUpdateIdentityProviderWithHttpInfo(identityProviderName, identityProvider);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IdentityProviderServiceApi.IdentityProviderServiceUpdateIdentityProviderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identityProviderName** | **string** | The name of the identityProvider. Format: identityProviders/{id} |  |
| **identityProvider** | [**TheIdentityProviderToUpdate**](TheIdentityProviderToUpdate.md) | The identityProvider to update. |  |

### Return type

[**Apiv1IdentityProvider**](Apiv1IdentityProvider.md)

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

