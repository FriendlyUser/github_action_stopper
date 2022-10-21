# Org.OpenAPITools.Api.ForumApi

All URIs are relative to *https://api.myanimelist.net/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ForumBoardsGet**](ForumApi.md#forumboardsget) | **GET** /forum/boards | Get forum boards |
| [**ForumTopicGet**](ForumApi.md#forumtopicget) | **GET** /forum/topic/{topic_id} | Get forum topic detail |
| [**ForumTopicsGet**](ForumApi.md#forumtopicsget) | **GET** /forum/topics | Get forum topics |

<a name="forumboardsget"></a>
# **ForumBoardsGet**
> ForumBoards ForumBoardsGet ()

Get forum boards

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForumBoardsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.myanimelist.net/v2";
            // Configure API key authorization: client_auth
            config.AddApiKey("X-MAL-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-MAL-CLIENT-ID", "Bearer");
            // Configure OAuth2 access token for authorization: main_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ForumApi(config);

            try
            {
                // Get forum boards
                ForumBoards result = apiInstance.ForumBoardsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ForumBoardsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForumBoardsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get forum boards
    ApiResponse<ForumBoards> response = apiInstance.ForumBoardsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.ForumBoardsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ForumBoards**](ForumBoards.md)

### Authorization

[client_auth](../README.md#client_auth), [main_auth](../README.md#main_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="forumtopicget"></a>
# **ForumTopicGet**
> ForumTopic ForumTopicGet (int topicId, int? limit = null, int? offset = null)

Get forum topic detail

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForumTopicGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.myanimelist.net/v2";
            // Configure API key authorization: client_auth
            config.AddApiKey("X-MAL-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-MAL-CLIENT-ID", "Bearer");
            // Configure OAuth2 access token for authorization: main_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ForumApi(config);
            var topicId = 56;  // int | 
            var limit = 100;  // int? |  (optional)  (default to 100)
            var offset = 0;  // int? |  (optional)  (default to 0)

            try
            {
                // Get forum topic detail
                ForumTopic result = apiInstance.ForumTopicGet(topicId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ForumTopicGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForumTopicGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get forum topic detail
    ApiResponse<ForumTopic> response = apiInstance.ForumTopicGetWithHttpInfo(topicId, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.ForumTopicGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **topicId** | **int** |  |  |
| **limit** | **int?** |  | [optional] [default to 100] |
| **offset** | **int?** |  | [optional] [default to 0] |

### Return type

[**ForumTopic**](ForumTopic.md)

### Authorization

[client_auth](../README.md#client_auth), [main_auth](../README.md#main_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="forumtopicsget"></a>
# **ForumTopicsGet**
> ForumTopics ForumTopicsGet (int? boardId = null, int? subboardId = null, int? limit = null, int? offset = null, string? sort = null, string? q = null, string? topicUserName = null, string? userName = null)

Get forum topics

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForumTopicsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.myanimelist.net/v2";
            // Configure API key authorization: client_auth
            config.AddApiKey("X-MAL-CLIENT-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-MAL-CLIENT-ID", "Bearer");
            // Configure OAuth2 access token for authorization: main_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ForumApi(config);
            var boardId = 56;  // int? |  (optional) 
            var subboardId = 56;  // int? |  (optional) 
            var limit = 100;  // int? |  (optional)  (default to 100)
            var offset = 0;  // int? |  (optional)  (default to 0)
            var sort = "\"recent\"";  // string? | Currently, only \"recent\" can be set. (optional)  (default to "recent")
            var q = "q_example";  // string? |  (optional) 
            var topicUserName = "topicUserName_example";  // string? |  (optional) 
            var userName = "userName_example";  // string? |  (optional) 

            try
            {
                // Get forum topics
                ForumTopics result = apiInstance.ForumTopicsGet(boardId, subboardId, limit, offset, sort, q, topicUserName, userName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ForumTopicsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForumTopicsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get forum topics
    ApiResponse<ForumTopics> response = apiInstance.ForumTopicsGetWithHttpInfo(boardId, subboardId, limit, offset, sort, q, topicUserName, userName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.ForumTopicsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **boardId** | **int?** |  | [optional]  |
| **subboardId** | **int?** |  | [optional]  |
| **limit** | **int?** |  | [optional] [default to 100] |
| **offset** | **int?** |  | [optional] [default to 0] |
| **sort** | **string?** | Currently, only \&quot;recent\&quot; can be set. | [optional] [default to &quot;recent&quot;] |
| **q** | **string?** |  | [optional]  |
| **topicUserName** | **string?** |  | [optional]  |
| **userName** | **string?** |  | [optional]  |

### Return type

[**ForumTopics**](ForumTopics.md)

### Authorization

[client_auth](../README.md#client_auth), [main_auth](../README.md#main_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

