/*
 * MyAnimeList API (beta ver.)
 *
 * MyAnimeList.net is the property of MyAnimeList Co.,Ltd. All Rights Reserved.  ## Versioning  There are multiple versions of the API. You can specify a version by including it in the request uri:  (During closed beta, version starts with '0.')  `https://api.myanimelist.net/v2`  The version is incremented if any backwards incompatible changes are introduced to the API.  Examples of backwards incompatible changes are belows:  - Removing existing endpoints. - Removing existing fields of API responses. - Changing mean of the existing fields.  On the other hand, belows are examples of backwards compatible changes:  - Adding new endpoints. - Adding new optional request parameters. - Adding new fields to existing API responses. - Changing the order of fields in existing API responses. - Changing the contents of fields that suffixed by `_formatted`.   ## Common formats  ### List / Pagination  ```json {   \"data\": [     {...},     {...},     ...   ],   \"paging\": {     \"previous\": \"https://xxx\",     \"next\": \"https://xxx\"   } } ```      ### Date / Time format  <table> <tr> <th>Format <th>Type <th>Sample <th>Description </tr>  <tr> <td>date-time <td>string <td>\"2015-03-02T06:03:11+00:00\"  <td>ISO 8601 </tr>      <tr> <td>date <td>string <td>\"2017-10-23\" or <br>\"2017-10\" or <br>\"2017\" <td> </tr>  <tr> <td>time <td>string <td>\"01:35\" <td> </tr>  </table>  ### Error format   ```json {   \"error\": \"invalid_token\"   \"message\": \"token is invalid\", } ```  ## Common parameters  ### Parameters for endpoints that return a list  | Name | Description | | - -- | - -- | | limit |  | | offset |  |  ### Choosing fields  By default, the API doesn’t return all fields.  You can choose the fields that you want returned with the `fields` parameter.  Example:  ``` fields=synopsis,my_list_status{priority,comments} ```  ### Not Safe For Work  By default, some APIs don’t return nsfw content.  You can control this behavior with the `nsfw` parameter.  | Name | Description | | - -- | - -- | | nsfw | `true` or `false` |   ## Common status codes  | Status code | Error code | Description | | - -- - | - -- - | - -- - | | 400 Bad Request | - | Invalid Parameters | | 401 Unauthorized | invalid_token | Expired access tokens, Invalid access tokens, etc. | | 403 Forbidden | - | DoS detected etc. | | 404 Not Found | - | |  # Authentication  <!- - ReDoc-Inject: <security-definitions> - ->
 *
 * The version of the OpenAPI document: 2
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Org.OpenAPITools.Client
{
    /// <summary>
    /// Utility functions providing some benefit to API client consumers.
    /// </summary>
    public static class ClientUtils
    {
        /// <summary>
        /// Sanitize filename by removing the path
        /// </summary>
        /// <param name="filename">Filename</param>
        /// <returns>Filename</returns>
        public static string SanitizeFilename(string filename)
        {
            Match match = Regex.Match(filename, @".*[/\\](.*)$");
            return match.Success ? match.Groups[1].Value : filename;
        }

        /// <summary>
        /// Convert params to key/value pairs.
        /// Use collectionFormat to properly format lists and collections.
        /// </summary>
        /// <param name="collectionFormat">The swagger-supported collection format, one of: csv, tsv, ssv, pipes, multi</param>
        /// <param name="name">Key name.</param>
        /// <param name="value">Value object.</param>
        /// <returns>A multimap of keys with 1..n associated values.</returns>
        public static Multimap<string, string> ParameterToMultiMap(string collectionFormat, string name, object value)
        {
            var parameters = new Multimap<string, string>();

            if (value is ICollection collection && collectionFormat == "multi")
            {
                foreach (var item in collection)
                {
                    parameters.Add(name, ParameterToString(item));
                }
            }
            else if (value is IDictionary dictionary)
            {
                if(collectionFormat == "deepObject") {
                    foreach (DictionaryEntry entry in dictionary)
                    {
                        parameters.Add(name + "[" + entry.Key + "]", ParameterToString(entry.Value));
                    }
                }
                else {
                    foreach (DictionaryEntry entry in dictionary)
                    {
                        parameters.Add(entry.Key.ToString(), ParameterToString(entry.Value));
                    }
                }
            }
            else
            {
                parameters.Add(name, ParameterToString(value));
            }

            return parameters;
        }

        /// <summary>
        /// If parameter is DateTime, output in a formatted string (default ISO 8601), customizable with Configuration.DateTime.
        /// If parameter is a list, join the list with ",".
        /// Otherwise just return the string.
        /// </summary>
        /// <param name="obj">The parameter (header, path, query, form).</param>
        /// <param name="configuration">An optional configuration instance, providing formatting options used in processing.</param>
        /// <returns>Formatted string.</returns>
        public static string ParameterToString(object obj, IReadableConfiguration configuration = null)
        {
            if (obj is DateTime dateTime)
                // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
                // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
                // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
                // For example: 2009-06-15T13:45:30.0000000
                return dateTime.ToString((configuration ?? GlobalConfiguration.Instance).DateTimeFormat);
            if (obj is DateTimeOffset dateTimeOffset)
                // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
                // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
                // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
                // For example: 2009-06-15T13:45:30.0000000
                return dateTimeOffset.ToString((configuration ?? GlobalConfiguration.Instance).DateTimeFormat);
            if (obj is bool boolean)
                return boolean ? "true" : "false";
            if (obj is ICollection collection)
                return string.Join(",", collection.Cast<object>());

            return Convert.ToString(obj, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Serializes the given object when not null. Otherwise return null.
        /// </summary>
        /// <param name="obj">The object to serialize.</param>
        /// <returns>Serialized string.</returns>
        public static string Serialize(object obj)
        {
            return obj != null ? Newtonsoft.Json.JsonConvert.SerializeObject(obj) : null;
        }

        /// <summary>
        /// Encode string in base64 format.
        /// </summary>
        /// <param name="text">string to be encoded.</param>
        /// <returns>Encoded string.</returns>
        public static string Base64Encode(string text)
        {
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(text));
        }

        /// <summary>
        /// Convert stream to byte array
        /// </summary>
        /// <param name="inputStream">Input stream to be converted</param>
        /// <returns>Byte array</returns>
        public static byte[] ReadAsBytes(Stream inputStream)
        {
            using (var ms = new MemoryStream())
            {
                inputStream.CopyTo(ms);
                return ms.ToArray();
            }
        }

        /// <summary>
        /// Select the Content-Type header's value from the given content-type array:
        /// if JSON type exists in the given array, use it;
        /// otherwise use the first one defined in 'consumes'
        /// </summary>
        /// <param name="contentTypes">The Content-Type array to select from.</param>
        /// <returns>The Content-Type header to use.</returns>
        public static string SelectHeaderContentType(string[] contentTypes)
        {
            if (contentTypes.Length == 0)
                return null;

            foreach (var contentType in contentTypes)
            {
                if (IsJsonMime(contentType))
                    return contentType;
            }

            return contentTypes[0]; // use the first content type specified in 'consumes'
        }

        /// <summary>
        /// Select the Accept header's value from the given accepts array:
        /// if JSON exists in the given array, use it;
        /// otherwise use all of them (joining into a string)
        /// </summary>
        /// <param name="accepts">The accepts array to select from.</param>
        /// <returns>The Accept header to use.</returns>
        public static string SelectHeaderAccept(string[] accepts)
        {
            if (accepts.Length == 0)
                return null;

            if (accepts.Contains("application/json", StringComparer.OrdinalIgnoreCase))
                return "application/json";

            return string.Join(",", accepts);
        }

        /// <summary>
        /// Provides a case-insensitive check that a provided content type is a known JSON-like content type.
        /// </summary>
        public static readonly Regex JsonRegex = new Regex("(?i)^(application/json|[^;/ \t]+/[^;/ \t]+[+]json)[ \t]*(;.*)?$");

        /// <summary>
        /// Check if the given MIME is a JSON MIME.
        /// JSON MIME examples:
        ///    application/json
        ///    application/json; charset=UTF8
        ///    APPLICATION/JSON
        ///    application/vnd.company+json
        /// </summary>
        /// <param name="mime">MIME</param>
        /// <returns>Returns True if MIME type is json.</returns>
        public static bool IsJsonMime(string mime)
        {
            if (string.IsNullOrWhiteSpace(mime)) return false;

            return JsonRegex.IsMatch(mime) || mime.Equals("application/json-patch+json");
        }
    }
}