using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// AccountTransactionList
    /// </summary>
    [DataContract]
    public partial class AccountTransactionList : IEquatable<AccountTransactionList>, IValidatableObject
    {
        /// <summary>
        /// accountCode.
        /// </summary>
        /// <value>accountCode.</value>
        [DataMember(Name = "accountCode", EmitDefaultValue = false)]
        public string accountCode { get; set; }


        /// <summary>
        /// hasNextPage.
        /// </summary>
        /// <value>true</value>
        [DataMember(Name = "hasNextPage", EmitDefaultValue = false)]
        public bool hasNextPage { get; set; }




        /// <summary>
        /// transactions.
        /// </summary>
        /// <value>true</value>
        [DataMember(Name = "transactions", EmitDefaultValue = false)]
        public List<TransactionContainer> transactionContainers { get; set; }


        public List<Transaction> transactions { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountTransactionList" /> class.
        /// </summary>
        /// <param name="account">account.</param>
        public AccountTransactionList(string accountCode = default(string), bool hasNextPage =  default(bool), List<TransactionContainer> transactionContainers = default(List<TransactionContainer>))
        {
            this.accountCode = accountCode;
            this.hasNextPage = hasNextPage;
            this.transactionContainers = transactionContainers;

        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountTransactionList {\n");
            sb.Append("  accountCode: ").Append(accountCode).Append("\n");
            sb.Append("  hasNextPage: ").Append(hasNextPage).Append("\n");
            sb.Append("  transactionContainers: ").Append(transactionContainers).Append("\n");
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
            return this.Equals(input as AccountTransactionList);
        }

        /// <summary>
        /// Returns true if MerchantDevice instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantDevice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountTransactionList input)
        {
            if (input == null)
                return false;

            return
                (
                    this.accountCode == input.accountCode ||
                    (this.accountCode != null && this.accountCode.Equals(input.accountCode))
                )
                &&
                (
                    this.hasNextPage == input.hasNextPage ||
                    (this.hasNextPage != null && this.hasNextPage.Equals(input.hasNextPage))
                )
                &&
                (
                    this.transactionContainers == input.transactionContainers ||
                    (this.transactionContainers != null && this.transactionContainers.Equals(input.transactionContainers))
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
                if (this.accountCode != null)
                    hashCode = hashCode * 59 + this.accountCode.GetHashCode();
                if (this.hasNextPage != null)
                    hashCode = hashCode * 59 + this.hasNextPage.GetHashCode();
                if (this.transactionContainers != null)
                    hashCode = hashCode * 59 + this.transactionContainers.GetHashCode();
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
