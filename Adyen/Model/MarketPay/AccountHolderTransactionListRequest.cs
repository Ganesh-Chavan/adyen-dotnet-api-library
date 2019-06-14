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
    /// AccountHolderTransactionListRequest
    /// </summary>
    [DataContract]
    public partial class AccountHolderTransactionListRequest : IEquatable<AccountHolderTransactionListRequest>, IValidatableObject
    {
        /// <summary>
        /// transactionListsPerAccount.
        /// </summary>
        /// <value>transactionListsPerAccount.</value>
        [DataMember(Name = "transactionListsPerAccount", EmitDefaultValue = false)]
        public List<TransactionListForAccount> transactionListsPerAccount { get; set; }



        /// <summary>
        /// transactionStatuses.
        /// </summary>
        /// <value>transactionListsPerAccount.</value>
        [DataMember(Name = "transactionStatuses", EmitDefaultValue = false)]
        public List<TransactionStatusesEnum> transactionStatuses { get; set; }



        /// <summary>
        /// accountHolderCode.
        /// </summary>
        /// <value>accountHolderCode.</value>
        [DataMember(Name = "accountHolderCode", EmitDefaultValue = false)]
        public string accountHolderCode { get; set; }




        /// <summary>
        /// Initializes a new instance of the <see cref="AccountHolderTransactionListRequest" /> class.
        /// </summary>
        /// <param name="account">account.</param>
        public AccountHolderTransactionListRequest(string accountHolderCode = default(string), List<TransactionListForAccount> transactionListsPerAccount=default(List<TransactionListForAccount>), List<TransactionStatusesEnum> transactionStatuses = default(List<TransactionStatusesEnum>))
        {
            this.accountHolderCode = accountHolderCode;
            this.transactionListsPerAccount = transactionListsPerAccount;
            this.transactionStatuses = transactionStatuses;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountHolderTransactionListRequest {\n");
            sb.Append("  accountHolderCode: ").Append(accountHolderCode).Append("\n");
            sb.Append("  transactionListsPerAccount: ").Append(transactionListsPerAccount).Append("\n");
            sb.Append("  transactionStatuses: ").Append(transactionStatuses).Append("\n");
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
            return this.Equals(input as AccountHolderTransactionListRequest);
        }

        /// <summary>
        /// Returns true if MerchantDevice instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantDevice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountHolderTransactionListRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.accountHolderCode == input.accountHolderCode ||
                    (this.accountHolderCode != null && this.accountHolderCode.Equals(input.accountHolderCode))
                )
                &&
                (
                    this.transactionListsPerAccount == input.transactionListsPerAccount ||
                    (this.transactionListsPerAccount != null && this.transactionListsPerAccount.Equals(input.transactionListsPerAccount))
                )
                &&
                (
                    this.transactionStatuses == input.transactionStatuses ||
                    (this.transactionStatuses != null && this.transactionStatuses.Equals(input.transactionStatuses))
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
                if (this.accountHolderCode != null)
                    hashCode = hashCode * 59 + this.accountHolderCode.GetHashCode();
                if (this.transactionListsPerAccount != null)
                    hashCode = hashCode * 59 + this.transactionListsPerAccount.GetHashCode();
                if (this.transactionStatuses != null)
                    hashCode = hashCode * 59 + this.transactionStatuses.GetHashCode();
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
