using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// AccountPayoutState
    /// </summary>
    [DataContract]
    public partial class AccountPayoutState : IEquatable<AccountPayoutState>, IValidatableObject
    {
        /// <summary>
        /// payoutLimit.
        /// </summary>
        /// <value>payoutLimit.</value>
        [DataMember(Name = "payoutLimit", EmitDefaultValue = false)]
        public Amount payoutLimit { get; set; }


        /// <summary>
        /// disableReason.
        /// </summary>
        /// <value>disableReason.</value>
        [DataMember(Name = "disableReason", EmitDefaultValue = false)]
        public string disableReason { get; set; }


        /// <summary>
        /// AllowPayout.
        /// </summary>
        /// <value>bool.</value>
        [DataMember(Name = "allowPayout", EmitDefaultValue = false)]
        public bool allowPayout { get; set; }



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
        /// Initializes a new instance of the <see cref="AccountPayoutState" /> class.
        /// </summary>
        /// <param name="account">account.</param>
        public AccountPayoutState(Amount payoutLimit = default(Amount), string disableReason = default(string), bool allowPayout = default(bool), bool disabled = default(bool))
        {
            this.payoutLimit = payoutLimit;
            this.disableReason = disableReason;
            this.allowPayout = allowPayout;
            this.disabled = disabled;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountPayoutState {\n");
            sb.Append("  disableReason: ").Append(disableReason).Append("\n");
            sb.Append("  allowPayout: ").Append(allowPayout).Append("\n");
            sb.Append("  tierNumber: ").Append(tierNumber).Append("\n");
            sb.Append("  disabled: ").Append(disabled).Append("\n");
            sb.Append("  payoutLimit: ").Append(payoutLimit).Append("\n");
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
            return this.Equals(input as AccountPayoutState);
        }

        /// <summary>
        /// Returns true if MerchantDevice instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantDevice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountPayoutState input)
        {
            if (input == null)
                return false;

            return
                (
                    this.disableReason == input.disableReason ||
                    (this.disableReason != null &&
                    this.disableReason.Equals(input.disableReason))
                )
                &&
                (
                    this.allowPayout == input.allowPayout ||
                    (this.allowPayout != null &&
                     this.allowPayout.Equals(input.allowPayout))
                )
                &&
                (
                    this.tierNumber == input.tierNumber ||
                    (this.tierNumber != null &&
                     this.tierNumber.Equals(input.tierNumber))
                )

                &&
                (
                    this.disabled == input.disabled ||
                    (this.disabled != null &&
                     this.disabled.Equals(input.disabled))
                )
                &&
                (
                    this.payoutLimit == input.payoutLimit ||
                    (this.payoutLimit != null &&
                     this.payoutLimit.Equals(input.payoutLimit))
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
                if (this.allowPayout != null)
                    hashCode = hashCode * 59 + this.allowPayout.GetHashCode();
                if (this.tierNumber != null)
                    hashCode = hashCode * 59 + this.tierNumber.GetHashCode();
                if (this.disabled != null)
                    hashCode = hashCode * 59 + this.disabled.GetHashCode();
                if (this.payoutLimit != null)
                    hashCode = hashCode * 59 + this.payoutLimit.GetHashCode();

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
