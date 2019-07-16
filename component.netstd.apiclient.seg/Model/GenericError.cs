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
    /// GenericError
    /// </summary>
    [DataContract]
    public partial class GenericError :  IEquatable<GenericError>
    {
        /// <summary>
        /// Defines MessageType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MessageTypeEnum
        {
            
            /// <summary>
            /// Enum Information for value: Information
            /// </summary>
            [EnumMember(Value = "Information")]
            Information = 1,
            
            /// <summary>
            /// Enum Warning for value: Warning
            /// </summary>
            [EnumMember(Value = "Warning")]
            Warning = 2,
            
            /// <summary>
            /// Enum Error for value: Error
            /// </summary>
            [EnumMember(Value = "Error")]
            Error = 3,
            
            /// <summary>
            /// Enum AccountTypeRestriction for value: AccountTypeRestriction
            /// </summary>
            [EnumMember(Value = "AccountTypeRestriction")]
            AccountTypeRestriction = 4,
            
            /// <summary>
            /// Enum Success for value: Success
            /// </summary>
            [EnumMember(Value = "Success")]
            Success = 5,
            
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 6
        }

        /// <summary>
        /// Gets or Sets MessageType
        /// </summary>
        [DataMember(Name="messageType", EmitDefaultValue=false)]
        public MessageTypeEnum? MessageType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericError" /> class.
        /// </summary>
        /// <param name="uniqueErrorId">uniqueErrorId.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="message">message.</param>
        /// <param name="messageType">messageType.</param>
        public GenericError(string uniqueErrorId = default(string), string errorCode = default(string), string message = default(string), MessageTypeEnum? messageType = default(MessageTypeEnum?))
        {
            this.UniqueErrorId = uniqueErrorId;
            this.ErrorCode = errorCode;
            this.Message = message;
            this.MessageType = messageType;
        }
        
        /// <summary>
        /// Gets or Sets UniqueErrorId
        /// </summary>
        [DataMember(Name="uniqueErrorId", EmitDefaultValue=false)]
        public string UniqueErrorId { get; set; }

        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GenericError {\n");
            sb.Append("  UniqueErrorId: ").Append(UniqueErrorId).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
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
            return this.Equals(input as GenericError);
        }

        /// <summary>
        /// Returns true if GenericError instances are equal
        /// </summary>
        /// <param name="input">Instance of GenericError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenericError input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UniqueErrorId == input.UniqueErrorId ||
                    (this.UniqueErrorId != null &&
                    this.UniqueErrorId.Equals(input.UniqueErrorId))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.MessageType == input.MessageType ||
                    (this.MessageType != null &&
                    this.MessageType.Equals(input.MessageType))
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
                if (this.UniqueErrorId != null)
                    hashCode = hashCode * 59 + this.UniqueErrorId.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.MessageType != null)
                    hashCode = hashCode * 59 + this.MessageType.GetHashCode();
                return hashCode;
            }
        }
    }

}
