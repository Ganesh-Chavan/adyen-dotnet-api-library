using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// AccountStatus
    /// </summary>
    [DataContract]
    public partial class AccountStatus : IEquatable<AccountStatus>, IValidatableObject
    {

        /// <summary>
        /// status.
        /// </summary>
        /// <value>status.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string status { get; set; }

        /// <summary>
        /// states.
        /// </summary>
        /// <value>states.</value>
        [DataMember(Name = "states", EmitDefaultValue = false)]
        public List<AccountState> states { get; set; }

        /// <summary>
        /// accountEvents.
        /// </summary>
        /// <value>accountEvents.</value>
        [DataMember(Name = "accountEvents", EmitDefaultValue = false)]
        public List<AccountEvent> accountEvents { get; set; }



        /// <summary>
        /// Initializes a new instance of the <see cref="AccountStatus" /> class.
        /// </summary>
        /// <param name="account">account.</param>
        public AccountStatus(string status = default(string))
        {
            this.status = status;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountStatus {\n");
            sb.Append("  status: ").Append(status).Append("\n");
            sb.Append("  states: ").Append(states).Append("\n");
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
            return this.Equals(input as AccountStatus);
        }

        /// <summary>
        /// Returns true if MerchantDevice instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantDevice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountStatus input)
        {
            if (input == null)
                return false;

            return
                (
                    this.status == input.status ||
                    (this.status != null &&
                    this.status.Equals(input.status))
                )
              &&
              (
                  this.states == input.states ||
                  (this.states != null &&
                   this.states.Equals(input.states))
              )
              &&
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
                if (this.status != null)
                    hashCode = hashCode * 59 + this.status.GetHashCode();
                if (this.states != null)
                    hashCode = hashCode * 59 + this.states.GetHashCode();
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
