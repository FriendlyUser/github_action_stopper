# Org.OpenAPITools.Api.UserApi

All URIs are relative to *https://api.myanimelist.net/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UsersUserIdGet**](UserApi.md#usersuseridget) | **GET** /users/{user_id} | Get my user information |

<a name="usersuseridget"></a>
# **UsersUserIdGet**
> User UsersUserIdGet (string userId, string? fields = null)

Get my user information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersUserIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.myanimelist.net/v2";
            // Configure OAuth2 access token for authorization: main_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserApi(config);
            var userId = "userId_example";  // string | You can only specify `@me`. 
            var fields = "fields_example";  // string? |  (optional) 

            try
            {
                // Get my user information
                User result = apiInstance.UsersUserIdGet(userId, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UsersUserIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersUserIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get my user information
    ApiResponse<User> response = apiInstance.UsersUserIdGetWithHttpInfo(userId, fields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UsersUserIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | You can only specify &#x60;@me&#x60;.  |  |
| **fields** | **string?** |  | [optional]  |

### Return type

[**User**](User.md)

### Authorization

[main_auth](../README.md#main_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

