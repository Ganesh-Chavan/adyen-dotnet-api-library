using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// AccountStateLimit
    /// </summary>
    [DataContract]
    public partial class AccountStateLimit : IEquatable<AccountStateLimit>, IValidatableObject
    {
        /// <summary>
        /// amount.
        /// </summary>
        /// <value>long.</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public long amount { get; set; }

        /// <summary>
        /// currency.
        /// </summary>
        /// <value>string</value>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string currency { get; set; }




        /// <summary>
        /// Initializes a new instance of the <see cref="AccountStateLimit" /> class.
        /// </summary>
        /// <param name="account">account.</param>
        public AccountStateLimit(long amount = default(long), string currency = default(string))
        {
            this.amount = amount;
            this.currency = currency;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountStateLimit {\n");
            sb.Append("  amount: ").Append(amount).Append("\n");
            sb.Append("  currency: ").Append(currency).Append("\n");
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
            return this.Equals(input as AccountStateLimit);
        }

        /// <summary>
        /// Returns true if MerchantDevice instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantDevice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountStateLimit input)
        {
            if (input == null)
                return false;

            return
                (
                    this.amount == input.amount ||
                    (this.amount != null && this.amount.Equals(input.amount))
                )
                &&
                (
                    this.currency == input.currency ||
                    (this.currency != null && this.currency.Equals(input.currency))
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
                if (this.amount != null)
                    hashCode = hashCode * 59 + this.amount.GetHashCode();
                if (this.currency != null)
                    hashCode = hashCode * 59 + this.currency.GetHashCode();
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
