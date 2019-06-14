using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Adyen.Model.Enum;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// AccountState
    /// </summary>
    [DataContract]
    public partial class AccountState : IEquatable<AccountState>, IValidatableObject
    {
        
        /// <summary>
        /// disableReason.
        /// </summary>
        /// <value>disableReason.</value>
        [DataMember(Name = "disableReason", EmitDefaultValue = false)]
        public string disableReason { get; set; }
       
        /// <summary>
        /// allowProcessing.
        /// </summary>
        /// <value>allowProcessing.</value>
        [DataMember(Name = "allowProcessing", EmitDefaultValue = false)]
        public string allowProcessing { get; set; }

        /// <summary>
        /// AllowPayout.
        /// </summary>
        /// <value>bool.</value>
        [DataMember(Name = "allowPayout", EmitDefaultValue = false)]
        public bool allowPayout { get; set; }


        /// <summary>
        /// stateDeadline.
        /// </summary>
        /// <value>DateTime.</value>
        [DataMember(Name = "stateDeadline", EmitDefaultValue = false)]
        public DateTime stateDeadline { get; set; }



        /// <summary>
        /// stateType.
        /// </summary>
        /// <value>stateType.</value>
        [DataMember(Name = "stateType", EmitDefaultValue = false)]
        public StateTypeEnum stateType { get; set; }




        /// <summary>
        /// stateLimit.
        /// </summary>
        /// <value>AccountStateLimit.</value>
        [DataMember(Name = "stateLimit", EmitDefaultValue = false)]
        public AccountStateLimit stateLimit { get; set; }


        /// <summary>
        /// tierNumber.
        /// </summary>
        /// <value>integer.</value>
        [DataMember(Name = "tierNumber", EmitDefaultValue = false)]
        public int tierNumber { get; set; }


        /// <summary>
        /// disabled.
        /// </summary>
        /// <value>bool.</value>
        [DataMember(Name = "disabled", EmitDefaultValue = false)]
        public bool disabled { get; set; }




        /// <summary>
        /// Initializes a new instance of the <see cref="AccountState" /> class.
        /// </summary>
        /// <param name="account">account.</param>
        public AccountState(AccountStateLimit stateLimit = default(AccountStateLimit))
        {
            this.stateLimit = stateLimit;

        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountState {\n");
            sb.Append("  disableReason: ").Append(disableReason).Append("\n");
            sb.Append("  allowProcessing: ").Append(allowProcessing).Append("\n");
            sb.Append("  stateDeadline: ").Append(stateDeadline).Append("\n");
            sb.Append("  allowPayout: ").Append(allowPayout).Append("\n");
            sb.Append("  stateLimit: ").Append(stateLimit).Append("\n");
            sb.Append("  stateType: ").Append(stateType).Append("\n");
            sb.Append("  tierNumber: ").Append(tierNumber).Append("\n");
            sb.Append("  disabled: ").Append(disabled).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccountState);
        }

        /// <summary>
        /// Returns true if MerchantDevice instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantDevice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountState input)
        {
            if (input == null)
                return false;

            return
                (
                    this.disableReason == input.disableReason ||
                    (this.disableReason != null && this.disableReason.Equals(input.disableReason))
                )
                &&
                (
                    this.allowProcessing == input.allowProcessing ||
                    (this.allowProcessing != null && this.allowProcessing.Equals(input.allowProcessing))
                )
                &&
                (
                    this.stateDeadline == input.stateDeadline ||
                    (this.stateDeadline != null && this.stateDeadline.Equals(input.stateDeadline))
                )
                &&
                (
                    this.allowPayout == input.allowPayout ||
                    (this.allowPayout != null && this.allowPayout.Equals(input.allowPayout))
                )

                &&
                (
                    this.stateLimit == input.stateLimit ||
                    (this.stateLimit != null && this.stateLimit.Equals(input.stateLimit))
                )
                &&
                (
                    this.stateType == input.stateType ||
                    (this.stateType != null && this.stateType.Equals(input.stateType))
                )
                &&
                (
                    this.tierNumber == input.tierNumber ||
                    (this.tierNumber != null && this.tierNumber.Equals(input.tierNumber))
                )
                &&
                (
                    this.disabled == input.disabled ||
                    (this.disabled != null && this.disabled.Equals(input.disabled))
                )
                ;
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
                if (this.disableReason != null)
                    hashCode = hashCode * 59 + this.disableReason.GetHashCode();
                if (this.allowProcessing != null)
                    hashCode = hashCode * 59 + this.allowProcessing.GetHashCode();
                if (this.stateDeadline != null)
                    hashCode = hashCode * 59 + this.stateDeadline.GetHashCode();
                if (this.allowPayout != null)
                    hashCode = hashCode * 59 + this.allowPayout.GetHashCode();
                if (this.stateLimit != null)
                    hashCode = hashCode * 59 + this.stateLimit.GetHashCode();
                if (this.stateType != null)
                    hashCode = hashCode * 59 + this.stateType.GetHashCode();
                if (this.tierNumber != null)
                    hashCode = hashCode * 59 + this.tierNumber.GetHashCode();
                if (this.disabled != null)
                    hashCode = hashCode * 59 + this.disabled.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }


    }
}
