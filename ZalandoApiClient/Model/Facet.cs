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
    /// Zalando API Facet Schema
    /// </summary>
    [DataContract]
    public partial class Facet :  IEquatable<Facet>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Facet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Facet() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Facet" /> class.
        /// </summary>
        /// <param name="Filter">Filter (required).</param>
        /// <param name="Facets">list of the calculated article counts for each filter value (required).</param>
        public Facet(string Filter = null, List<FacetValue> Facets = null)
        {
            // to ensure "Filter" is required (not null)
            if (Filter == null)
            {
                throw new InvalidDataException("Filter is a required property for Facet and cannot be null");
            }
            else
            {
                this.Filter = Filter;
            }
            // to ensure "Facets" is required (not null)
            if (Facets == null)
            {
                throw new InvalidDataException("Facets is a required property for Facet and cannot be null");
            }
            else
            {
                this.Facets = Facets;
            }
        }
        
        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name="filter", EmitDefaultValue=false)]
        public string Filter { get; set; }
        /// <summary>
        /// list of the calculated article counts for each filter value
        /// </summary>
        /// <value>list of the calculated article counts for each filter value</value>
        [DataMember(Name="facets", EmitDefaultValue=false)]
        public List<FacetValue> Facets { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Facet {\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Facets: ").Append(Facets).Append("\n");
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
            return this.Equals(obj as Facet);
        }

        /// <summary>
        /// Returns true if Facet instances are equal
        /// </summary>
        /// <param name="other">Instance of Facet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Facet other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Filter == other.Filter ||
                    this.Filter != null &&
                    this.Filter.Equals(other.Filter)
                ) && 
                (
                    this.Facets == other.Facets ||
                    this.Facets != null &&
                    this.Facets.SequenceEqual(other.Facets)
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
                if (this.Filter != null)
                    hash = hash * 59 + this.Filter.GetHashCode();
                if (this.Facets != null)
                    hash = hash * 59 + this.Facets.GetHashCode();
                return hash;
            }
        }
    }

}
