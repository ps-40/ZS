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
    /// Zalando API Domain Schema
    /// </summary>
    [DataContract]
    public partial class Domain :  IEquatable<Domain>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Domain" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Domain() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Domain" /> class.
        /// </summary>
        /// <param name="LanguageCode">domain language (required).</param>
        /// <param name="CountryCode">domain country code (required).</param>
        /// <param name="CurrencyCode">domain currency code (required).</param>
        /// <param name="TaxRate">domain tax rate (required).</param>
        /// <param name="RootCategoryKey">domain root category (required).</param>
        /// <param name="ShopUrl">domain specific url (required).</param>
        public Domain(string LanguageCode = null, string CountryCode = null, string CurrencyCode = null, decimal? TaxRate = null, string RootCategoryKey = null, string ShopUrl = null)
        {
            // to ensure "LanguageCode" is required (not null)
            if (LanguageCode == null)
            {
                throw new InvalidDataException("LanguageCode is a required property for Domain and cannot be null");
            }
            else
            {
                this.LanguageCode = LanguageCode;
            }
            // to ensure "CountryCode" is required (not null)
            if (CountryCode == null)
            {
                throw new InvalidDataException("CountryCode is a required property for Domain and cannot be null");
            }
            else
            {
                this.CountryCode = CountryCode;
            }
            // to ensure "CurrencyCode" is required (not null)
            if (CurrencyCode == null)
            {
                throw new InvalidDataException("CurrencyCode is a required property for Domain and cannot be null");
            }
            else
            {
                this.CurrencyCode = CurrencyCode;
            }
            // to ensure "TaxRate" is required (not null)
            if (TaxRate == null)
            {
                throw new InvalidDataException("TaxRate is a required property for Domain and cannot be null");
            }
            else
            {
                this.TaxRate = TaxRate;
            }
            // to ensure "RootCategoryKey" is required (not null)
            if (RootCategoryKey == null)
            {
                throw new InvalidDataException("RootCategoryKey is a required property for Domain and cannot be null");
            }
            else
            {
                this.RootCategoryKey = RootCategoryKey;
            }
            // to ensure "ShopUrl" is required (not null)
            if (ShopUrl == null)
            {
                throw new InvalidDataException("ShopUrl is a required property for Domain and cannot be null");
            }
            else
            {
                this.ShopUrl = ShopUrl;
            }
        }
        
        /// <summary>
        /// domain language
        /// </summary>
        /// <value>domain language</value>
        [DataMember(Name="languageCode", EmitDefaultValue=false)]
        public string LanguageCode { get; set; }
        /// <summary>
        /// domain country code
        /// </summary>
        /// <value>domain country code</value>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }
        /// <summary>
        /// domain currency code
        /// </summary>
        /// <value>domain currency code</value>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }
        /// <summary>
        /// domain tax rate
        /// </summary>
        /// <value>domain tax rate</value>
        [DataMember(Name="taxRate", EmitDefaultValue=false)]
        public decimal? TaxRate { get; set; }
        /// <summary>
        /// domain root category
        /// </summary>
        /// <value>domain root category</value>
        [DataMember(Name="rootCategoryKey", EmitDefaultValue=false)]
        public string RootCategoryKey { get; set; }
        /// <summary>
        /// domain specific url
        /// </summary>
        /// <value>domain specific url</value>
        [DataMember(Name="shopUrl", EmitDefaultValue=false)]
        public string ShopUrl { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Domain {\n");
            sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
            sb.Append("  RootCategoryKey: ").Append(RootCategoryKey).Append("\n");
            sb.Append("  ShopUrl: ").Append(ShopUrl).Append("\n");
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
            return this.Equals(obj as Domain);
        }

        /// <summary>
        /// Returns true if Domain instances are equal
        /// </summary>
        /// <param name="other">Instance of Domain to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Domain other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LanguageCode == other.LanguageCode ||
                    this.LanguageCode != null &&
                    this.LanguageCode.Equals(other.LanguageCode)
                ) && 
                (
                    this.CountryCode == other.CountryCode ||
                    this.CountryCode != null &&
                    this.CountryCode.Equals(other.CountryCode)
                ) && 
                (
                    this.CurrencyCode == other.CurrencyCode ||
                    this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(other.CurrencyCode)
                ) && 
                (
                    this.TaxRate == other.TaxRate ||
                    this.TaxRate != null &&
                    this.TaxRate.Equals(other.TaxRate)
                ) && 
                (
                    this.RootCategoryKey == other.RootCategoryKey ||
                    this.RootCategoryKey != null &&
                    this.RootCategoryKey.Equals(other.RootCategoryKey)
                ) && 
                (
                    this.ShopUrl == other.ShopUrl ||
                    this.ShopUrl != null &&
                    this.ShopUrl.Equals(other.ShopUrl)
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
                if (this.LanguageCode != null)
                    hash = hash * 59 + this.LanguageCode.GetHashCode();
                if (this.CountryCode != null)
                    hash = hash * 59 + this.CountryCode.GetHashCode();
                if (this.CurrencyCode != null)
                    hash = hash * 59 + this.CurrencyCode.GetHashCode();
                if (this.TaxRate != null)
                    hash = hash * 59 + this.TaxRate.GetHashCode();
                if (this.RootCategoryKey != null)
                    hash = hash * 59 + this.RootCategoryKey.GetHashCode();
                if (this.ShopUrl != null)
                    hash = hash * 59 + this.ShopUrl.GetHashCode();
                return hash;
            }
        }
    }

}
