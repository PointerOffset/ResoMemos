# Org.OpenAPITools.Api.MemoServiceApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**MemoServiceCreateMemo**](MemoServiceApi.md#memoservicecreatememo) | **POST** /api/v1/memos | CreateMemo creates a memo. |
| [**MemoServiceCreateMemoComment**](MemoServiceApi.md#memoservicecreatememocomment) | **POST** /api/v1/{name}/comments | CreateMemoComment creates a comment for a memo. |
| [**MemoServiceDeleteMemo**](MemoServiceApi.md#memoservicedeletememo) | **DELETE** /api/v1/{name_4} | DeleteMemo deletes a memo. |
| [**MemoServiceDeleteMemoReaction**](MemoServiceApi.md#memoservicedeletememoreaction) | **DELETE** /api/v1/reactions/{reactionId} | DeleteMemoReaction deletes a reaction for a memo. |
| [**MemoServiceDeleteMemoTag**](MemoServiceApi.md#memoservicedeletememotag) | **DELETE** /api/v1/{parent}/tags/{tag} | DeleteMemoTag deletes a tag for a memo. |
| [**MemoServiceExportMemos**](MemoServiceApi.md#memoserviceexportmemos) | **POST** /api/v1/memos:export | ExportMemos exports memos. |
| [**MemoServiceGetMemo**](MemoServiceApi.md#memoservicegetmemo) | **GET** /api/v1/{name_3} | GetMemo gets a memo. |
| [**MemoServiceGetUserMemosStats**](MemoServiceApi.md#memoservicegetusermemosstats) | **GET** /api/v1/memos/stats | GetUserMemosStats gets stats of memos for a user. |
| [**MemoServiceListMemoComments**](MemoServiceApi.md#memoservicelistmemocomments) | **GET** /api/v1/{name}/comments | ListMemoComments lists comments for a memo. |
| [**MemoServiceListMemoProperties**](MemoServiceApi.md#memoservicelistmemoproperties) | **GET** /api/v1/{name}/properties | ListMemoProperties lists memo properties. |
| [**MemoServiceListMemoReactions**](MemoServiceApi.md#memoservicelistmemoreactions) | **GET** /api/v1/{name}/reactions | ListMemoReactions lists reactions for a memo. |
| [**MemoServiceListMemoRelations**](MemoServiceApi.md#memoservicelistmemorelations) | **GET** /api/v1/{name}/relations | ListMemoRelations lists relations for a memo. |
| [**MemoServiceListMemoResources**](MemoServiceApi.md#memoservicelistmemoresources) | **GET** /api/v1/{name}/resources | ListMemoResources lists resources for a memo. |
| [**MemoServiceListMemoTags**](MemoServiceApi.md#memoservicelistmemotags) | **GET** /api/v1/{parent}/tags | ListMemoTags lists tags for a memo. |
| [**MemoServiceListMemos**](MemoServiceApi.md#memoservicelistmemos) | **GET** /api/v1/memos | ListMemos lists memos with pagination and filter. |
| [**MemoServiceRebuildMemoProperty**](MemoServiceApi.md#memoservicerebuildmemoproperty) | **POST** /api/v1/{name}/properties:rebuild | RebuildMemoProperty rebuilds a memo property. |
| [**MemoServiceRenameMemoTag**](MemoServiceApi.md#memoservicerenamememotag) | **PATCH** /api/v1/{parent}/tags:rename | RenameMemoTag renames a tag for a memo. |
| [**MemoServiceSearchMemos**](MemoServiceApi.md#memoservicesearchmemos) | **GET** /api/v1/memos:search | SearchMemos searches memos. |
| [**MemoServiceSetMemoRelations**](MemoServiceApi.md#memoservicesetmemorelations) | **PATCH** /api/v1/{name}/relations | SetMemoRelations sets relations for a memo. |
| [**MemoServiceSetMemoResources**](MemoServiceApi.md#memoservicesetmemoresources) | **PATCH** /api/v1/{name}/resources | SetMemoResources sets resources for a memo. |
| [**MemoServiceUpdateMemo**](MemoServiceApi.md#memoserviceupdatememo) | **PATCH** /api/v1/{memo.name} | UpdateMemo updates a memo. |
| [**MemoServiceUpsertMemoReaction**](MemoServiceApi.md#memoserviceupsertmemoreaction) | **POST** /api/v1/{name}/reactions | UpsertMemoReaction upserts a reaction for a memo. |

<a id="memoservicecreatememo"></a>
# **MemoServiceCreateMemo**
> V1Memo MemoServiceCreateMemo (V1CreateMemoRequest body)

CreateMemo creates a memo.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MemoServiceCreateMemoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MemoServiceApi(config);
            var body = new V1CreateMemoRequest(); // V1CreateMemoRequest | 

            try
            {
                // CreateMemo creates a memo.
                V1Memo result = apiInstance.MemoServiceCreateMemo(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemoServiceApi.MemoServiceCreateMemo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MemoServiceCreateMemoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CreateMemo creates a memo.
    ApiResponse<V1Memo> response = apiInstance.MemoServiceCreateMemoWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemoServiceApi.MemoServiceCreateMemoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**V1CreateMemoRequest**](V1CreateMemoRequest.md) |  |  |

### Return type

[**V1Memo**](V1Memo.md)

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

<a id="memoservicecreatememocomment"></a>
# **MemoServiceCreateMemoComment**
> V1Memo MemoServiceCreateMemoComment (string name, V1CreateMemoRequest comment)

CreateMemoComment creates a comment for a memo.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MemoServiceCreateMemoCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MemoServiceApi(config);
            var name = "name_example";  // string | The name of the memo. Format: memos/{id}
            var comment = new V1CreateMemoRequest(); // V1CreateMemoRequest | 

            try
            {
                // CreateMemoComment creates a comment for a memo.
                V1Memo result = apiInstance.MemoServiceCreateMemoComment(name, comment);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemoServiceApi.MemoServiceCreateMemoComment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MemoServiceCreateMemoCommentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CreateMemoComment creates a comment for a memo.
    ApiResponse<V1Memo> response = apiInstance.MemoServiceCreateMemoCommentWithHttpInfo(name, comment);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemoServiceApi.MemoServiceCreateMemoCommentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | The name of the memo. Format: memos/{id} |  |
| **comment** | [**V1CreateMemoRequest**](V1CreateMemoRequest.md) |  |  |

### Return type

[**V1Memo**](V1Memo.md)

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

<a id="memoservicedeletememo"></a>
# **MemoServiceDeleteMemo**
> Object MemoServiceDeleteMemo (string name4)

DeleteMemo deletes a memo.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MemoServiceDeleteMemoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MemoServiceApi(config);
            var name4 = "name4_example";  // string | The name of the memo. Format: memos/{id}

            try
            {
                // DeleteMemo deletes a memo.
                Object result = apiInstance.MemoServiceDeleteMemo(name4);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemoServiceApi.MemoServiceDeleteMemo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MemoServiceDeleteMemoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DeleteMemo deletes a memo.
    ApiResponse<Object> response = apiInstance.MemoServiceDeleteMemoWithHttpInfo(name4);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemoServiceApi.MemoServiceDeleteMemoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name4** | **string** | The name of the memo. Format: memos/{id} |  |

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

<a id="memoservicedeletememoreaction"></a>
# **MemoServiceDeleteMemoReaction**
> Object MemoServiceDeleteMemoReaction (int reactionId)

DeleteMemoReaction deletes a reaction for a memo.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MemoServiceDeleteMemoReactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MemoServiceApi(config);
            var reactionId = 56;  // int | 

            try
            {
                // DeleteMemoReaction deletes a reaction for a memo.
                Object result = apiInstance.MemoServiceDeleteMemoReaction(reactionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemoServiceApi.MemoServiceDeleteMemoReaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MemoServiceDeleteMemoReactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DeleteMemoReaction deletes a reaction for a memo.
    ApiResponse<Object> response = apiInstance.MemoServiceDeleteMemoReactionWithHttpInfo(reactionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemoServiceApi.MemoServiceDeleteMemoReactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **reactionId** | **int** |  |  |

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

<a id="memoservicedeletememotag"></a>
# **MemoServiceDeleteMemoTag**
> Object MemoServiceDeleteMemoTag (string parent, string tag, bool? deleteRelatedMemos = null)

DeleteMemoTag deletes a tag for a memo.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MemoServiceDeleteMemoTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MemoServiceApi(config);
            var parent = "parent_example";  // string | The parent, who owns the tags. Format: memos/{id}. Use \"memos/-\" to delete all tags.
            var tag = "tag_example";  // string | 
            var deleteRelatedMemos = true;  // bool? |  (optional) 

            try
            {
                // DeleteMemoTag deletes a tag for a memo.
                Object result = apiInstance.MemoServiceDeleteMemoTag(parent, tag, deleteRelatedMemos);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemoServiceApi.MemoServiceDeleteMemoTag: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MemoServiceDeleteMemoTagWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DeleteMemoTag deletes a tag for a memo.
    ApiResponse<Object> response = apiInstance.MemoServiceDeleteMemoTagWithHttpInfo(parent, tag, deleteRelatedMemos);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemoServiceApi.MemoServiceDeleteMemoTagWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parent** | **string** | The parent, who owns the tags. Format: memos/{id}. Use \&quot;memos/-\&quot; to delete all tags. |  |
| **tag** | **string** |  |  |
| **deleteRelatedMemos** | **bool?** |  | [optional]  |

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

<a id="memoserviceexportmemos"></a>
# **MemoServiceExportMemos**
> V1ExportMemosResponse MemoServiceExportMemos (V1ExportMemosRequest body)

ExportMemos exports memos.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MemoServiceExportMemosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MemoServiceApi(config);
            var body = new V1ExportMemosRequest(); // V1ExportMemosRequest | 

            try
            {
                // ExportMemos exports memos.
                V1ExportMemosResponse result = apiInstance.MemoServiceExportMemos(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemoServiceApi.MemoServiceExportMemos: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MemoServiceExportMemosWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ExportMemos exports memos.
    ApiResponse<V1ExportMemosResponse> response = apiInstance.MemoServiceExportMemosWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemoServiceApi.MemoServiceExportMemosWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**V1ExportMemosRequest**](V1ExportMemosRequest.md) |  |  |

### Return type

[**V1ExportMemosResponse**](V1ExportMemosResponse.md)

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

<a id="memoservicegetmemo"></a>
# **MemoServiceGetMemo**
> V1Memo MemoServiceGetMemo (string name3)

GetMemo gets a memo.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MemoServiceGetMemoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MemoServiceApi(config);
            var name3 = "name3_example";  // string | The name of the memo. Format: memos/{id}

            try
            {
                // GetMemo gets a memo.
                V1Memo result = apiInstance.MemoServiceGetMemo(name3);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemoServiceApi.MemoServiceGetMemo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MemoServiceGetMemoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetMemo gets a memo.
    ApiResponse<V1Memo> response = apiInstance.MemoServiceGetMemoWithHttpInfo(name3);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemoServiceApi.MemoServiceGetMemoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name3** | **string** | The name of the memo. Format: memos/{id} |  |

### Return type

[**V1Memo**](V1Memo.md)

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

<a id="memoservicegetusermemosstats"></a>
# **MemoServiceGetUserMemosStats**
> V1GetUserMemosStatsResponse MemoServiceGetUserMemosStats (string? name = null, string? timezone = null, string? filter = null)

GetUserMemosStats gets stats of memos for a user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MemoServiceGetUserMemosStatsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MemoServiceApi(config);
            var name = "name_example";  // string? | name is the name of the user to get stats for. Format: users/{id} (optional) 
            var timezone = "timezone_example";  // string? | timezone location Format: uses tz identifier https://en.wikipedia.org/wiki/List_of_tz_database_time_zones (optional) 
            var filter = "filter_example";  // string? | Same as ListMemosRequest.filter (optional) 

            try
            {
                // GetUserMemosStats gets stats of memos for a user.
                V1GetUserMemosStatsResponse result = apiInstance.MemoServiceGetUserMemosStats(name, timezone, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemoServiceApi.MemoServiceGetUserMemosStats: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MemoServiceGetUserMemosStatsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetUserMemosStats gets stats of memos for a user.
    ApiResponse<V1GetUserMemosStatsResponse> response = apiInstance.MemoServiceGetUserMemosStatsWithHttpInfo(name, timezone, filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemoServiceApi.MemoServiceGetUserMemosStatsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string?** | name is the name of the user to get stats for. Format: users/{id} | [optional]  |
| **timezone** | **string?** | timezone location Format: uses tz identifier https://en.wikipedia.org/wiki/List_of_tz_database_time_zones | [optional]  |
| **filter** | **string?** | Same as ListMemosRequest.filter | [optional]  |

### Return type

[**V1GetUserMemosStatsResponse**](V1GetUserMemosStatsResponse.md)

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

<a id="memoservicelistmemocomments"></a>
# **MemoServiceListMemoComments**
> V1ListMemoCommentsResponse MemoServiceListMemoComments (string name)

ListMemoComments lists comments for a memo.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MemoServiceListMemoCommentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MemoServiceApi(config);
            var name = "name_example";  // string | The name of the memo. Format: memos/{id}

            try
            {
                // ListMemoComments lists comments for a memo.
                V1ListMemoCommentsResponse result = apiInstance.MemoServiceListMemoComments(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemoServiceApi.MemoServiceListMemoComments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MemoServiceListMemoCommentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListMemoComments lists comments for a memo.
    ApiResponse<V1ListMemoCommentsResponse> response = apiInstance.MemoServiceListMemoCommentsWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemoServiceApi.MemoServiceListMemoCommentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | The name of the memo. Format: memos/{id} |  |

### Return type

[**V1ListMemoCommentsResponse**](V1ListMemoCommentsResponse.md)

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

<a id="memoservicelistmemoproperties"></a>
# **MemoServiceListMemoProperties**
> V1ListMemoPropertiesResponse MemoServiceListMemoProperties (string name)

ListMemoProperties lists memo properties.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MemoServiceListMemoPropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MemoServiceApi(config);
            var name = "name_example";  // string | The name of the memo. Format: memos/{id}. Use \"memos/-\" to list all properties.

            try
            {
                // ListMemoProperties lists memo properties.
                V1ListMemoPropertiesResponse result = apiInstance.MemoServiceListMemoProperties(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemoServiceApi.MemoServiceListMemoProperties: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MemoServiceListMemoPropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListMemoProperties lists memo properties.
    ApiResponse<V1ListMemoPropertiesResponse> response = apiInstance.MemoServiceListMemoPropertiesWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemoServiceApi.MemoServiceListMemoPropertiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | The name of the memo. Format: memos/{id}. Use \&quot;memos/-\&quot; to list all properties. |  |

### Return type

[**V1ListMemoPropertiesResponse**](V1ListMemoPropertiesResponse.md)

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

<a id="memoservicelistmemoreactions"></a>
# **MemoServiceListMemoReactions**
> V1ListMemoReactionsResponse MemoServiceListMemoReactions (string name)

ListMemoReactions lists reactions for a memo.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MemoServiceListMemoReactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MemoServiceApi(config);
            var name = "name_example";  // string | The name of the memo. Format: memos/{id}

            try
            {
                // ListMemoReactions lists reactions for a memo.
                V1ListMemoReactionsResponse result = apiInstance.MemoServiceListMemoReactions(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemoServiceApi.MemoServiceListMemoReactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MemoServiceListMemoReactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListMemoReactions lists reactions for a memo.
    ApiResponse<V1ListMemoReactionsResponse> response = apiInstance.MemoServiceListMemoReactionsWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemoServiceApi.MemoServiceListMemoReactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | The name of the memo. Format: memos/{id} |  |

### Return type

[**V1ListMemoReactionsResponse**](V1ListMemoReactionsResponse.md)

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

<a id="memoservicelistmemorelations"></a>
# **MemoServiceListMemoRelations**
> V1ListMemoRelationsResponse MemoServiceListMemoRelations (string name)

ListMemoRelations lists relations for a memo.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MemoServiceListMemoRelationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MemoServiceApi(config);
            var name = "name_example";  // string | The name of the memo. Format: memos/{id}

            try
            {
                // ListMemoRelations lists relations for a memo.
                V1ListMemoRelationsResponse result = apiInstance.MemoServiceListMemoRelations(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemoServiceApi.MemoServiceListMemoRelations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MemoServiceListMemoRelationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListMemoRelations lists relations for a memo.
    ApiResponse<V1ListMemoRelationsResponse> response = apiInstance.MemoServiceListMemoRelationsWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemoServiceApi.MemoServiceListMemoRelationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | The name of the memo. Format: memos/{id} |  |

### Return type

[**V1ListMemoRelationsResponse**](V1ListMemoRelationsResponse.md)

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

<a id="memoservicelistmemoresources"></a>
# **MemoServiceListMemoResources**
> V1ListMemoResourcesResponse MemoServiceListMemoResources (string name)

ListMemoResources lists resources for a memo.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MemoServiceListMemoResourcesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MemoServiceApi(config);
            var name = "name_example";  // string | The name of the memo. Format: memos/{id}

            try
            {
                // ListMemoResources lists resources for a memo.
                V1ListMemoResourcesResponse result = apiInstance.MemoServiceListMemoResources(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemoServiceApi.MemoServiceListMemoResources: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MemoServiceListMemoResourcesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListMemoResources lists resources for a memo.
    ApiResponse<V1ListMemoResourcesResponse> response = apiInstance.MemoServiceListMemoResourcesWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemoServiceApi.MemoServiceListMemoResourcesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | The name of the memo. Format: memos/{id} |  |

### Return type

[**V1ListMemoResourcesResponse**](V1ListMemoResourcesResponse.md)

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

<a id="memoservicelistmemotags"></a>
# **MemoServiceListMemoTags**
> V1ListMemoTagsResponse MemoServiceListMemoTags (string parent, string? filter = null)

ListMemoTags lists tags for a memo.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MemoServiceListMemoTagsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MemoServiceApi(config);
            var parent = "parent_example";  // string | The parent, who owns the tags. Format: memos/{id}. Use \"memos/-\" to list all tags.
            var filter = "filter_example";  // string? | Filter is used to filter memos. Format: \"creator == 'users/{uid}' && visibilities == ['PUBLIC', 'PROTECTED']\" (optional) 

            try
            {
                // ListMemoTags lists tags for a memo.
                V1ListMemoTagsResponse result = apiInstance.MemoServiceListMemoTags(parent, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemoServiceApi.MemoServiceListMemoTags: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MemoServiceListMemoTagsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListMemoTags lists tags for a memo.
    ApiResponse<V1ListMemoTagsResponse> response = apiInstance.MemoServiceListMemoTagsWithHttpInfo(parent, filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemoServiceApi.MemoServiceListMemoTagsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parent** | **string** | The parent, who owns the tags. Format: memos/{id}. Use \&quot;memos/-\&quot; to list all tags. |  |
| **filter** | **string?** | Filter is used to filter memos. Format: \&quot;creator &#x3D;&#x3D; &#39;users/{uid}&#39; &amp;&amp; visibilities &#x3D;&#x3D; [&#39;PUBLIC&#39;, &#39;PROTECTED&#39;]\&quot; | [optional]  |

### Return type

[**V1ListMemoTagsResponse**](V1ListMemoTagsResponse.md)

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

<a id="memoservicelistmemos"></a>
# **MemoServiceListMemos**
> V1ListMemosResponse MemoServiceListMemos (int? pageSize = null, string? pageToken = null, string? filter = null)

ListMemos lists memos with pagination and filter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MemoServiceListMemosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MemoServiceApi(config);
            var pageSize = 56;  // int? | The maximum number of memos to return. (optional) 
            var pageToken = "pageToken_example";  // string? | A page token, received from a previous `ListMemos` call. Provide this to retrieve the subsequent page. (optional) 
            var filter = "filter_example";  // string? | Filter is used to filter memos returned in the list. Format: \"creator == 'users/{uid}' && visibilities == ['PUBLIC', 'PROTECTED']\" (optional) 

            try
            {
                // ListMemos lists memos with pagination and filter.
                V1ListMemosResponse result = apiInstance.MemoServiceListMemos(pageSize, pageToken, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemoServiceApi.MemoServiceListMemos: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MemoServiceListMemosWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListMemos lists memos with pagination and filter.
    ApiResponse<V1ListMemosResponse> response = apiInstance.MemoServiceListMemosWithHttpInfo(pageSize, pageToken, filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemoServiceApi.MemoServiceListMemosWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pageSize** | **int?** | The maximum number of memos to return. | [optional]  |
| **pageToken** | **string?** | A page token, received from a previous &#x60;ListMemos&#x60; call. Provide this to retrieve the subsequent page. | [optional]  |
| **filter** | **string?** | Filter is used to filter memos returned in the list. Format: \&quot;creator &#x3D;&#x3D; &#39;users/{uid}&#39; &amp;&amp; visibilities &#x3D;&#x3D; [&#39;PUBLIC&#39;, &#39;PROTECTED&#39;]\&quot; | [optional]  |

### Return type

[**V1ListMemosResponse**](V1ListMemosResponse.md)

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

<a id="memoservicerebuildmemoproperty"></a>
# **MemoServiceRebuildMemoProperty**
> Object MemoServiceRebuildMemoProperty (string name, Object body)

RebuildMemoProperty rebuilds a memo property.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MemoServiceRebuildMemoPropertyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MemoServiceApi(config);
            var name = "name_example";  // string | The name of the memo. Format: memos/{id}. Use \"memos/-\" to rebuild all memos.
            var body = null;  // Object | 

            try
            {
                // RebuildMemoProperty rebuilds a memo property.
                Object result = apiInstance.MemoServiceRebuildMemoProperty(name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemoServiceApi.MemoServiceRebuildMemoProperty: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MemoServiceRebuildMemoPropertyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // RebuildMemoProperty rebuilds a memo property.
    ApiResponse<Object> response = apiInstance.MemoServiceRebuildMemoPropertyWithHttpInfo(name, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemoServiceApi.MemoServiceRebuildMemoPropertyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | The name of the memo. Format: memos/{id}. Use \&quot;memos/-\&quot; to rebuild all memos. |  |
| **body** | **Object** |  |  |

### Return type

**Object**

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

<a id="memoservicerenamememotag"></a>
# **MemoServiceRenameMemoTag**
> Object MemoServiceRenameMemoTag (string parent, MemoServiceRenameMemoTagBody body)

RenameMemoTag renames a tag for a memo.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MemoServiceRenameMemoTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MemoServiceApi(config);
            var parent = "parent_example";  // string | The parent, who owns the tags. Format: memos/{id}. Use \"memos/-\" to rename all tags.
            var body = new MemoServiceRenameMemoTagBody(); // MemoServiceRenameMemoTagBody | 

            try
            {
                // RenameMemoTag renames a tag for a memo.
                Object result = apiInstance.MemoServiceRenameMemoTag(parent, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemoServiceApi.MemoServiceRenameMemoTag: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MemoServiceRenameMemoTagWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // RenameMemoTag renames a tag for a memo.
    ApiResponse<Object> response = apiInstance.MemoServiceRenameMemoTagWithHttpInfo(parent, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemoServiceApi.MemoServiceRenameMemoTagWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parent** | **string** | The parent, who owns the tags. Format: memos/{id}. Use \&quot;memos/-\&quot; to rename all tags. |  |
| **body** | [**MemoServiceRenameMemoTagBody**](MemoServiceRenameMemoTagBody.md) |  |  |

### Return type

**Object**

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

<a id="memoservicesearchmemos"></a>
# **MemoServiceSearchMemos**
> V1SearchMemosResponse MemoServiceSearchMemos (string? filter = null)

SearchMemos searches memos.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MemoServiceSearchMemosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MemoServiceApi(config);
            var filter = "filter_example";  // string? | Filter is used to filter memos returned. Format: \"creator == 'users/{uid}' && visibilities == ['PUBLIC', 'PROTECTED']\" (optional) 

            try
            {
                // SearchMemos searches memos.
                V1SearchMemosResponse result = apiInstance.MemoServiceSearchMemos(filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemoServiceApi.MemoServiceSearchMemos: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MemoServiceSearchMemosWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // SearchMemos searches memos.
    ApiResponse<V1SearchMemosResponse> response = apiInstance.MemoServiceSearchMemosWithHttpInfo(filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemoServiceApi.MemoServiceSearchMemosWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filter** | **string?** | Filter is used to filter memos returned. Format: \&quot;creator &#x3D;&#x3D; &#39;users/{uid}&#39; &amp;&amp; visibilities &#x3D;&#x3D; [&#39;PUBLIC&#39;, &#39;PROTECTED&#39;]\&quot; | [optional]  |

### Return type

[**V1SearchMemosResponse**](V1SearchMemosResponse.md)

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

<a id="memoservicesetmemorelations"></a>
# **MemoServiceSetMemoRelations**
> Object MemoServiceSetMemoRelations (string name, MemoServiceSetMemoRelationsBody body)

SetMemoRelations sets relations for a memo.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MemoServiceSetMemoRelationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MemoServiceApi(config);
            var name = "name_example";  // string | The name of the memo. Format: memos/{id}
            var body = new MemoServiceSetMemoRelationsBody(); // MemoServiceSetMemoRelationsBody | 

            try
            {
                // SetMemoRelations sets relations for a memo.
                Object result = apiInstance.MemoServiceSetMemoRelations(name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemoServiceApi.MemoServiceSetMemoRelations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MemoServiceSetMemoRelationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // SetMemoRelations sets relations for a memo.
    ApiResponse<Object> response = apiInstance.MemoServiceSetMemoRelationsWithHttpInfo(name, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemoServiceApi.MemoServiceSetMemoRelationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | The name of the memo. Format: memos/{id} |  |
| **body** | [**MemoServiceSetMemoRelationsBody**](MemoServiceSetMemoRelationsBody.md) |  |  |

### Return type

**Object**

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

<a id="memoservicesetmemoresources"></a>
# **MemoServiceSetMemoResources**
> Object MemoServiceSetMemoResources (string name, MemoServiceSetMemoResourcesBody body)

SetMemoResources sets resources for a memo.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MemoServiceSetMemoResourcesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MemoServiceApi(config);
            var name = "name_example";  // string | The name of the memo. Format: memos/{id}
            var body = new MemoServiceSetMemoResourcesBody(); // MemoServiceSetMemoResourcesBody | 

            try
            {
                // SetMemoResources sets resources for a memo.
                Object result = apiInstance.MemoServiceSetMemoResources(name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemoServiceApi.MemoServiceSetMemoResources: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MemoServiceSetMemoResourcesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // SetMemoResources sets resources for a memo.
    ApiResponse<Object> response = apiInstance.MemoServiceSetMemoResourcesWithHttpInfo(name, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemoServiceApi.MemoServiceSetMemoResourcesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | The name of the memo. Format: memos/{id} |  |
| **body** | [**MemoServiceSetMemoResourcesBody**](MemoServiceSetMemoResourcesBody.md) |  |  |

### Return type

**Object**

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

<a id="memoserviceupdatememo"></a>
# **MemoServiceUpdateMemo**
> V1Memo MemoServiceUpdateMemo (string memoName, MemoServiceUpdateMemoRequest memo)

UpdateMemo updates a memo.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MemoServiceUpdateMemoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MemoServiceApi(config);
            var memoName = "memoName_example";  // string | The name of the memo. Format: memos/{id} id is the system generated id.
            var memo = new MemoServiceUpdateMemoRequest(); // MemoServiceUpdateMemoRequest | 

            try
            {
                // UpdateMemo updates a memo.
                V1Memo result = apiInstance.MemoServiceUpdateMemo(memoName, memo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemoServiceApi.MemoServiceUpdateMemo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MemoServiceUpdateMemoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpdateMemo updates a memo.
    ApiResponse<V1Memo> response = apiInstance.MemoServiceUpdateMemoWithHttpInfo(memoName, memo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemoServiceApi.MemoServiceUpdateMemoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **memoName** | **string** | The name of the memo. Format: memos/{id} id is the system generated id. |  |
| **memo** | [**MemoServiceUpdateMemoRequest**](MemoServiceUpdateMemoRequest.md) |  |  |

### Return type

[**V1Memo**](V1Memo.md)

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

<a id="memoserviceupsertmemoreaction"></a>
# **MemoServiceUpsertMemoReaction**
> V1Reaction MemoServiceUpsertMemoReaction (string name, MemoServiceUpsertMemoReactionBody body)

UpsertMemoReaction upserts a reaction for a memo.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MemoServiceUpsertMemoReactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MemoServiceApi(config);
            var name = "name_example";  // string | The name of the memo. Format: memos/{id}
            var body = new MemoServiceUpsertMemoReactionBody(); // MemoServiceUpsertMemoReactionBody | 

            try
            {
                // UpsertMemoReaction upserts a reaction for a memo.
                V1Reaction result = apiInstance.MemoServiceUpsertMemoReaction(name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemoServiceApi.MemoServiceUpsertMemoReaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MemoServiceUpsertMemoReactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpsertMemoReaction upserts a reaction for a memo.
    ApiResponse<V1Reaction> response = apiInstance.MemoServiceUpsertMemoReactionWithHttpInfo(name, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemoServiceApi.MemoServiceUpsertMemoReactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | The name of the memo. Format: memos/{id} |  |
| **body** | [**MemoServiceUpsertMemoReactionBody**](MemoServiceUpsertMemoReactionBody.md) |  |  |

### Return type

[**V1Reaction**](V1Reaction.md)

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

