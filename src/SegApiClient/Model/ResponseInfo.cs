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
using SwaggerDateConverter = SegApiClient.Client.SwaggerDateConverter;

namespace SegApiClient.Model
{
    /// <summary>
    /// ResponseInfo
    /// </summary>
    [DataContract]
    public partial class ResponseInfo :  IEquatable<ResponseInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseInfo" /> class.
        /// </summary>
        /// <param name="responseId">responseId.</param>
        /// <param name="additionalValues">additionalValues.</param>
        /// <param name="messages">messages.</param>
        public ResponseInfo(string responseId = default(string), List<KeyValuePairStringString> additionalValues = default(List<KeyValuePairStringString>), List<MessageInfo> messages = default(List<MessageInfo>))
        {
            this.ResponseId = responseId;
            this.AdditionalValues = additionalValues;
            this.Messages = messages;
        }
        
        /// <summary>
        /// Gets or Sets ResponseId
        /// </summary>
        [DataMember(Name="responseId", EmitDefaultValue=false)]
        public string ResponseId { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalValues
        /// </summary>
        [DataMember(Name="additionalValues", EmitDefaultValue=false)]
        public List<KeyValuePairStringString> AdditionalValues { get; set; }

        /// <summary>
        /// Gets or Sets Messages
        /// </summary>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public List<MessageInfo> Messages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseInfo {\n");
            sb.Append("  ResponseId: ").Append(ResponseId).Append("\n");
            sb.Append("  AdditionalValues: ").Append(AdditionalValues).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
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
            return this.Equals(input as ResponseInfo);
        }

        /// <summary>
        /// Returns true if ResponseInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ResponseInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResponseId == input.ResponseId ||
                    (this.ResponseId != null &&
                    this.ResponseId.Equals(input.ResponseId))
                ) && 
                (
                    this.AdditionalValues == input.AdditionalValues ||
                    this.AdditionalValues != null &&
                    this.AdditionalValues.SequenceEqual(input.AdditionalValues)
                ) && 
                (
                    this.Messages == input.Messages ||
                    this.Messages != null &&
                    this.Messages.SequenceEqual(input.Messages)
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
                if (this.ResponseId != null)
                    hashCode = hashCode * 59 + this.ResponseId.GetHashCode();
                if (this.AdditionalValues != null)
                    hashCode = hashCode * 59 + this.AdditionalValues.GetHashCode();
                if (this.Messages != null)
                    hashCode = hashCode * 59 + this.Messages.GetHashCode();
                return hashCode;
            }
        }
    }

}