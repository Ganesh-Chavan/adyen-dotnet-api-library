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
    /// AccountHolderStatus
    /// </summary>
    [DataContract]
    public partial class AccountHolderStatus : IEquatable<AccountHolderStatus>, IValidatableObject
    {

        /// <summary>
        /// statusReason.
        /// </summary>
        /// <value>statusReason.</value>
        [DataMember(Name = "statusReason", EmitDefaultValue = false)]
        public string statusReason { get; set; }


        /// <summary>
        /// processingState.
        /// </summary>
        /// <value>account.</value>
        [DataMember(Name = "processingState", EmitDefaultValue = false)]
        public AccountProcessingState processingState { get; set; }


        /// <summary>
        /// payoutState.
        /// </summary>
        /// <value>payoutState.</value>
        [DataMember(Name = "payoutState", EmitDefaultValue = false)]
        public AccountPayoutState payoutState { get; set; }



        /// <summary>
        /// accountEvents.
        /// </summary>
        /// <value>accountEvents.</value>
        [DataMember(Name = "accountEvents", EmitDefaultValue = false)]
        public StatusEnum accountEvents { get; set; }


        /// <summary>
        /// status.
        /// </summary>
        /// <value>status.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public List<AccountEvent> status { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="AccountHolderStatus" /> class.
        /// </summary>
        /// <param name="account">account.</param>
        public AccountHolderStatus(AccountProcessingState processingState = default(AccountProcessingState), AccountPayoutState payoutState = default(AccountPayoutState))
        {
            this.processingState = processingState;
            this.payoutState = payoutState;

        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountHolderStatus {\n");
            sb.Append("  processingState: ").Append(processingState).Append("\n");
            sb.Append("  statusReason: ").Append(statusReason).Append("\n");
            sb.Append("  payoutState: ").Append(payoutState).Append("\n");
            sb.Append("  status: ").Append(status).Append("\n");
            sb.Append("  accountEvents: ").Append(accountEvents).Append("\n");
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
            return this.Equals(input as AccountHolderStatus);
        }

        /// <summary>
        /// Returns true if MerchantDevice instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantDevice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountHolderStatus input)
        {
            if (input == null)
                return false;

            return
                (
                    this.processingState == input.processingState ||
                    (this.processingState != null &&
                    this.processingState.Equals(input.processingState))
                )&&
                (
                    this.statusReason == input.statusReason ||
                    (this.statusReason != null &&
                     this.statusReason.Equals(input.statusReason))
                ) &&
                (
                    this.payoutState == input.payoutState ||
                    (this.payoutState != null &&
                     this.payoutState.Equals(input.payoutState))
                ) &&
                (
                    this.status == input.status ||
                    (this.status != null &&
                     this.status.Equals(input.status))
                ) &&
                (
                    this.accountEvents == input.accountEvents ||
                    (this.accountEvents != null &&
                     this.accountEvents.Equals(input.accountEvents))
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
                if (this.processingState != null)
                    hashCode = hashCode * 59 + this.processingState.GetHashCode();
                if (this.statusReason != null)
                    hashCode = hashCode * 59 + this.statusReason.GetHashCode();
                if (this.payoutState != null)
                    hashCode = hashCode * 59 + this.payoutState.GetHashCode();
                if (this.status != null)
                    hashCode = hashCode * 59 + this.status.GetHashCode();
                if (this.accountEvents != null)
                    hashCode = hashCode * 59 + this.accountEvents.GetHashCode();
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