# Org.OpenAPITools.Api.UserServiceApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserServiceCreateUser**](UserServiceApi.md#userservicecreateuser) | **POST** /api/v1/users | CreateUser creates a new user. |
| [**UserServiceCreateUserAccessToken**](UserServiceApi.md#userservicecreateuseraccesstoken) | **POST** /api/v1/{name}/access_tokens | CreateUserAccessToken creates a new access token for a user. |
| [**UserServiceDeleteUser**](UserServiceApi.md#userservicedeleteuser) | **DELETE** /api/v1/{name} | DeleteUser deletes a user. |
| [**UserServiceDeleteUserAccessToken**](UserServiceApi.md#userservicedeleteuseraccesstoken) | **DELETE** /api/v1/{name}/access_tokens/{accessToken} | DeleteUserAccessToken deletes an access token for a user. |
| [**UserServiceGetUser**](UserServiceApi.md#userservicegetuser) | **GET** /api/v1/{name} | GetUser gets a user by name. |
| [**UserServiceGetUserAvatarBinary**](UserServiceApi.md#userservicegetuseravatarbinary) | **GET** /file/{name}/avatar | GetUserAvatarBinary gets the avatar of a user. |
| [**UserServiceGetUserSetting**](UserServiceApi.md#userservicegetusersetting) | **GET** /api/v1/{name}/setting | GetUserSetting gets the setting of a user. |
| [**UserServiceListUserAccessTokens**](UserServiceApi.md#userservicelistuseraccesstokens) | **GET** /api/v1/{name}/access_tokens | ListUserAccessTokens returns a list of access tokens for a user. |
| [**UserServiceListUsers**](UserServiceApi.md#userservicelistusers) | **GET** /api/v1/users | ListUsers returns a list of users. |
| [**UserServiceSearchUsers**](UserServiceApi.md#userservicesearchusers) | **GET** /api/v1/users:search | SearchUsers searches users by filter. |
| [**UserServiceUpdateUser**](UserServiceApi.md#userserviceupdateuser) | **PATCH** /api/v1/{user.name} | UpdateUser updates a user. |
| [**UserServiceUpdateUserSetting**](UserServiceApi.md#userserviceupdateusersetting) | **PATCH** /api/v1/{setting.name} | UpdateUserSetting updates the setting of a user. |

<a id="userservicecreateuser"></a>
# **UserServiceCreateUser**
> V1User UserServiceCreateUser (V1User user)

CreateUser creates a new user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserServiceCreateUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new UserServiceApi(config);
            var user = new V1User(); // V1User | 

            try
            {
                // CreateUser creates a new user.
                V1User result = apiInstance.UserServiceCreateUser(user);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserServiceApi.UserServiceCreateUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserServiceCreateUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CreateUser creates a new user.
    ApiResponse<V1User> response = apiInstance.UserServiceCreateUserWithHttpInfo(user);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserServiceApi.UserServiceCreateUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **user** | [**V1User**](V1User.md) |  |  |

### Return type

[**V1User**](V1User.md)

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

<a id="userservicecreateuseraccesstoken"></a>
# **UserServiceCreateUserAccessToken**
> V1UserAccessToken UserServiceCreateUserAccessToken (string name, UserServiceCreateUserAccessTokenBody body)

CreateUserAccessToken creates a new access token for a user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserServiceCreateUserAccessTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new UserServiceApi(config);
            var name = "name_example";  // string | The name of the user. Format: users/{id}
            var body = new UserServiceCreateUserAccessTokenBody(); // UserServiceCreateUserAccessTokenBody | 

            try
            {
                // CreateUserAccessToken creates a new access token for a user.
                V1UserAccessToken result = apiInstance.UserServiceCreateUserAccessToken(name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserServiceApi.UserServiceCreateUserAccessToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserServiceCreateUserAccessTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CreateUserAccessToken creates a new access token for a user.
    ApiResponse<V1UserAccessToken> response = apiInstance.UserServiceCreateUserAccessTokenWithHttpInfo(name, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserServiceApi.UserServiceCreateUserAccessTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | The name of the user. Format: users/{id} |  |
| **body** | [**UserServiceCreateUserAccessTokenBody**](UserServiceCreateUserAccessTokenBody.md) |  |  |

### Return type

[**V1UserAccessToken**](V1UserAccessToken.md)

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

<a id="userservicedeleteuser"></a>
# **UserServiceDeleteUser**
> Object UserServiceDeleteUser (string name)

DeleteUser deletes a user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserServiceDeleteUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new UserServiceApi(config);
            var name = "name_example";  // string | The name of the user. Format: users/{id}

            try
            {
                // DeleteUser deletes a user.
                Object result = apiInstance.UserServiceDeleteUser(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserServiceApi.UserServiceDeleteUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserServiceDeleteUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DeleteUser deletes a user.
    ApiResponse<Object> response = apiInstance.UserServiceDeleteUserWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserServiceApi.UserServiceDeleteUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | The name of the user. Format: users/{id} |  |

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

<a id="userservicedeleteuseraccesstoken"></a>
# **UserServiceDeleteUserAccessToken**
> Object UserServiceDeleteUserAccessToken (string name, string accessToken)

DeleteUserAccessToken deletes an access token for a user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserServiceDeleteUserAccessTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new UserServiceApi(config);
            var name = "name_example";  // string | The name of the user. Format: users/{id}
            var accessToken = "accessToken_example";  // string | access_token is the access token to delete.

            try
            {
                // DeleteUserAccessToken deletes an access token for a user.
                Object result = apiInstance.UserServiceDeleteUserAccessToken(name, accessToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserServiceApi.UserServiceDeleteUserAccessToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserServiceDeleteUserAccessTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DeleteUserAccessToken deletes an access token for a user.
    ApiResponse<Object> response = apiInstance.UserServiceDeleteUserAccessTokenWithHttpInfo(name, accessToken);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserServiceApi.UserServiceDeleteUserAccessTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | The name of the user. Format: users/{id} |  |
| **accessToken** | **string** | access_token is the access token to delete. |  |

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

<a id="userservicegetuser"></a>
# **UserServiceGetUser**
> V1User UserServiceGetUser (string name)

GetUser gets a user by name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserServiceGetUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new UserServiceApi(config);
            var name = "name_example";  // string | The name of the user. Format: users/{id}

            try
            {
                // GetUser gets a user by name.
                V1User result = apiInstance.UserServiceGetUser(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserServiceApi.UserServiceGetUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserServiceGetUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetUser gets a user by name.
    ApiResponse<V1User> response = apiInstance.UserServiceGetUserWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserServiceApi.UserServiceGetUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | The name of the user. Format: users/{id} |  |

### Return type

[**V1User**](V1User.md)

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

<a id="userservicegetuseravatarbinary"></a>
# **UserServiceGetUserAvatarBinary**
> ApiHttpBody UserServiceGetUserAvatarBinary (string name, string? httpBodyContentType = null, byte[]? httpBodyData = null)

GetUserAvatarBinary gets the avatar of a user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserServiceGetUserAvatarBinaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new UserServiceApi(config);
            var name = "name_example";  // string | The name of the user. Format: users/{id}
            var httpBodyContentType = "httpBodyContentType_example";  // string? | The HTTP Content-Type header value specifying the content type of the body. (optional) 
            var httpBodyData = System.Text.Encoding.ASCII.GetBytes("BYTE_ARRAY_DATA_HERE");  // byte[]? | The HTTP request/response body as raw binary. (optional) 

            try
            {
                // GetUserAvatarBinary gets the avatar of a user.
                ApiHttpBody result = apiInstance.UserServiceGetUserAvatarBinary(name, httpBodyContentType, httpBodyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserServiceApi.UserServiceGetUserAvatarBinary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserServiceGetUserAvatarBinaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetUserAvatarBinary gets the avatar of a user.
    ApiResponse<ApiHttpBody> response = apiInstance.UserServiceGetUserAvatarBinaryWithHttpInfo(name, httpBodyContentType, httpBodyData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserServiceApi.UserServiceGetUserAvatarBinaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | The name of the user. Format: users/{id} |  |
| **httpBodyContentType** | **string?** | The HTTP Content-Type header value specifying the content type of the body. | [optional]  |
| **httpBodyData** | **byte[]?** | The HTTP request/response body as raw binary. | [optional]  |

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

<a id="userservicegetusersetting"></a>
# **UserServiceGetUserSetting**
> Apiv1UserSetting UserServiceGetUserSetting (string name)

GetUserSetting gets the setting of a user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserServiceGetUserSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new UserServiceApi(config);
            var name = "name_example";  // string | The name of the user. Format: users/{id}

            try
            {
                // GetUserSetting gets the setting of a user.
                Apiv1UserSetting result = apiInstance.UserServiceGetUserSetting(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserServiceApi.UserServiceGetUserSetting: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserServiceGetUserSettingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetUserSetting gets the setting of a user.
    ApiResponse<Apiv1UserSetting> response = apiInstance.UserServiceGetUserSettingWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserServiceApi.UserServiceGetUserSettingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | The name of the user. Format: users/{id} |  |

### Return type

[**Apiv1UserSetting**](Apiv1UserSetting.md)

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

<a id="userservicelistuseraccesstokens"></a>
# **UserServiceListUserAccessTokens**
> V1ListUserAccessTokensResponse UserServiceListUserAccessTokens (string name)

ListUserAccessTokens returns a list of access tokens for a user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserServiceListUserAccessTokensExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new UserServiceApi(config);
            var name = "name_example";  // string | The name of the user. Format: users/{id}

            try
            {
                // ListUserAccessTokens returns a list of access tokens for a user.
                V1ListUserAccessTokensResponse result = apiInstance.UserServiceListUserAccessTokens(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserServiceApi.UserServiceListUserAccessTokens: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserServiceListUserAccessTokensWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListUserAccessTokens returns a list of access tokens for a user.
    ApiResponse<V1ListUserAccessTokensResponse> response = apiInstance.UserServiceListUserAccessTokensWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserServiceApi.UserServiceListUserAccessTokensWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | The name of the user. Format: users/{id} |  |

### Return type

[**V1ListUserAccessTokensResponse**](V1ListUserAccessTokensResponse.md)

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

<a id="userservicelistusers"></a>
# **UserServiceListUsers**
> V1ListUsersResponse UserServiceListUsers ()

ListUsers returns a list of users.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserServiceListUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new UserServiceApi(config);

            try
            {
                // ListUsers returns a list of users.
                V1ListUsersResponse result = apiInstance.UserServiceListUsers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserServiceApi.UserServiceListUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserServiceListUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListUsers returns a list of users.
    ApiResponse<V1ListUsersResponse> response = apiInstance.UserServiceListUsersWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserServiceApi.UserServiceListUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**V1ListUsersResponse**](V1ListUsersResponse.md)

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

<a id="userservicesearchusers"></a>
# **UserServiceSearchUsers**
> V1SearchUsersResponse UserServiceSearchUsers (string? filter = null)

SearchUsers searches users by filter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserServiceSearchUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new UserServiceApi(config);
            var filter = "filter_example";  // string? | Filter is used to filter users returned in the list. Format: \"username == 'frank'\" (optional) 

            try
            {
                // SearchUsers searches users by filter.
                V1SearchUsersResponse result = apiInstance.UserServiceSearchUsers(filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserServiceApi.UserServiceSearchUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserServiceSearchUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // SearchUsers searches users by filter.
    ApiResponse<V1SearchUsersResponse> response = apiInstance.UserServiceSearchUsersWithHttpInfo(filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserServiceApi.UserServiceSearchUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filter** | **string?** | Filter is used to filter users returned in the list. Format: \&quot;username &#x3D;&#x3D; &#39;frank&#39;\&quot; | [optional]  |

### Return type

[**V1SearchUsersResponse**](V1SearchUsersResponse.md)

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

<a id="userserviceupdateuser"></a>
# **UserServiceUpdateUser**
> V1User UserServiceUpdateUser (string userName, UserServiceUpdateUserRequest user)

UpdateUser updates a user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserServiceUpdateUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new UserServiceApi(config);
            var userName = "userName_example";  // string | The name of the user. Format: users/{id}
            var user = new UserServiceUpdateUserRequest(); // UserServiceUpdateUserRequest | 

            try
            {
                // UpdateUser updates a user.
                V1User result = apiInstance.UserServiceUpdateUser(userName, user);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserServiceApi.UserServiceUpdateUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserServiceUpdateUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpdateUser updates a user.
    ApiResponse<V1User> response = apiInstance.UserServiceUpdateUserWithHttpInfo(userName, user);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserServiceApi.UserServiceUpdateUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userName** | **string** | The name of the user. Format: users/{id} |  |
| **user** | [**UserServiceUpdateUserRequest**](UserServiceUpdateUserRequest.md) |  |  |

### Return type

[**V1User**](V1User.md)

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

<a id="userserviceupdateusersetting"></a>
# **UserServiceUpdateUserSetting**
> Apiv1UserSetting UserServiceUpdateUserSetting (string settingName, UserServiceUpdateUserSettingRequest setting)

UpdateUserSetting updates the setting of a user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserServiceUpdateUserSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new UserServiceApi(config);
            var settingName = "settingName_example";  // string | The name of the user. Format: users/{id}
            var setting = new UserServiceUpdateUserSettingRequest(); // UserServiceUpdateUserSettingRequest | 

            try
            {
                // UpdateUserSetting updates the setting of a user.
                Apiv1UserSetting result = apiInstance.UserServiceUpdateUserSetting(settingName, setting);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserServiceApi.UserServiceUpdateUserSetting: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserServiceUpdateUserSettingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpdateUserSetting updates the setting of a user.
    ApiResponse<Apiv1UserSetting> response = apiInstance.UserServiceUpdateUserSettingWithHttpInfo(settingName, setting);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserServiceApi.UserServiceUpdateUserSettingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **settingName** | **string** | The name of the user. Format: users/{id} |  |
| **setting** | [**UserServiceUpdateUserSettingRequest**](UserServiceUpdateUserSettingRequest.md) |  |  |

### Return type

[**Apiv1UserSetting**](Apiv1UserSetting.md)

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

