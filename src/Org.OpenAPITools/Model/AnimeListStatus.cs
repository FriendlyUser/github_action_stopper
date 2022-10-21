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
    /// AnimeListStatus
    /// </summary>
    [DataContract(Name = "AnimeListStatus")]
    public partial class AnimeListStatus : IEquatable<AnimeListStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnimeListStatus" /> class.
        /// </summary>
        /// <param name="status">- watching - completed - on_hold - dropped - plan_to_watch .</param>
        /// <param name="score">0-10 .</param>
        /// <param name="numEpisodesWatched">0 or the number of watched episodes.  .</param>
        /// <param name="isRewatching">If authorized user watches an anime again after completion, this field value is true.  In this case, MyAnimeList treats the anime as &#39;watching&#39; in the user&#39;s anime list. .</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="finishDate">finishDate.</param>
        /// <param name="priority">priority.</param>
        /// <param name="numTimesRewatched">numTimesRewatched.</param>
        /// <param name="rewatchValue">rewatchValue.</param>
        /// <param name="tags">tags.</param>
        /// <param name="comments">You cannot contain this field in a list. .</param>
        /// <param name="updatedAt">updatedAt.</param>
        public AnimeListStatus(string status = default(string), int score = default(int), int numEpisodesWatched = default(int), bool isRewatching = default(bool), DateTime? startDate = default(DateTime?), DateTime? finishDate = default(DateTime?), int priority = default(int), int numTimesRewatched = default(int), int rewatchValue = default(int), List<string> tags = default(List<string>), string comments = default(string), DateTime updatedAt = default(DateTime))
        {
            this.Status = status;
            this.Score = score;
            this.NumEpisodesWatched = numEpisodesWatched;
            this.IsRewatching = isRewatching;
            this.StartDate = startDate;
            this.FinishDate = finishDate;
            this.Priority = priority;
            this.NumTimesRewatched = numTimesRewatched;
            this.RewatchValue = rewatchValue;
            this.Tags = tags;
            this.Comments = comments;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// - watching - completed - on_hold - dropped - plan_to_watch 
        /// </summary>
        /// <value>- watching - completed - on_hold - dropped - plan_to_watch </value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// 0-10 
        /// </summary>
        /// <value>0-10 </value>
        [DataMember(Name = "score", EmitDefaultValue = false)]
        public int Score { get; set; }

        /// <summary>
        /// 0 or the number of watched episodes.  
        /// </summary>
        /// <value>0 or the number of watched episodes.  </value>
        [DataMember(Name = "num_episodes_watched", EmitDefaultValue = false)]
        public int NumEpisodesWatched { get; set; }

        /// <summary>
        /// If authorized user watches an anime again after completion, this field value is true.  In this case, MyAnimeList treats the anime as &#39;watching&#39; in the user&#39;s anime list. 
        /// </summary>
        /// <value>If authorized user watches an anime again after completion, this field value is true.  In this case, MyAnimeList treats the anime as &#39;watching&#39; in the user&#39;s anime list. </value>
        [DataMember(Name = "is_rewatching", EmitDefaultValue = true)]
        public bool IsRewatching { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "start_date", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets FinishDate
        /// </summary>
        [DataMember(Name = "finish_date", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? FinishDate { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "priority", EmitDefaultValue = false)]
        public int Priority { get; set; }

        /// <summary>
        /// Gets or Sets NumTimesRewatched
        /// </summary>
        [DataMember(Name = "num_times_rewatched", EmitDefaultValue = false)]
        public int NumTimesRewatched { get; set; }

        /// <summary>
        /// Gets or Sets RewatchValue
        /// </summary>
        [DataMember(Name = "rewatch_value", EmitDefaultValue = false)]
        public int RewatchValue { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// You cannot contain this field in a list. 
        /// </summary>
        /// <value>You cannot contain this field in a list. </value>
        [DataMember(Name = "comments", EmitDefaultValue = false)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AnimeListStatus {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  NumEpisodesWatched: ").Append(NumEpisodesWatched).Append("\n");
            sb.Append("  IsRewatching: ").Append(IsRewatching).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  FinishDate: ").Append(FinishDate).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  NumTimesRewatched: ").Append(NumTimesRewatched).Append("\n");
            sb.Append("  RewatchValue: ").Append(RewatchValue).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as AnimeListStatus);
        }

        /// <summary>
        /// Returns true if AnimeListStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of AnimeListStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnimeListStatus input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Score == input.Score ||
                    this.Score.Equals(input.Score)
                ) && 
                (
                    this.NumEpisodesWatched == input.NumEpisodesWatched ||
                    this.NumEpisodesWatched.Equals(input.NumEpisodesWatched)
                ) && 
                (
                    this.IsRewatching == input.IsRewatching ||
                    this.IsRewatching.Equals(input.IsRewatching)
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.FinishDate == input.FinishDate ||
                    (this.FinishDate != null &&
                    this.FinishDate.Equals(input.FinishDate))
                ) && 
                (
                    this.Priority == input.Priority ||
                    this.Priority.Equals(input.Priority)
                ) && 
                (
                    this.NumTimesRewatched == input.NumTimesRewatched ||
                    this.NumTimesRewatched.Equals(input.NumTimesRewatched)
                ) && 
                (
                    this.RewatchValue == input.RewatchValue ||
                    this.RewatchValue.Equals(input.RewatchValue)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Score.GetHashCode();
                hashCode = (hashCode * 59) + this.NumEpisodesWatched.GetHashCode();
                hashCode = (hashCode * 59) + this.IsRewatching.GetHashCode();
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.FinishDate != null)
                {
                    hashCode = (hashCode * 59) + this.FinishDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Priority.GetHashCode();
                hashCode = (hashCode * 59) + this.NumTimesRewatched.GetHashCode();
                hashCode = (hashCode * 59) + this.RewatchValue.GetHashCode();
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.Comments != null)
                {
                    hashCode = (hashCode * 59) + this.Comments.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
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
