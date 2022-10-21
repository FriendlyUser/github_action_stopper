/*
 * MyAnimeList API (beta ver.)
 *
 * MyAnimeList.net is the property of MyAnimeList Co.,Ltd. All Rights Reserved.  ## Versioning  There are multiple versions of the API. You can specify a version by including it in the request uri:  (During closed beta, version starts with '0.')  `https://api.myanimelist.net/v2`  The version is incremented if any backwards incompatible changes are introduced to the API.  Examples of backwards incompatible changes are belows:  - Removing existing endpoints. - Removing existing fields of API responses. - Changing mean of the existing fields.  On the other hand, belows are examples of backwards compatible changes:  - Adding new endpoints. - Adding new optional request parameters. - Adding new fields to existing API responses. - Changing the order of fields in existing API responses. - Changing the contents of fields that suffixed by `_formatted`.   ## Common formats  ### List / Pagination  ```json {   \"data\": [     {...},     {...},     ...   ],   \"paging\": {     \"previous\": \"https://xxx\",     \"next\": \"https://xxx\"   } } ```      ### Date / Time format  <table> <tr> <th>Format <th>Type <th>Sample <th>Description </tr>  <tr> <td>date-time <td>string <td>\"2015-03-02T06:03:11+00:00\"  <td>ISO 8601 </tr>      <tr> <td>date <td>string <td>\"2017-10-23\" or <br>\"2017-10\" or <br>\"2017\" <td> </tr>  <tr> <td>time <td>string <td>\"01:35\" <td> </tr>  </table>  ### Error format   ```json {   \"error\": \"invalid_token\"   \"message\": \"token is invalid\", } ```  ## Common parameters  ### Parameters for endpoints that return a list  | Name | Description | | - -- | - -- | | limit |  | | offset |  |  ### Choosing fields  By default, the API doesn’t return all fields.  You can choose the fields that you want returned with the `fields` parameter.  Example:  ``` fields=synopsis,my_list_status{priority,comments} ```  ### Not Safe For Work  By default, some APIs don’t return nsfw content.  You can control this behavior with the `nsfw` parameter.  | Name | Description | | - -- | - -- | | nsfw | `true` or `false` |   ## Common status codes  | Status code | Error code | Description | | - -- - | - -- - | - -- - | | 400 Bad Request | - | Invalid Parameters | | 401 Unauthorized | invalid_token | Expired access tokens, Invalid access tokens, etc. | | 403 Forbidden | - | DoS detected etc. | | 404 Not Found | - | |  # Authentication  <!- - ReDoc-Inject: <security-definitions> - ->
 *
 * The version of the OpenAPI document: 2
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;
using Org.OpenAPITools.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Test.Model
{
    /// <summary>
    ///  Class for testing MangaForList
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class MangaForListTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for MangaForList
        //private MangaForList instance;

        public MangaForListTests()
        {
            // TODO uncomment below to create an instance of MangaForList
            //instance = new MangaForList();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MangaForList
        /// </summary>
        [Fact]
        public void MangaForListInstanceTest()
        {
            // TODO uncomment below to test "IsType" MangaForList
            //Assert.IsType<MangaForList>(instance);
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Title'
        /// </summary>
        [Fact]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }
        /// <summary>
        /// Test the property 'MainPicture'
        /// </summary>
        [Fact]
        public void MainPictureTest()
        {
            // TODO unit test for the property 'MainPicture'
        }
        /// <summary>
        /// Test the property 'AlternativeTitles'
        /// </summary>
        [Fact]
        public void AlternativeTitlesTest()
        {
            // TODO unit test for the property 'AlternativeTitles'
        }
        /// <summary>
        /// Test the property 'StartDate'
        /// </summary>
        [Fact]
        public void StartDateTest()
        {
            // TODO unit test for the property 'StartDate'
        }
        /// <summary>
        /// Test the property 'EndDate'
        /// </summary>
        [Fact]
        public void EndDateTest()
        {
            // TODO unit test for the property 'EndDate'
        }
        /// <summary>
        /// Test the property 'Synopsis'
        /// </summary>
        [Fact]
        public void SynopsisTest()
        {
            // TODO unit test for the property 'Synopsis'
        }
        /// <summary>
        /// Test the property 'Mean'
        /// </summary>
        [Fact]
        public void MeanTest()
        {
            // TODO unit test for the property 'Mean'
        }
        /// <summary>
        /// Test the property 'Rank'
        /// </summary>
        [Fact]
        public void RankTest()
        {
            // TODO unit test for the property 'Rank'
        }
        /// <summary>
        /// Test the property 'Popularity'
        /// </summary>
        [Fact]
        public void PopularityTest()
        {
            // TODO unit test for the property 'Popularity'
        }
        /// <summary>
        /// Test the property 'NumListUsers'
        /// </summary>
        [Fact]
        public void NumListUsersTest()
        {
            // TODO unit test for the property 'NumListUsers'
        }
        /// <summary>
        /// Test the property 'NumScoringUsers'
        /// </summary>
        [Fact]
        public void NumScoringUsersTest()
        {
            // TODO unit test for the property 'NumScoringUsers'
        }
        /// <summary>
        /// Test the property 'Nsfw'
        /// </summary>
        [Fact]
        public void NsfwTest()
        {
            // TODO unit test for the property 'Nsfw'
        }
        /// <summary>
        /// Test the property 'Genres'
        /// </summary>
        [Fact]
        public void GenresTest()
        {
            // TODO unit test for the property 'Genres'
        }
        /// <summary>
        /// Test the property 'CreatedAt'
        /// </summary>
        [Fact]
        public void CreatedAtTest()
        {
            // TODO unit test for the property 'CreatedAt'
        }
        /// <summary>
        /// Test the property 'UpdatedAt'
        /// </summary>
        [Fact]
        public void UpdatedAtTest()
        {
            // TODO unit test for the property 'UpdatedAt'
        }
        /// <summary>
        /// Test the property 'MediaType'
        /// </summary>
        [Fact]
        public void MediaTypeTest()
        {
            // TODO unit test for the property 'MediaType'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'MyListStatus'
        /// </summary>
        [Fact]
        public void MyListStatusTest()
        {
            // TODO unit test for the property 'MyListStatus'
        }
        /// <summary>
        /// Test the property 'NumVolumes'
        /// </summary>
        [Fact]
        public void NumVolumesTest()
        {
            // TODO unit test for the property 'NumVolumes'
        }
        /// <summary>
        /// Test the property 'NumChapters'
        /// </summary>
        [Fact]
        public void NumChaptersTest()
        {
            // TODO unit test for the property 'NumChapters'
        }
        /// <summary>
        /// Test the property 'Authors'
        /// </summary>
        [Fact]
        public void AuthorsTest()
        {
            // TODO unit test for the property 'Authors'
        }

    }

}
