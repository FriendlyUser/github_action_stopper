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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Broadcast date. 
    /// </summary>
    [DataContract(Name = "AnimeForList_allOf_broadcast")]
    public partial class AnimeForListAllOfBroadcast : IEquatable<AnimeForListAllOfBroadcast>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnimeForListAllOfBroadcast" /> class.
        /// </summary>
        /// <param name="dayOfTheWeek">Day of the week broadcast in Japan time.  Day of the week or &#x60;other&#x60; .</param>
        /// <param name="startTime">for example: \&quot;01:25\&quot; .</param>
        public AnimeForListAllOfBroadcast(string dayOfTheWeek = default(string), string startTime = default(string))
        {
            this.DayOfTheWeek = dayOfTheWeek;
            this.StartTime = startTime;
        }

        /// <summary>
        /// Day of the week broadcast in Japan time.  Day of the week or &#x60;other&#x60; 
        /// </summary>
        /// <value>Day of the week broadcast in Japan time.  Day of the week or &#x60;other&#x60; </value>
        [DataMember(Name = "day_of_the_week", EmitDefaultValue = false)]
        public string DayOfTheWeek { get; set; }

        /// <summary>
        /// for example: \&quot;01:25\&quot; 
        /// </summary>
        /// <value>for example: \&quot;01:25\&quot; </value>
        [DataMember(Name = "start_time", EmitDefaultValue = true)]
        public string StartTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AnimeForListAllOfBroadcast {\n");
            sb.Append("  DayOfTheWeek: ").Append(DayOfTheWeek).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AnimeForListAllOfBroadcast);
        }

        /// <summary>
        /// Returns true if AnimeForListAllOfBroadcast instances are equal
        /// </summary>
        /// <param name="input">Instance of AnimeForListAllOfBroadcast to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnimeForListAllOfBroadcast input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DayOfTheWeek == input.DayOfTheWeek ||
                    (this.DayOfTheWeek != null &&
                    this.DayOfTheWeek.Equals(input.DayOfTheWeek))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DayOfTheWeek != null)
                {
                    hashCode = (hashCode * 59) + this.DayOfTheWeek.GetHashCode();
                }
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
