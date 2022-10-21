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
    /// AnimeForListAllOf
    /// </summary>
    [DataContract(Name = "AnimeForList_allOf")]
    public partial class AnimeForListAllOf : IEquatable<AnimeForListAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnimeForListAllOf" /> class.
        /// </summary>
        /// <param name="mediaType">- unknown - tv - ova - movie - special - ona - music .</param>
        /// <param name="status">Airing status.   - finished_airing - currently_airing - not_yet_aired .</param>
        /// <param name="myListStatus">myListStatus.</param>
        /// <param name="numEpisodes">The total number of episodes of this series. If unknown, it is 0. .</param>
        /// <param name="startSeason">startSeason.</param>
        /// <param name="broadcast">broadcast.</param>
        /// <param name="source">Original work.  - other - original - manga - 4_koma_manga - web_manga - digital_manga - novel - light_novel - visual_novel - game - card_game - book - picture_book - radio - music .</param>
        /// <param name="averageEpisodeDuration">Average length of episode in seconds. .</param>
        /// <param name="rating">| Value | Description | | - -- - | - -- - | | g | G - All Ages | | pg | PG - Children | | pg_13 | pg_13 - Teens 13 and Older | | r | R - 17+ (violence &amp; profanity) | | r+ | R+ - Profanity &amp; Mild Nudity | | rx | Rx - Hentai | .</param>
        /// <param name="studios">studios.</param>
        public AnimeForListAllOf(string mediaType = default(string), string status = default(string), Object myListStatus = default(Object), int numEpisodes = default(int), Object startSeason = default(Object), AnimeForListAllOfBroadcast broadcast = default(AnimeForListAllOfBroadcast), string source = default(string), int? averageEpisodeDuration = default(int?), string rating = default(string), List<AnimeStudio> studios = default(List<AnimeStudio>))
        {
            this.MediaType = mediaType;
            this.Status = status;
            this.MyListStatus = myListStatus;
            this.NumEpisodes = numEpisodes;
            this.StartSeason = startSeason;
            this.Broadcast = broadcast;
            this.Source = source;
            this.AverageEpisodeDuration = averageEpisodeDuration;
            this.Rating = rating;
            this.Studios = studios;
        }

        /// <summary>
        /// - unknown - tv - ova - movie - special - ona - music 
        /// </summary>
        /// <value>- unknown - tv - ova - movie - special - ona - music </value>
        [DataMember(Name = "media_type", EmitDefaultValue = false)]
        public string MediaType { get; set; }

        /// <summary>
        /// Airing status.   - finished_airing - currently_airing - not_yet_aired 
        /// </summary>
        /// <value>Airing status.   - finished_airing - currently_airing - not_yet_aired </value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets MyListStatus
        /// </summary>
        [DataMember(Name = "my_list_status", EmitDefaultValue = false)]
        public Object MyListStatus { get; set; }

        /// <summary>
        /// The total number of episodes of this series. If unknown, it is 0. 
        /// </summary>
        /// <value>The total number of episodes of this series. If unknown, it is 0. </value>
        [DataMember(Name = "num_episodes", EmitDefaultValue = false)]
        public int NumEpisodes { get; set; }

        /// <summary>
        /// Gets or Sets StartSeason
        /// </summary>
        [DataMember(Name = "start_season", EmitDefaultValue = false)]
        public Object StartSeason { get; set; }

        /// <summary>
        /// Gets or Sets Broadcast
        /// </summary>
        [DataMember(Name = "broadcast", EmitDefaultValue = true)]
        public AnimeForListAllOfBroadcast Broadcast { get; set; }

        /// <summary>
        /// Original work.  - other - original - manga - 4_koma_manga - web_manga - digital_manga - novel - light_novel - visual_novel - game - card_game - book - picture_book - radio - music 
        /// </summary>
        /// <value>Original work.  - other - original - manga - 4_koma_manga - web_manga - digital_manga - novel - light_novel - visual_novel - game - card_game - book - picture_book - radio - music </value>
        [DataMember(Name = "source", EmitDefaultValue = true)]
        public string Source { get; set; }

        /// <summary>
        /// Average length of episode in seconds. 
        /// </summary>
        /// <value>Average length of episode in seconds. </value>
        [DataMember(Name = "average_episode_duration", EmitDefaultValue = true)]
        public int? AverageEpisodeDuration { get; set; }

        /// <summary>
        /// | Value | Description | | - -- - | - -- - | | g | G - All Ages | | pg | PG - Children | | pg_13 | pg_13 - Teens 13 and Older | | r | R - 17+ (violence &amp; profanity) | | r+ | R+ - Profanity &amp; Mild Nudity | | rx | Rx - Hentai | 
        /// </summary>
        /// <value>| Value | Description | | - -- - | - -- - | | g | G - All Ages | | pg | PG - Children | | pg_13 | pg_13 - Teens 13 and Older | | r | R - 17+ (violence &amp; profanity) | | r+ | R+ - Profanity &amp; Mild Nudity | | rx | Rx - Hentai | </value>
        [DataMember(Name = "rating", EmitDefaultValue = true)]
        public string Rating { get; set; }

        /// <summary>
        /// Gets or Sets Studios
        /// </summary>
        [DataMember(Name = "studios", EmitDefaultValue = false)]
        public List<AnimeStudio> Studios { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AnimeForListAllOf {\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  MyListStatus: ").Append(MyListStatus).Append("\n");
            sb.Append("  NumEpisodes: ").Append(NumEpisodes).Append("\n");
            sb.Append("  StartSeason: ").Append(StartSeason).Append("\n");
            sb.Append("  Broadcast: ").Append(Broadcast).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  AverageEpisodeDuration: ").Append(AverageEpisodeDuration).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  Studios: ").Append(Studios).Append("\n");
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
            return this.Equals(input as AnimeForListAllOf);
        }

        /// <summary>
        /// Returns true if AnimeForListAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of AnimeForListAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnimeForListAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MediaType == input.MediaType ||
                    (this.MediaType != null &&
                    this.MediaType.Equals(input.MediaType))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.MyListStatus == input.MyListStatus ||
                    (this.MyListStatus != null &&
                    this.MyListStatus.Equals(input.MyListStatus))
                ) && 
                (
                    this.NumEpisodes == input.NumEpisodes ||
                    this.NumEpisodes.Equals(input.NumEpisodes)
                ) && 
                (
                    this.StartSeason == input.StartSeason ||
                    (this.StartSeason != null &&
                    this.StartSeason.Equals(input.StartSeason))
                ) && 
                (
                    this.Broadcast == input.Broadcast ||
                    (this.Broadcast != null &&
                    this.Broadcast.Equals(input.Broadcast))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.AverageEpisodeDuration == input.AverageEpisodeDuration ||
                    (this.AverageEpisodeDuration != null &&
                    this.AverageEpisodeDuration.Equals(input.AverageEpisodeDuration))
                ) && 
                (
                    this.Rating == input.Rating ||
                    (this.Rating != null &&
                    this.Rating.Equals(input.Rating))
                ) && 
                (
                    this.Studios == input.Studios ||
                    this.Studios != null &&
                    input.Studios != null &&
                    this.Studios.SequenceEqual(input.Studios)
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
                if (this.MediaType != null)
                {
                    hashCode = (hashCode * 59) + this.MediaType.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.MyListStatus != null)
                {
                    hashCode = (hashCode * 59) + this.MyListStatus.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NumEpisodes.GetHashCode();
                if (this.StartSeason != null)
                {
                    hashCode = (hashCode * 59) + this.StartSeason.GetHashCode();
                }
                if (this.Broadcast != null)
                {
                    hashCode = (hashCode * 59) + this.Broadcast.GetHashCode();
                }
                if (this.Source != null)
                {
                    hashCode = (hashCode * 59) + this.Source.GetHashCode();
                }
                if (this.AverageEpisodeDuration != null)
                {
                    hashCode = (hashCode * 59) + this.AverageEpisodeDuration.GetHashCode();
                }
                if (this.Rating != null)
                {
                    hashCode = (hashCode * 59) + this.Rating.GetHashCode();
                }
                if (this.Studios != null)
                {
                    hashCode = (hashCode * 59) + this.Studios.GetHashCode();
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