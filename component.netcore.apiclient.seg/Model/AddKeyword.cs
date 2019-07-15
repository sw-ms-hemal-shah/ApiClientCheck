/* 
 * Seg API
 *
 * Provide API for Manage Segs
 *
 * OpenAPI spec version: 1.0
 * Contact: vpatel@alliantcreditunion.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = component.netcore.apiclient.seg.Client.SwaggerDateConverter;

namespace component.netcore.apiclient.seg.Model
{
    /// <summary>
    /// AddKeyword
    /// </summary>
    [DataContract]
    public partial class AddKeyword :  IEquatable<AddKeyword>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddKeyword" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddKeyword() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddKeyword" /> class.
        /// </summary>
        /// <param name="keywordName">keywordName (required).</param>
        /// <param name="segKey">segKey (required).</param>
        public AddKeyword(string keywordName = default(string), Guid? segKey = default(Guid?))
        {
            // to ensure "keywordName" is required (not null)
            if (keywordName == null)
            {
                throw new InvalidDataException("keywordName is a required property for AddKeyword and cannot be null");
            }
            else
            {
                this.KeywordName = keywordName;
            }
            // to ensure "segKey" is required (not null)
            if (segKey == null)
            {
                throw new InvalidDataException("segKey is a required property for AddKeyword and cannot be null");
            }
            else
            {
                this.SegKey = segKey;
            }
        }
        
        /// <summary>
        /// Gets or Sets KeywordName
        /// </summary>
        [DataMember(Name="keywordName", EmitDefaultValue=false)]
        public string KeywordName { get; set; }

        /// <summary>
        /// Gets or Sets SegKey
        /// </summary>
        [DataMember(Name="segKey", EmitDefaultValue=false)]
        public Guid? SegKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddKeyword {\n");
            sb.Append("  KeywordName: ").Append(KeywordName).Append("\n");
            sb.Append("  SegKey: ").Append(SegKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddKeyword);
        }

        /// <summary>
        /// Returns true if AddKeyword instances are equal
        /// </summary>
        /// <param name="input">Instance of AddKeyword to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddKeyword input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeywordName == input.KeywordName ||
                    (this.KeywordName != null &&
                    this.KeywordName.Equals(input.KeywordName))
                ) && 
                (
                    this.SegKey == input.SegKey ||
                    (this.SegKey != null &&
                    this.SegKey.Equals(input.SegKey))
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
                if (this.KeywordName != null)
                    hashCode = hashCode * 59 + this.KeywordName.GetHashCode();
                if (this.SegKey != null)
                    hashCode = hashCode * 59 + this.SegKey.GetHashCode();
                return hashCode;
            }
        }
    }

}
