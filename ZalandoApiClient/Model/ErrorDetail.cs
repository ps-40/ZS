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
    /// ErrorDetail
    /// </summary>
    [DataContract]
    public partial class ErrorDetail :  IEquatable<ErrorDetail>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorDetail" /> class.
        /// </summary>
        /// <param name="Key">Key.</param>
        /// <param name="Value">Value.</param>
        /// <param name="Name">Name.</param>
        /// <param name="InvalidName">InvalidName.</param>
        /// <param name="InvalidValues">InvalidValues.</param>
        public ErrorDetail(string Key = null, string Value = null, string Name = null, bool? InvalidName = null, List<string> InvalidValues = null)
        {
            this.Key = Key;
            this.Value = Value;
            this.Name = Name;
            this.InvalidName = InvalidName;
            this.InvalidValues = InvalidValues;
        }
        
        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets InvalidName
        /// </summary>
        [DataMember(Name="invalidName", EmitDefaultValue=false)]
        public bool? InvalidName { get; set; }
        /// <summary>
        /// Gets or Sets InvalidValues
        /// </summary>
        [DataMember(Name="invalidValues", EmitDefaultValue=false)]
        public List<string> InvalidValues { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorDetail {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  InvalidName: ").Append(InvalidName).Append("\n");
            sb.Append("  InvalidValues: ").Append(InvalidValues).Append("\n");
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
            return this.Equals(obj as ErrorDetail);
        }

        /// <summary>
        /// Returns true if ErrorDetail instances are equal
        /// </summary>
        /// <param name="other">Instance of ErrorDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorDetail other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.InvalidName == other.InvalidName ||
                    this.InvalidName != null &&
                    this.InvalidName.Equals(other.InvalidName)
                ) && 
                (
                    this.InvalidValues == other.InvalidValues ||
                    this.InvalidValues != null &&
                    this.InvalidValues.SequenceEqual(other.InvalidValues)
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
                if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.InvalidName != null)
                    hash = hash * 59 + this.InvalidName.GetHashCode();
                if (this.InvalidValues != null)
                    hash = hash * 59 + this.InvalidValues.GetHashCode();
                return hash;
            }
        }
    }

}
