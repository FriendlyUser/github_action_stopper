# Org.OpenAPITools.Api.AnimeApi

All URIs are relative to *https://api.myanimelist.net/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AnimeAnimeIdGet**](AnimeApi.md#animeanimeidget) | **GET** /anime/{anime_id} | Get anime details |
| [**AnimeGet**](AnimeApi.md#animeget) | **GET** /anime | Get anime list |
| [**AnimeRankingGet**](AnimeApi.md#animerankingget) | **GET** /anime/ranking | Get anime ranking |
| [**AnimeSeasonYearSeasonGet**](AnimeApi.md#animeseasonyearseasonget) | **GET** /anime/season/{year}/{season} | Get seasonal anime |
| [**AnimeSuggestionsGet**](AnimeApi.md#animesuggestionsget) | **GET** /anime/suggestions | Get suggested anime |

<a name="animeanimeidget"></a>
# **AnimeAnimeIdGet**
> AnimeForDetails AnimeAnimeIdGet (int animeId, string? fields = null)

Get anime details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AnimeAnimeIdGetExample
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

            var apiInstance = new AnimeApi(config);
            var animeId = 56;  // int | 
            var fields = "fields_example";  // string? |  (optional) 

            try
            {
                // Get anime details
                AnimeForDetails result = apiInstance.AnimeAnimeIdGet(animeId, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnimeApi.AnimeAnimeIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnimeAnimeIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get anime details
    ApiResponse<AnimeForDetails> response = apiInstance.AnimeAnimeIdGetWithHttpInfo(animeId, fields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnimeApi.AnimeAnimeIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **animeId** | **int** |  |  |
| **fields** | **string?** |  | [optional]  |

### Return type

[**AnimeForDetails**](AnimeForDetails.md)

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

<a name="animeget"></a>
# **AnimeGet**
> AnimeList AnimeGet (string? q = null, int? limit = null, int? offset = null, string? fields = null)

Get anime list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AnimeGetExample
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

            var apiInstance = new AnimeApi(config);
            var q = "q_example";  // string? | Search.  (optional) 
            var limit = 100;  // int? | The maximum value is 100.  (optional)  (default to 100)
            var offset = 0;  // int? |  (optional)  (default to 0)
            var fields = "fields_example";  // string? |  (optional) 

            try
            {
                // Get anime list
                AnimeList result = apiInstance.AnimeGet(q, limit, offset, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnimeApi.AnimeGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnimeGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get anime list
    ApiResponse<AnimeList> response = apiInstance.AnimeGetWithHttpInfo(q, limit, offset, fields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnimeApi.AnimeGetWithHttpInfo: " + e.Message);
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

[**AnimeList**](AnimeList.md)

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

<a name="animerankingget"></a>
# **AnimeRankingGet**
> AnimeListForRanking AnimeRankingGet (string rankingType, int? limit = null, int? offset = null, string? fields = null)

Get anime ranking

The returned anime contains the `ranking` field. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AnimeRankingGetExample
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

            var apiInstance = new AnimeApi(config);
            var rankingType = "rankingType_example";  // string | | value | | | - -- - | - -- - | | all | Top Anime Series | | airing | Top Airing Anime | | upcoming | Top Upcoming Anime | | tv | Top Anime TV Series | | ova | Top Anime OVA Series | | movie | Top Anime Movies | | special | Top Anime Specials | | bypopularity | Top Anime by Popularity | | favorite | Top Favorited Anime | 
            var limit = 100;  // int? | The maximum value is 500.  (optional)  (default to 100)
            var offset = 0;  // int? |  (optional)  (default to 0)
            var fields = "fields_example";  // string? |  (optional) 

            try
            {
                // Get anime ranking
                AnimeListForRanking result = apiInstance.AnimeRankingGet(rankingType, limit, offset, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnimeApi.AnimeRankingGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnimeRankingGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get anime ranking
    ApiResponse<AnimeListForRanking> response = apiInstance.AnimeRankingGetWithHttpInfo(rankingType, limit, offset, fields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnimeApi.AnimeRankingGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **rankingType** | **string** | | value | | | - -- - | - -- - | | all | Top Anime Series | | airing | Top Airing Anime | | upcoming | Top Upcoming Anime | | tv | Top Anime TV Series | | ova | Top Anime OVA Series | | movie | Top Anime Movies | | special | Top Anime Specials | | bypopularity | Top Anime by Popularity | | favorite | Top Favorited Anime |  |  |
| **limit** | **int?** | The maximum value is 500.  | [optional] [default to 100] |
| **offset** | **int?** |  | [optional] [default to 0] |
| **fields** | **string?** |  | [optional]  |

### Return type

[**AnimeListForRanking**](AnimeListForRanking.md)

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

<a name="animeseasonyearseasonget"></a>
# **AnimeSeasonYearSeasonGet**
> AnimeList AnimeSeasonYearSeasonGet (int year, string season, string? sort = null, int? limit = null, int? offset = null, string? fields = null)

Get seasonal anime

Get seasonal anime.  | Season name | Months | | - -- - | - -- - | | winter | January, February, March |  | spring | April, May, June |  | summer | July, August, September |  | fall | October, November, December |  

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AnimeSeasonYearSeasonGetExample
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

            var apiInstance = new AnimeApi(config);
            var year = 56;  // int | 
            var season = "season_example";  // string | 
            var sort = "sort_example";  // string? | Valid values:  | Value | Order | | - -- - | - -- - | | `anime_score` | Descending | | `anime_num_list_users` | Descending |  (optional) 
            var limit = 100;  // int? | The maximum value is 500. (optional)  (default to 100)
            var offset = 0;  // int? |  (optional)  (default to 0)
            var fields = "fields_example";  // string? |  (optional) 

            try
            {
                // Get seasonal anime
                AnimeList result = apiInstance.AnimeSeasonYearSeasonGet(year, season, sort, limit, offset, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnimeApi.AnimeSeasonYearSeasonGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnimeSeasonYearSeasonGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get seasonal anime
    ApiResponse<AnimeList> response = apiInstance.AnimeSeasonYearSeasonGetWithHttpInfo(year, season, sort, limit, offset, fields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnimeApi.AnimeSeasonYearSeasonGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int** |  |  |
| **season** | **string** |  |  |
| **sort** | **string?** | Valid values:  | Value | Order | | - -- - | - -- - | | &#x60;anime_score&#x60; | Descending | | &#x60;anime_num_list_users&#x60; | Descending |  | [optional]  |
| **limit** | **int?** | The maximum value is 500. | [optional] [default to 100] |
| **offset** | **int?** |  | [optional] [default to 0] |
| **fields** | **string?** |  | [optional]  |

### Return type

[**AnimeList**](AnimeList.md)

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

<a name="animesuggestionsget"></a>
# **AnimeSuggestionsGet**
> AnimeList AnimeSuggestionsGet (int? limit = null, int? offset = null, string? fields = null)

Get suggested anime

Returns suggested anime for the authorized user.  If the user is new comer, this endpoint returns an empty list. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AnimeSuggestionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.myanimelist.net/v2";
            // Configure OAuth2 access token for authorization: main_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AnimeApi(config);
            var limit = 100;  // int? | The maximum value is 100. (optional)  (default to 100)
            var offset = 0;  // int? |  (optional)  (default to 0)
            var fields = "fields_example";  // string? |  (optional) 

            try
            {
                // Get suggested anime
                AnimeList result = apiInstance.AnimeSuggestionsGet(limit, offset, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnimeApi.AnimeSuggestionsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnimeSuggestionsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get suggested anime
    ApiResponse<AnimeList> response = apiInstance.AnimeSuggestionsGetWithHttpInfo(limit, offset, fields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnimeApi.AnimeSuggestionsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** | The maximum value is 100. | [optional] [default to 100] |
| **offset** | **int?** |  | [optional] [default to 0] |
| **fields** | **string?** |  | [optional]  |

### Return type

[**AnimeList**](AnimeList.md)

### Authorization

[main_auth](../README.md#main_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

