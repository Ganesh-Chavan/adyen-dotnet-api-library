﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// AccountDetailBalanceContainer
    /// </summary>
    [DataContract]
    public partial class AccountDetailBalanceContainer: IEquatable<AccountDetailBalanceContainer>, IValidatableObject
    {
        /// <summary>
        /// account.
        /// </summary>
        /// <value>account.</value>
        [DataMember(Name = "accountDetailBalance", EmitDefaultValue = false)]
        public AccountDetailBalance accountDetailBalance { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDetailBalanceContainer" /> class.
        /// </summary>
        /// <param name="account">account.</param>
        public AccountDetailBalanceContainer(AccountDetailBalance accountDetailBalance = default(AccountDetailBalance))
        {
            this.accountDetailBalance = accountDetailBalance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountDetailBalanceContainer {\n");
            sb.Append("  account: ").Append(accountDetailBalance).Append("\n");
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
            return this.Equals(input as AccountDetailBalanceContainer);
        }

        /// <summary>
        /// Returns true if MerchantDevice instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantDevice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountDetailBalanceContainer input)
        {
            if (input == null)
                return false;

            return
                (
                    this.accountDetailBalance == input.accountDetailBalance ||
                    (this.accountDetailBalance != null &&
                    this.accountDetailBalance.Equals(input.accountDetailBalance))
                ) ;
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
                if (this.accountDetailBalance != null)
                    hashCode = hashCode * 59 + this.accountDetailBalance.GetHashCode();
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
