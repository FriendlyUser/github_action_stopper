// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;


// use AnimeRankingGet for Top Upcoming Anime and Top Airing Anime
string mal_api_key = Environment.GetEnvironmentVariable("MAL_CLIENT_ID");
Configuration config = new Configuration();
config.BasePath = "https://api.myanimelist.net/v2";
// Configure API key authorization: client_auth
config.ApiKey.Add("X-MAL-CLIENT-ID", mal_api_key);
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// config.ApiKeyPrefix.Add("X-MAL-CLIENT-ID", "Bearer");
// Configure OAuth2 access token for authorization: main_auth
// config.AccessToken = "YOUR_ACCESS_TOKEN";

var apiInstance = new AnimeApi(config);

try
{
// Get anime details
Console.WriteLine("----------- UPCOMING -----------");
var upcoming = apiInstance.AnimeRankingGet("upcoming", 20);
// iterate across data
foreach (var item in upcoming.Data)
{
    Console.WriteLine(item.Node.Title);
}
Console.WriteLine("----------- END UPCOMING -----------");

Console.WriteLine("----------- airing -----------");
var airing = apiInstance.AnimeRankingGet("airing", 20);
// iterate across data
foreach (var item in airing.Data)
{
    Console.WriteLine(item.Node.Title);
}
Console.WriteLine("----------- END airing -----------");

}
catch (ApiException e)
{
Console.WriteLine("Exception when calling AnimeApi.AnimeAnimeIdGet: " + e.Message );
Console.WriteLine("Status Code: "+ e.ErrorCode);
Console.WriteLine(e.StackTrace);
}


Console.WriteLine("Hello, World!");
// get top anime