# Org.OpenAPITools.Api.MangaApi

All URIs are relative to *https://api.myanimelist.net/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**MangaGet**](MangaApi.md#mangaget) | **GET** /manga | Get manga list |
| [**MangaMangaIdGet**](MangaApi.md#mangamangaidget) | **GET** /manga/{manga_id} | Get manga details |
| [**MangaRankingGet**](MangaApi.md#mangarankingget) | **GET** /manga/ranking | Get manga ranking |

<a name="mangaget"></a>
# **MangaGet**
> MangaList MangaGet (string? q = null, int? limit = null, int? offset = null, string? fields = null)

Get manga list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MangaGetExample
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

            var apiInstance = new MangaApi(config);
            var q = "q_example";  // string? | Search.  (optional) 
            var limit = 100;  // int? | The maximum value is 100.  (optional)  (default to 100)
            var offset = 0;  // int? |  (optional)  (default to 0)
            var fields = "fields_example";  // string? |  (optional) 

            try
            {
                // Get manga list
                MangaList result = apiInstance.MangaGet(q, limit, offset, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MangaApi.MangaGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MangaGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get manga list
    ApiResponse<MangaList> response = apiInstance.MangaGetWithHttpInfo(q, limit, offset, fields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MangaApi.MangaGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **q** | **string?** | Search.  | [optional]  |
| **limit** | **int?** | The maximum value is 100.  | [optional] [default to 100] |
| **offset** | **int?** |  | [optional] [default to 0] |
| **fields** | **string?** |  | [optional]  |

### Return type

[**MangaList**](MangaList.md)

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

<a name="mangamangaidget"></a>
# **MangaMangaIdGet**
> MangaForDetails MangaMangaIdGet (int mangaId, string? fields = null)

Get manga details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MangaMangaIdGetExample
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

            var apiInstance = new MangaApi(config);
            var mangaId = 56;  // int | 
            var fields = "fields_example";  // string? |  (optional) 

            try
            {
                // Get manga details
                MangaForDetails result = apiInstance.MangaMangaIdGet(mangaId, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MangaApi.MangaMangaIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MangaMangaIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get manga details
    ApiResponse<MangaForDetails> response = apiInstance.MangaMangaIdGetWithHttpInfo(mangaId, fields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MangaApi.MangaMangaIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **mangaId** | **int** |  |  |
| **fields** | **string?** |  | [optional]  |

### Return type

[**MangaForDetails**](MangaForDetails.md)

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

<a name="mangarankingget"></a>
# **MangaRankingGet**
> MangaListForRanking MangaRankingGet (string rankingType, int? limit = null, int? offset = null, string? fields = null)

Get manga ranking

The returned manga contains the `ranking` field. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MangaRankingGetExample
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

            var apiInstance = new MangaApi(config);
            var rankingType = "rankingType_example";  // string | | value | | | - -- - | - -- - | | all | All | | manga | Top Manga | | novels | Top Novels | | oneshots | Top One-shots | | doujin | Top Doujinshi | | manhwa | Top Manhwa | | manhua | Top Manhua | | bypopularity | Most Popular | | favorite | Most Favorited |  
            var limit = 100;  // int? | The maximum value is 500.  (optional)  (default to 100)
            var offset = 0;  // int? |  (optional)  (default to 0)
            var fields = "fields_example";  // string? |  (optional) 

            try
            {
                // Get manga ranking
                MangaListForRanking result = apiInstance.MangaRankingGet(rankingType, limit, offset, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MangaApi.MangaRankingGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MangaRankingGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get manga ranking
    ApiResponse<MangaListForRanking> response = apiInstance.MangaRankingGetWithHttpInfo(rankingType, limit, offset, fields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MangaApi.MangaRankingGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **rankingType** | **string** | | value | | | - -- - | - -- - | | all | All | | manga | Top Manga | | novels | Top Novels | | oneshots | Top One-shots | | doujin | Top Doujinshi | | manhwa | Top Manhwa | | manhua | Top Manhua | | bypopularity | Most Popular | | favorite | Most Favorited |   |  |
| **limit** | **int?** | The maximum value is 500.  | [optional] [default to 100] |
| **offset** | **int?** |  | [optional] [default to 0] |
| **fields** | **string?** |  | [optional]  |

### Return type

[**MangaListForRanking**](MangaListForRanking.md)

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

