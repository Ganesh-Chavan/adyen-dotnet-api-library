﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// AccountTransactionListContainer
    /// </summary>
    [DataContract]
    public partial class AccountTransactionListContainer : IEquatable<AccountTransactionListContainer>, IValidatableObject
    {
        /// <summary>
        /// AccountTransactionList.
        /// </summary>
        /// <value>AccountTransactionList.</value>
        [DataMember(Name = "AccountTransactionList", EmitDefaultValue = false)]
        public AccountTransactionList accountTransactionList { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="AccountTransactionListContainer" /> class.
        /// </summary>
        /// <param name="account">account.</param>
        public AccountTransactionListContainer(AccountTransactionList accountTransactionList = default(AccountTransactionList))
        {
            this.accountTransactionList = accountTransactionList;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountTransactionListContainer {\n");
            sb.Append("  accountTransactionList: ").Append(accountTransactionList).Append("\n");
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
            return this.Equals(input as AccountTransactionListContainer);
        }

        /// <summary>
        /// Returns true if MerchantDevice instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantDevice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountTransactionListContainer input)
        {
            if (input == null)
                return false;

            return
                (
                    this.accountTransactionList == input.accountTransactionList ||
                    (this.accountTransactionList != null &&
                    this.accountTransactionList.Equals(input.accountTransactionList))
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
                if (this.accountTransactionList != null)
                    hashCode = hashCode * 59 + this.accountTransactionList.GetHashCode();
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
