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

namespace component.netcore.apiclient.seg.v1.Model
{
    /// <summary>
    /// SegStatus
    /// </summary>
    [DataContract]
    public partial class SegStatus :  IEquatable<SegStatus>
    {
        /// <summary>
        /// Allow valid Enum value.
        /// </summary>
        /// <value>Allow valid Enum value.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UpdateStatusEnum
        {
            
            /// <summary>
            /// Enum UnKnown for value: UnKnown
            /// </summary>
            [EnumMember(Value = "UnKnown")]
            UnKnown = 1,
            
            /// <summary>
            /// Enum Active for value: Active
            /// </summary>
            [EnumMember(Value = "Active")]
            Active = 2,
            
            /// <summary>
            /// Enum Inactive for value: Inactive
            /// </summary>
            [EnumMember(Value = "Inactive")]
            Inactive = 3,
            
            /// <summary>
            /// Enum Pending for value: Pending
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending = 4,
            
            /// <summary>
            /// Enum Closed for value: Closed
            /// </summary>
            [EnumMember(Value = "Closed")]
            Closed = 5
        }

        /// <summary>
        /// Allow valid Enum value.
        /// </summary>
        /// <value>Allow valid Enum value.</value>
        [DataMember(Name="updateStatus", EmitDefaultValue=false)]
        public UpdateStatusEnum? UpdateStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SegStatus" /> class.
        /// </summary>
        /// <param name="updateStatus">Allow valid Enum value..</param>
        public SegStatus(UpdateStatusEnum? updateStatus = default(UpdateStatusEnum?))
        {
            this.UpdateStatus = updateStatus;
        }
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SegStatus {\n");
            sb.Append("  UpdateStatus: ").Append(UpdateStatus).Append("\n");
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
            return this.Equals(input as SegStatus);
        }

        /// <summary>
        /// Returns true if SegStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of SegStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SegStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UpdateStatus == input.UpdateStatus ||
                    (this.UpdateStatus != null &&
                    this.UpdateStatus.Equals(input.UpdateStatus))
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
                if (this.UpdateStatus != null)
                    hashCode = hashCode * 59 + this.UpdateStatus.GetHashCode();
                return hashCode;
            }
        }
    }

}
