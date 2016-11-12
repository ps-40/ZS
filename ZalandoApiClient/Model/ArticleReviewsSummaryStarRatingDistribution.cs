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
    /// start rating distribution of the article
    /// </summary>
    [DataContract]
    public partial class ArticleReviewsSummaryStarRatingDistribution :  IEquatable<ArticleReviewsSummaryStarRatingDistribution>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArticleReviewsSummaryStarRatingDistribution" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ArticleReviewsSummaryStarRatingDistribution() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ArticleReviewsSummaryStarRatingDistribution" /> class.
        /// </summary>
        /// <param name="_1">_1 (required).</param>
        /// <param name="_2">_2 (required).</param>
        /// <param name="_3">_3 (required).</param>
        /// <param name="_4">_4 (required).</param>
        /// <param name="_5">_5 (required).</param>
        public ArticleReviewsSummaryStarRatingDistribution(int? _1 = null, int? _2 = null, int? _3 = null, int? _4 = null, int? _5 = null)
        {
            // to ensure "_1" is required (not null)
            if (_1 == null)
            {
                throw new InvalidDataException("_1 is a required property for ArticleReviewsSummaryStarRatingDistribution and cannot be null");
            }
            else
            {
                this._1 = _1;
            }
            // to ensure "_2" is required (not null)
            if (_2 == null)
            {
                throw new InvalidDataException("_2 is a required property for ArticleReviewsSummaryStarRatingDistribution and cannot be null");
            }
            else
            {
                this._2 = _2;
            }
            // to ensure "_3" is required (not null)
            if (_3 == null)
            {
                throw new InvalidDataException("_3 is a required property for ArticleReviewsSummaryStarRatingDistribution and cannot be null");
            }
            else
            {
                this._3 = _3;
            }
            // to ensure "_4" is required (not null)
            if (_4 == null)
            {
                throw new InvalidDataException("_4 is a required property for ArticleReviewsSummaryStarRatingDistribution and cannot be null");
            }
            else
            {
                this._4 = _4;
            }
            // to ensure "_5" is required (not null)
            if (_5 == null)
            {
                throw new InvalidDataException("_5 is a required property for ArticleReviewsSummaryStarRatingDistribution and cannot be null");
            }
            else
            {
                this._5 = _5;
            }
        }
        
        /// <summary>
        /// Gets or Sets _1
        /// </summary>
        [DataMember(Name="1", EmitDefaultValue=false)]
        public int? _1 { get; set; }
        /// <summary>
        /// Gets or Sets _2
        /// </summary>
        [DataMember(Name="2", EmitDefaultValue=false)]
        public int? _2 { get; set; }
        /// <summary>
        /// Gets or Sets _3
        /// </summary>
        [DataMember(Name="3", EmitDefaultValue=false)]
        public int? _3 { get; set; }
        /// <summary>
        /// Gets or Sets _4
        /// </summary>
        [DataMember(Name="4", EmitDefaultValue=false)]
        public int? _4 { get; set; }
        /// <summary>
        /// Gets or Sets _5
        /// </summary>
        [DataMember(Name="5", EmitDefaultValue=false)]
        public int? _5 { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArticleReviewsSummaryStarRatingDistribution {\n");
            sb.Append("  _1: ").Append(_1).Append("\n");
            sb.Append("  _2: ").Append(_2).Append("\n");
            sb.Append("  _3: ").Append(_3).Append("\n");
            sb.Append("  _4: ").Append(_4).Append("\n");
            sb.Append("  _5: ").Append(_5).Append("\n");
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
            return this.Equals(obj as ArticleReviewsSummaryStarRatingDistribution);
        }

        /// <summary>
        /// Returns true if ArticleReviewsSummaryStarRatingDistribution instances are equal
        /// </summary>
        /// <param name="other">Instance of ArticleReviewsSummaryStarRatingDistribution to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArticleReviewsSummaryStarRatingDistribution other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._1 == other._1 ||
                    this._1 != null &&
                    this._1.Equals(other._1)
                ) && 
                (
                    this._2 == other._2 ||
                    this._2 != null &&
                    this._2.Equals(other._2)
                ) && 
                (
                    this._3 == other._3 ||
                    this._3 != null &&
                    this._3.Equals(other._3)
                ) && 
                (
                    this._4 == other._4 ||
                    this._4 != null &&
                    this._4.Equals(other._4)
                ) && 
                (
                    this._5 == other._5 ||
                    this._5 != null &&
                    this._5.Equals(other._5)
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
                if (this._1 != null)
                    hash = hash * 59 + this._1.GetHashCode();
                if (this._2 != null)
                    hash = hash * 59 + this._2.GetHashCode();
                if (this._3 != null)
                    hash = hash * 59 + this._3.GetHashCode();
                if (this._4 != null)
                    hash = hash * 59 + this._4.GetHashCode();
                if (this._5 != null)
                    hash = hash * 59 + this._5.GetHashCode();
                return hash;
            }
        }
    }

}