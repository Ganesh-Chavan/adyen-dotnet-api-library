using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// DetailBalance
    /// </summary>
    [DataContract]
    public partial class DetailBalance : IEquatable<DetailBalance>, IValidatableObject
    {
        /// <summary>
        /// pendingBalance.
        /// </summary>
        /// <value>pendingBalance.</value>
        [DataMember(Name = "pendingBalance", EmitDefaultValue = false)]
        public List<AmountContainer> pendingBalance { get; set; }



        /// <summary>
        /// pendingBalance.
        /// </summary>
        /// <value>pendingBalance.</value>
        [DataMember(Name = "balance", EmitDefaultValue = false)]
        public List<Amount> balance { get; set; }




        /// <summary>
        /// Initializes a new instance of the <see cref="DetailBalance" /> class.
        /// </summary>
        /// <param name="account">account.</param>
        public DetailBalance(List<AmountContainer> pendingBalance = default(List<AmountContainer>), List<Amount> balance = default(List<Amount>))
        {
            this.pendingBalance = pendingBalance;
            this.balance = balance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetailBalance {\n");
            sb.Append("  pendingBalance: ").Append(pendingBalance).Append("\n");
            sb.Append("  balance: ").Append(balance).Append("\n");
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
            return this.Equals(input as DetailBalance);
        }

        /// <summary>
        /// Returns true if MerchantDevice instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantDevice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetailBalance input)
        {
            if (input == null)
                return false;

            return
                (
                    this.pendingBalance == input.pendingBalance ||
                    (this.pendingBalance != null &&  this.pendingBalance.Equals(input.pendingBalance))
                )
                &&
                (
                    this.balance == input.balance ||
                    (this.balance != null &&   this.balance.Equals(input.balance))
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
                if (this.pendingBalance != null)
                    hashCode = hashCode * 59 + this.pendingBalance.GetHashCode();
                if (this.balance != null)
                    hashCode = hashCode * 59 + this.balance.GetHashCode();
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
