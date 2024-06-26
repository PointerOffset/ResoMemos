# Org.OpenAPITools.Api.AuthServiceApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AuthServiceGetAuthStatus**](AuthServiceApi.md#authservicegetauthstatus) | **POST** /api/v1/auth/status | GetAuthStatus returns the current auth status of the user. |
| [**AuthServiceSignIn**](AuthServiceApi.md#authservicesignin) | **POST** /api/v1/auth/signin | SignIn signs in the user with the given username and password. |
| [**AuthServiceSignInWithSSO**](AuthServiceApi.md#authservicesigninwithsso) | **POST** /api/v1/auth/signin/sso | SignInWithSSO signs in the user with the given SSO code. |
| [**AuthServiceSignOut**](AuthServiceApi.md#authservicesignout) | **POST** /api/v1/auth/signout | SignOut signs out the user. |
| [**AuthServiceSignUp**](AuthServiceApi.md#authservicesignup) | **POST** /api/v1/auth/signup | SignUp signs up the user with the given username and password. |

<a id="authservicegetauthstatus"></a>
# **AuthServiceGetAuthStatus**
> V1User AuthServiceGetAuthStatus ()

GetAuthStatus returns the current auth status of the user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AuthServiceGetAuthStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthServiceApi(config);

            try
            {
                // GetAuthStatus returns the current auth status of the user.
                V1User result = apiInstance.AuthServiceGetAuthStatus();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthServiceApi.AuthServiceGetAuthStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthServiceGetAuthStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetAuthStatus returns the current auth status of the user.
    ApiResponse<V1User> response = apiInstance.AuthServiceGetAuthStatusWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthServiceApi.AuthServiceGetAuthStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

<a id="authservicesignin"></a>
# **AuthServiceSignIn**
> V1User AuthServiceSignIn (string? username = null, string? password = null, bool? neverExpire = null)

SignIn signs in the user with the given username and password.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AuthServiceSignInExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthServiceApi(config);
            var username = "username_example";  // string? | The username to sign in with. (optional) 
            var password = "password_example";  // string? | The password to sign in with. (optional) 
            var neverExpire = true;  // bool? | Whether the session should never expire. (optional) 

            try
            {
                // SignIn signs in the user with the given username and password.
                V1User result = apiInstance.AuthServiceSignIn(username, password, neverExpire);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthServiceApi.AuthServiceSignIn: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthServiceSignInWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // SignIn signs in the user with the given username and password.
    ApiResponse<V1User> response = apiInstance.AuthServiceSignInWithHttpInfo(username, password, neverExpire);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthServiceApi.AuthServiceSignInWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string?** | The username to sign in with. | [optional]  |
| **password** | **string?** | The password to sign in with. | [optional]  |
| **neverExpire** | **bool?** | Whether the session should never expire. | [optional]  |

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

<a id="authservicesigninwithsso"></a>
# **AuthServiceSignInWithSSO**
> V1User AuthServiceSignInWithSSO (int? idpId = null, string? code = null, string? redirectUri = null)

SignInWithSSO signs in the user with the given SSO code.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AuthServiceSignInWithSSOExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthServiceApi(config);
            var idpId = 56;  // int? | The ID of the SSO provider. (optional) 
            var code = "code_example";  // string? | The code to sign in with. (optional) 
            var redirectUri = "redirectUri_example";  // string? | The redirect URI. (optional) 

            try
            {
                // SignInWithSSO signs in the user with the given SSO code.
                V1User result = apiInstance.AuthServiceSignInWithSSO(idpId, code, redirectUri);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthServiceApi.AuthServiceSignInWithSSO: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthServiceSignInWithSSOWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // SignInWithSSO signs in the user with the given SSO code.
    ApiResponse<V1User> response = apiInstance.AuthServiceSignInWithSSOWithHttpInfo(idpId, code, redirectUri);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthServiceApi.AuthServiceSignInWithSSOWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **idpId** | **int?** | The ID of the SSO provider. | [optional]  |
| **code** | **string?** | The code to sign in with. | [optional]  |
| **redirectUri** | **string?** | The redirect URI. | [optional]  |

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

<a id="authservicesignout"></a>
# **AuthServiceSignOut**
> Object AuthServiceSignOut ()

SignOut signs out the user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AuthServiceSignOutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthServiceApi(config);

            try
            {
                // SignOut signs out the user.
                Object result = apiInstance.AuthServiceSignOut();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthServiceApi.AuthServiceSignOut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthServiceSignOutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // SignOut signs out the user.
    ApiResponse<Object> response = apiInstance.AuthServiceSignOutWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthServiceApi.AuthServiceSignOutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

<a id="authservicesignup"></a>
# **AuthServiceSignUp**
> V1User AuthServiceSignUp (string? username = null, string? password = null)

SignUp signs up the user with the given username and password.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AuthServiceSignUpExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthServiceApi(config);
            var username = "username_example";  // string? | The username to sign up with. (optional) 
            var password = "password_example";  // string? | The password to sign up with. (optional) 

            try
            {
                // SignUp signs up the user with the given username and password.
                V1User result = apiInstance.AuthServiceSignUp(username, password);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthServiceApi.AuthServiceSignUp: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthServiceSignUpWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // SignUp signs up the user with the given username and password.
    ApiResponse<V1User> response = apiInstance.AuthServiceSignUpWithHttpInfo(username, password);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthServiceApi.AuthServiceSignUpWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string?** | The username to sign up with. | [optional]  |
| **password** | **string?** | The password to sign up with. | [optional]  |

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

