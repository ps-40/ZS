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
    /// Zalando API Article Schema
    /// </summary>
    [DataContract]
    public partial class Article :  IEquatable<Article>
    {
        /// <summary>
        /// collection season the article belongs to
        /// </summary>
        /// <value>collection season the article belongs to</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SeasonEnum
        {
            
            /// <summary>
            /// Enum SUMMER for "SUMMER"
            /// </summary>
            [EnumMember(Value = "SUMMER")]
            SUMMER,
            
            /// <summary>
            /// Enum WINTER for "WINTER"
            /// </summary>
            [EnumMember(Value = "WINTER")]
            WINTER,
            
            /// <summary>
            /// Enum ALL for "ALL"
            /// </summary>
            [EnumMember(Value = "ALL")]
            ALL
        }


        /// <summary>
        /// Gets or Sets Genders
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GendersEnum
        {
            
            /// <summary>
            /// Enum MALE for "MALE"
            /// </summary>
            [EnumMember(Value = "MALE")]
            MALE,
            
            /// <summary>
            /// Enum FEMALE for "FEMALE"
            /// </summary>
            [EnumMember(Value = "FEMALE")]
            FEMALE
        }


        /// <summary>
        /// Gets or Sets AgeGroups
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AgeGroupsEnum
        {
            
            /// <summary>
            /// Enum BABY for "BABY"
            /// </summary>
            [EnumMember(Value = "BABY")]
            BABY,
            
            /// <summary>
            /// Enum CHILD for "CHILD"
            /// </summary>
            [EnumMember(Value = "CHILD")]
            CHILD,
            
            /// <summary>
            /// Enum TEEN for "TEEN"
            /// </summary>
            [EnumMember(Value = "TEEN")]
            TEEN,
            
            /// <summary>
            /// Enum ADULT for "ADULT"
            /// </summary>
            [EnumMember(Value = "ADULT")]
            ADULT
        }

        /// <summary>
        /// collection season the article belongs to
        /// </summary>
        /// <value>collection season the article belongs to</value>
        [DataMember(Name="season", EmitDefaultValue=false)]
        public SeasonEnum? Season { get; set; }
        /// <summary>
        /// gender of the article belongs to
        /// </summary>
        /// <value>gender of the article belongs to</value>
        [DataMember(Name="genders", EmitDefaultValue=false)]
        public List<GendersEnum> Genders { get; set; }
        /// <summary>
        /// age group of the article belongs to
        /// </summary>
        /// <value>age group of the article belongs to</value>
        [DataMember(Name="ageGroups", EmitDefaultValue=false)]
        public List<AgeGroupsEnum> AgeGroups { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Article" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Article() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Article" /> class.
        /// </summary>
        /// <param name="Id">unique article id (required).</param>
        /// <param name="ModelId">unique article model id (required).</param>
        /// <param name="Name">article name (required).</param>
        /// <param name="ShopUrl">url of the article within the Zalando webshop (required).</param>
        /// <param name="Color">the main color of the article (required).</param>
        /// <param name="Available">will be true if at least one article unit is available (required).</param>
        /// <param name="Season">collection season the article belongs to (required).</param>
        /// <param name="SeasonYear">collection year the article belongs to. Could be either a year or &#39;ALL&#39; (required).</param>
        /// <param name="ActivationDate">timestamp the article was available in the Zalando webshop (required).</param>
        /// <param name="AdditionalInfos">any additional information of the article  (required).</param>
        /// <param name="Genders">gender of the article belongs to (required).</param>
        /// <param name="AgeGroups">age group of the article belongs to (required).</param>
        /// <param name="Brand">Brand (required).</param>
        /// <param name="CategoryKeys">category keys of the article belongs to (required).</param>
        /// <param name="Attributes">article attributes (required).</param>
        /// <param name="Units">price of the article (required).</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="Media">Media (required).</param>
        public Article(string Id = null, string ModelId = null, string Name = null, string ShopUrl = null, string Color = null, bool? Available = null, SeasonEnum? Season = null, string SeasonYear = null, DateTime? ActivationDate = null, List<string> AdditionalInfos = null, List<GendersEnum> Genders = null, List<AgeGroupsEnum> AgeGroups = null, Brand Brand = null, List<string> CategoryKeys = null, List<ArticleAttribute> Attributes = null, List<ArticleUnit> Units = null, List<string> Tags = null, ArticleMedia Media = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for Article and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "ModelId" is required (not null)
            if (ModelId == null)
            {
                throw new InvalidDataException("ModelId is a required property for Article and cannot be null");
            }
            else
            {
                this.ModelId = ModelId;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for Article and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "ShopUrl" is required (not null)
            if (ShopUrl == null)
            {
                throw new InvalidDataException("ShopUrl is a required property for Article and cannot be null");
            }
            else
            {
                this.ShopUrl = ShopUrl;
            }
            // to ensure "Color" is required (not null)
            if (Color == null)
            {
                throw new InvalidDataException("Color is a required property for Article and cannot be null");
            }
            else
            {
                this.Color = Color;
            }
            // to ensure "Available" is required (not null)
            if (Available == null)
            {
                throw new InvalidDataException("Available is a required property for Article and cannot be null");
            }
            else
            {
                this.Available = Available;
            }
            // to ensure "Season" is required (not null)
            if (Season == null)
            {
                throw new InvalidDataException("Season is a required property for Article and cannot be null");
            }
            else
            {
                this.Season = Season;
            }
            // to ensure "SeasonYear" is required (not null)
            if (SeasonYear == null)
            {
                throw new InvalidDataException("SeasonYear is a required property for Article and cannot be null");
            }
            else
            {
                this.SeasonYear = SeasonYear;
            }
            // to ensure "ActivationDate" is required (not null)
            if (ActivationDate == null)
            {
                throw new InvalidDataException("ActivationDate is a required property for Article and cannot be null");
            }
            else
            {
                this.ActivationDate = ActivationDate;
            }
            // to ensure "AdditionalInfos" is required (not null)
            if (AdditionalInfos == null)
            {
                throw new InvalidDataException("AdditionalInfos is a required property for Article and cannot be null");
            }
            else
            {
                this.AdditionalInfos = AdditionalInfos;
            }
            // to ensure "Genders" is required (not null)
            if (Genders == null)
            {
                throw new InvalidDataException("Genders is a required property for Article and cannot be null");
            }
            else
            {
                this.Genders = Genders;
            }
            // to ensure "AgeGroups" is required (not null)
            if (AgeGroups == null)
            {
                throw new InvalidDataException("AgeGroups is a required property for Article and cannot be null");
            }
            else
            {
                this.AgeGroups = AgeGroups;
            }
            // to ensure "Brand" is required (not null)
            if (Brand == null)
            {
                throw new InvalidDataException("Brand is a required property for Article and cannot be null");
            }
            else
            {
                this.Brand = Brand;
            }
            // to ensure "CategoryKeys" is required (not null)
            if (CategoryKeys == null)
            {
                throw new InvalidDataException("CategoryKeys is a required property for Article and cannot be null");
            }
            else
            {
                this.CategoryKeys = CategoryKeys;
            }
            // to ensure "Attributes" is required (not null)
            if (Attributes == null)
            {
                throw new InvalidDataException("Attributes is a required property for Article and cannot be null");
            }
            else
            {
                this.Attributes = Attributes;
            }
            // to ensure "Units" is required (not null)
            if (Units == null)
            {
                throw new InvalidDataException("Units is a required property for Article and cannot be null");
            }
            else
            {
                this.Units = Units;
            }
            // to ensure "Media" is required (not null)
            if (Media == null)
            {
                throw new InvalidDataException("Media is a required property for Article and cannot be null");
            }
            else
            {
                this.Media = Media;
            }
            this.Tags = Tags;
        }
        
        /// <summary>
        /// unique article id
        /// </summary>
        /// <value>unique article id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// unique article model id
        /// </summary>
        /// <value>unique article model id</value>
        [DataMember(Name="modelId", EmitDefaultValue=false)]
        public string ModelId { get; set; }
        /// <summary>
        /// article name
        /// </summary>
        /// <value>article name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// url of the article within the Zalando webshop
        /// </summary>
        /// <value>url of the article within the Zalando webshop</value>
        [DataMember(Name="shopUrl", EmitDefaultValue=false)]
        public string ShopUrl { get; set; }
        /// <summary>
        /// the main color of the article
        /// </summary>
        /// <value>the main color of the article</value>
        [DataMember(Name="color", EmitDefaultValue=false)]
        public string Color { get; set; }
        /// <summary>
        /// will be true if at least one article unit is available
        /// </summary>
        /// <value>will be true if at least one article unit is available</value>
        [DataMember(Name="available", EmitDefaultValue=false)]
        public bool? Available { get; set; }
        /// <summary>
        /// collection year the article belongs to. Could be either a year or &#39;ALL&#39;
        /// </summary>
        /// <value>collection year the article belongs to. Could be either a year or &#39;ALL&#39;</value>
        [DataMember(Name="seasonYear", EmitDefaultValue=false)]
        public string SeasonYear { get; set; }
        /// <summary>
        /// timestamp the article was available in the Zalando webshop
        /// </summary>
        /// <value>timestamp the article was available in the Zalando webshop</value>
        [DataMember(Name="activationDate", EmitDefaultValue=false)]
        public DateTime? ActivationDate { get; set; }
        /// <summary>
        /// any additional information of the article 
        /// </summary>
        /// <value>any additional information of the article </value>
        [DataMember(Name="additionalInfos", EmitDefaultValue=false)]
        public List<string> AdditionalInfos { get; set; }
        /// <summary>
        /// Gets or Sets Brand
        /// </summary>
        [DataMember(Name="brand", EmitDefaultValue=false)]
        public Brand Brand { get; set; }
        /// <summary>
        /// category keys of the article belongs to
        /// </summary>
        /// <value>category keys of the article belongs to</value>
        [DataMember(Name="categoryKeys", EmitDefaultValue=false)]
        public List<string> CategoryKeys { get; set; }
        /// <summary>
        /// article attributes
        /// </summary>
        /// <value>article attributes</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public List<ArticleAttribute> Attributes { get; set; }
        /// <summary>
        /// price of the article
        /// </summary>
        /// <value>price of the article</value>
        [DataMember(Name="units", EmitDefaultValue=false)]
        public List<ArticleUnit> Units { get; set; }
        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }
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
            sb.Append("class Article {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ModelId: ").Append(ModelId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ShopUrl: ").Append(ShopUrl).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Available: ").Append(Available).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  SeasonYear: ").Append(SeasonYear).Append("\n");
            sb.Append("  ActivationDate: ").Append(ActivationDate).Append("\n");
            sb.Append("  AdditionalInfos: ").Append(AdditionalInfos).Append("\n");
            sb.Append("  Genders: ").Append(Genders).Append("\n");
            sb.Append("  AgeGroups: ").Append(AgeGroups).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  CategoryKeys: ").Append(CategoryKeys).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return this.Equals(obj as Article);
        }

        /// <summary>
        /// Returns true if Article instances are equal
        /// </summary>
        /// <param name="other">Instance of Article to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Article other)
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
                    this.Color == other.Color ||
                    this.Color != null &&
                    this.Color.Equals(other.Color)
                ) && 
                (
                    this.Available == other.Available ||
                    this.Available != null &&
                    this.Available.Equals(other.Available)
                ) && 
                (
                    this.Season == other.Season ||
                    this.Season != null &&
                    this.Season.Equals(other.Season)
                ) && 
                (
                    this.SeasonYear == other.SeasonYear ||
                    this.SeasonYear != null &&
                    this.SeasonYear.Equals(other.SeasonYear)
                ) && 
                (
                    this.ActivationDate == other.ActivationDate ||
                    this.ActivationDate != null &&
                    this.ActivationDate.Equals(other.ActivationDate)
                ) && 
                (
                    this.AdditionalInfos == other.AdditionalInfos ||
                    this.AdditionalInfos != null &&
                    this.AdditionalInfos.SequenceEqual(other.AdditionalInfos)
                ) && 
                (
                    this.Genders == other.Genders ||
                    this.Genders != null &&
                    this.Genders.SequenceEqual(other.Genders)
                ) && 
                (
                    this.AgeGroups == other.AgeGroups ||
                    this.AgeGroups != null &&
                    this.AgeGroups.SequenceEqual(other.AgeGroups)
                ) && 
                (
                    this.Brand == other.Brand ||
                    this.Brand != null &&
                    this.Brand.Equals(other.Brand)
                ) && 
                (
                    this.CategoryKeys == other.CategoryKeys ||
                    this.CategoryKeys != null &&
                    this.CategoryKeys.SequenceEqual(other.CategoryKeys)
                ) && 
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(other.Attributes)
                ) && 
                (
                    this.Units == other.Units ||
                    this.Units != null &&
                    this.Units.SequenceEqual(other.Units)
                ) && 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
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
                if (this.Color != null)
                    hash = hash * 59 + this.Color.GetHashCode();
                if (this.Available != null)
                    hash = hash * 59 + this.Available.GetHashCode();
                if (this.Season != null)
                    hash = hash * 59 + this.Season.GetHashCode();
                if (this.SeasonYear != null)
                    hash = hash * 59 + this.SeasonYear.GetHashCode();
                if (this.ActivationDate != null)
                    hash = hash * 59 + this.ActivationDate.GetHashCode();
                if (this.AdditionalInfos != null)
                    hash = hash * 59 + this.AdditionalInfos.GetHashCode();
                if (this.Genders != null)
                    hash = hash * 59 + this.Genders.GetHashCode();
                if (this.AgeGroups != null)
                    hash = hash * 59 + this.AgeGroups.GetHashCode();
                if (this.Brand != null)
                    hash = hash * 59 + this.Brand.GetHashCode();
                if (this.CategoryKeys != null)
                    hash = hash * 59 + this.CategoryKeys.GetHashCode();
                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();
                if (this.Units != null)
                    hash = hash * 59 + this.Units.GetHashCode();
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                if (this.Media != null)
                    hash = hash * 59 + this.Media.GetHashCode();
                return hash;
            }
        }
    }

}
