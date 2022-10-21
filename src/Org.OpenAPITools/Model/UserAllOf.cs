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
    /// UserAllOf
    /// </summary>
    [DataContract(Name = "User_allOf")]
    public partial class UserAllOf : IEquatable<UserAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAllOf" /> class.
        /// </summary>
        /// <param name="gender">gender.</param>
        /// <param name="birthday">birthday.</param>
        /// <param name="location">location.</param>
        /// <param name="joinedAt">joinedAt.</param>
        /// <param name="animeStatistics">animeStatistics.</param>
        /// <param name="timeZone">for example: \&quot;America/Los_Angeles\&quot; .</param>
        /// <param name="isSupporter">isSupporter.</param>
        public UserAllOf(string gender = default(string), DateTime? birthday = default(DateTime?), string location = default(string), DateTime joinedAt = default(DateTime), UserAllOfAnimeStatistics animeStatistics = default(UserAllOfAnimeStatistics), string timeZone = default(string), bool? isSupporter = default(bool?))
        {
            this.Gender = gender;
            this.Birthday = birthday;
            this.Location = location;
            this.JoinedAt = joinedAt;
            this.AnimeStatistics = animeStatistics;
            this.TimeZone = timeZone;
            this.IsSupporter = isSupporter;
        }

        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [DataMember(Name = "gender", EmitDefaultValue = true)]
        public string Gender { get; set; }

        /// <summary>
        /// Gets or Sets Birthday
        /// </summary>
        [DataMember(Name = "birthday", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? Birthday { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = true)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets JoinedAt
        /// </summary>
        [DataMember(Name = "joined_at", EmitDefaultValue = false)]
        public DateTime JoinedAt { get; set; }

        /// <summary>
        /// Gets or Sets AnimeStatistics
        /// </summary>
        [DataMember(Name = "anime_statistics", EmitDefaultValue = true)]
        public UserAllOfAnimeStatistics AnimeStatistics { get; set; }

        /// <summary>
        /// for example: \&quot;America/Los_Angeles\&quot; 
        /// </summary>
        /// <value>for example: \&quot;America/Los_Angeles\&quot; </value>
        [DataMember(Name = "time_zone", EmitDefaultValue = true)]
        public string TimeZone { get; set; }

        /// <summary>
        /// Gets or Sets IsSupporter
        /// </summary>
        [DataMember(Name = "is_supporter", EmitDefaultValue = true)]
        public bool? IsSupporter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserAllOf {\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  Birthday: ").Append(Birthday).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  JoinedAt: ").Append(JoinedAt).Append("\n");
            sb.Append("  AnimeStatistics: ").Append(AnimeStatistics).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  IsSupporter: ").Append(IsSupporter).Append("\n");
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
            return this.Equals(input as UserAllOf);
        }

        /// <summary>
        /// Returns true if UserAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of UserAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Gender == input.Gender ||
                    (this.Gender != null &&
                    this.Gender.Equals(input.Gender))
                ) && 
                (
                    this.Birthday == input.Birthday ||
                    (this.Birthday != null &&
                    this.Birthday.Equals(input.Birthday))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.JoinedAt == input.JoinedAt ||
                    (this.JoinedAt != null &&
                    this.JoinedAt.Equals(input.JoinedAt))
                ) && 
                (
                    this.AnimeStatistics == input.AnimeStatistics ||
                    (this.AnimeStatistics != null &&
                    this.AnimeStatistics.Equals(input.AnimeStatistics))
                ) && 
                (
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
                ) && 
                (
                    this.IsSupporter == input.IsSupporter ||
                    (this.IsSupporter != null &&
                    this.IsSupporter.Equals(input.IsSupporter))
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
                if (this.Gender != null)
                {
                    hashCode = (hashCode * 59) + this.Gender.GetHashCode();
                }
                if (this.Birthday != null)
                {
                    hashCode = (hashCode * 59) + this.Birthday.GetHashCode();
                }
                if (this.Location != null)
                {
                    hashCode = (hashCode * 59) + this.Location.GetHashCode();
                }
                if (this.JoinedAt != null)
                {
                    hashCode = (hashCode * 59) + this.JoinedAt.GetHashCode();
                }
                if (this.AnimeStatistics != null)
                {
                    hashCode = (hashCode * 59) + this.AnimeStatistics.GetHashCode();
                }
                if (this.TimeZone != null)
                {
                    hashCode = (hashCode * 59) + this.TimeZone.GetHashCode();
                }
                if (this.IsSupporter != null)
                {
                    hashCode = (hashCode * 59) + this.IsSupporter.GetHashCode();
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
