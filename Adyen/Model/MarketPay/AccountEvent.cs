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
    /// AccountEvent
    /// </summary>
    [DataContract]
    public partial class AccountEvent : IEquatable<AccountEvent>, IValidatableObject
    {

        /// <summary>
        /// reason.
        /// </summary>
        /// <value>reason.</value>
        [DataMember(Name = "event", EmitDefaultValue = false)]
        public EventEnum Event { get; set; }


        /// <summary>
        /// reason.
        /// </summary>
        /// <value>reason.</value>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        public string reason { get; set; }


        /// <summary>
        /// resolvedByStateType.
        /// </summary>
        /// <value>resolvedByStateType.</value>
        [DataMember(Name = "resolvedByStateType", EmitDefaultValue = false)]
        public string resolvedByStateType { get; set; }

        /// <summary>
        /// executionDate.
        /// </summary>
        /// <value>executionDate.</value>
        [DataMember(Name = "executionDate", EmitDefaultValue = false)]
        public DateTime executionDate { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="AccountEvent" /> class.
        /// </summary>
        /// <param name="account">account.</param>
        public AccountEvent(string reason = default(string), string resolvedByStateType = default(string), DateTime executionDate = default(DateTime), EventEnum Event = default(EventEnum))
        {
            this.reason = reason;
            this.resolvedByStateType = resolvedByStateType;
            this.executionDate = executionDate;
            this.Event = Event;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountEvent {\n");
            sb.Append("    reason: ").Append(reason).Append("\n");
            sb.Append("    resolvedByStateType: ").Append(resolvedByStateType).Append("\n");
            sb.Append("    executionDate: ").Append(executionDate).Append("\n");
            sb.Append("    event: ").Append(Event).Append("\n");
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
            return this.Equals(input as AccountEvent);
        }

        /// <summary>
        /// Returns true if MerchantDevice instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantDevice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountEvent input)
        {
            if (input == null)
                return false;

            return
                (
                    this.reason == input.reason ||
                    (this.reason != null && this.reason.Equals(input.reason))
                    )
                &&
                (
                    this.resolvedByStateType == input.resolvedByStateType ||
                    (this.resolvedByStateType != null && this.resolvedByStateType.Equals(input.resolvedByStateType))
                ) &&
                (
                    this.executionDate == input.executionDate ||
                    (this.executionDate != null && this.executionDate.Equals(input.executionDate))
                )
                &&
                (
                    this.Event == input.Event ||
                    (this.Event != null && this.Event.Equals(input.Event))
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
                if (this.reason != null)
                    hashCode = hashCode * 59 + this.reason.GetHashCode();
                if (this.resolvedByStateType != null)
                    hashCode = hashCode * 59 + this.resolvedByStateType.GetHashCode();
                if (this.executionDate != null)
                    hashCode = hashCode * 59 + this.executionDate.GetHashCode();
                if (this.Event != null)
                    hashCode = hashCode * 59 + this.Event.GetHashCode();

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
