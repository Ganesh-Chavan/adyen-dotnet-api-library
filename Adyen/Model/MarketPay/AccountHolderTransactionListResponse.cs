using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// AccountHolderTransactionListResponse
    /// </summary>
    [DataContract]
    public partial class AccountHolderTransactionListResponse : IEquatable<AccountHolderTransactionListResponse>, IValidatableObject
    {
        /// <summary>
        /// submittedAsync.
        /// </summary>
        /// <value>bool.</value>
        [DataMember(Name = "submittedAsync", EmitDefaultValue = false)]
        public bool submittedAsync { get; set; }


        /// <summary>
        /// submittedAsync.
        /// </summary>
        /// <value>Boolean.</value>
        [DataMember(Name = "accountTransactionLists", EmitDefaultValue = false)]
        public List<AccountTransactionListContainer> accountTransactionListContainers { get; set; }

        public  List<AccountTransactionList> accountTransactionLists { get; set; }


        /// <summary>
        /// resultCode.
        /// </summary>
        /// <value>string.</value>
        [DataMember(Name = "resultCode", EmitDefaultValue = false)]
        public string resultCode { get; set; }


        /// <summary>
        /// pspReference.
        /// </summary>
        /// <value>string.</value>
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        public string pspReference { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="AccountHolderTransactionListResponse" /> class.
        /// </summary>
        /// <param name="account">account.</param>
        public AccountHolderTransactionListResponse(List<AccountTransactionListContainer> accountTransactionListContainers = default(List<AccountTransactionListContainer>))
        {
            this.accountTransactionListContainers = accountTransactionListContainers;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountHolderTransactionListResponse {\n");
            sb.Append("  submittedAsync: ").Append(submittedAsync).Append("\n");
            sb.Append("  accountTransactionLists: ").Append(accountTransactionLists).Append("\n");
            sb.Append("  resultCode: ").Append(resultCode).Append("\n");
            sb.Append("  pspReference: ").Append(pspReference).Append("\n");
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
            return this.Equals(input as AccountHolderTransactionListResponse);
        }

        /// <summary>
        /// Returns true if MerchantDevice instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantDevice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountHolderTransactionListResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    this.submittedAsync == input.submittedAsync ||
                    (this.submittedAsync != null && this.submittedAsync.Equals(input.submittedAsync))
                )
                &&
                (
                    this.accountTransactionLists == input.accountTransactionLists ||
                    (this.accountTransactionLists != null && this.accountTransactionLists.Equals(input.accountTransactionLists))
                )
                &&
                (
                    this.resultCode == input.resultCode ||
                    (this.resultCode != null && this.resultCode.Equals(input.resultCode))
                )

                &&
                (
                    this.pspReference == input.pspReference ||
                    (this.pspReference != null && this.pspReference.Equals(input.pspReference))
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
                if (this.submittedAsync != null)
                    hashCode = hashCode * 59 + this.submittedAsync.GetHashCode();
                if (this.accountTransactionLists != null)
                    hashCode = hashCode * 59 + this.accountTransactionLists.GetHashCode();
                if (this.resultCode != null)
                    hashCode = hashCode * 59 + this.resultCode.GetHashCode();
                if (this.pspReference != null)
                    hashCode = hashCode * 59 + this.pspReference.GetHashCode();
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
