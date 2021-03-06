/* 
 * Zalando Shop API
 *
 * The shop API empowers developers to build amazing new apps or websites using Zalando shop data and services.
 *
 * OpenAPI spec version: v1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ZalandoApiClient.Model
{
    /// <summary>
    /// Zalando API Recommendation Article Schema
    /// </summary>
    [DataContract]
    public partial class RecommendationsArticle :  IEquatable<RecommendationsArticle>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendationsArticle" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RecommendationsArticle() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendationsArticle" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="ModelId">ModelId (required).</param>
        /// <param name="Name">Name (required).</param>
        /// <param name="ShopUrl">ShopUrl (required).</param>
        /// <param name="Media">Media (required).</param>
        public RecommendationsArticle(string Id = null, string ModelId = null, string Name = null, string ShopUrl = null, ArticleMedia Media = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for RecommendationsArticle and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "ModelId" is required (not null)
            if (ModelId == null)
            {
                throw new InvalidDataException("ModelId is a required property for RecommendationsArticle and cannot be null");
            }
            else
            {
                this.ModelId = ModelId;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for RecommendationsArticle and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "ShopUrl" is required (not null)
            if (ShopUrl == null)
            {
                throw new InvalidDataException("ShopUrl is a required property for RecommendationsArticle and cannot be null");
            }
            else
            {
                this.ShopUrl = ShopUrl;
            }
            // to ensure "Media" is required (not null)
            if (Media == null)
            {
                throw new InvalidDataException("Media is a required property for RecommendationsArticle and cannot be null");
            }
            else
            {
                this.Media = Media;
            }
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets ModelId
        /// </summary>
        [DataMember(Name="modelId", EmitDefaultValue=false)]
        public string ModelId { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets ShopUrl
        /// </summary>
        [DataMember(Name="shopUrl", EmitDefaultValue=false)]
        public string ShopUrl { get; set; }
        /// <summary>
        /// Gets or Sets Media
        /// </summary>
        [DataMember(Name="media", EmitDefaultValue=false)]
        public ArticleMedia Media { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecommendationsArticle {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ModelId: ").Append(ModelId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ShopUrl: ").Append(ShopUrl).Append("\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as RecommendationsArticle);
        }

        /// <summary>
        /// Returns true if RecommendationsArticle instances are equal
        /// </summary>
        /// <param name="other">Instance of RecommendationsArticle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecommendationsArticle other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.ModelId == other.ModelId ||
                    this.ModelId != null &&
                    this.ModelId.Equals(other.ModelId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.ShopUrl == other.ShopUrl ||
                    this.ShopUrl != null &&
                    this.ShopUrl.Equals(other.ShopUrl)
                ) && 
                (
                    this.Media == other.Media ||
                    this.Media != null &&
                    this.Media.Equals(other.Media)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.ModelId != null)
                    hash = hash * 59 + this.ModelId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.ShopUrl != null)
                    hash = hash * 59 + this.ShopUrl.GetHashCode();
                if (this.Media != null)
                    hash = hash * 59 + this.Media.GetHashCode();
                return hash;
            }
        }
    }

}
