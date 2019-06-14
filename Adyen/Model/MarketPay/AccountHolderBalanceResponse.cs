using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// AccountHolderBalanceResponse
    /// </summary>
    [DataContract]
    public partial class AccountHolderBalanceResponse : IEquatable<AccountHolderBalanceResponse>, IValidatableObject
    {
        /// <summary>
        /// resultCode.
        /// </summary>
        /// <value>resultCode.</value>
        [DataMember(Name = "resultCode", EmitDefaultValue = false)]
        public string resultCode { get; set; }


        /// <summary>
        /// pspReference.
        /// </summary>
        /// <value>pspReference.</value>
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        public string pspReference { get; set; }


        /// <summary>
        /// totalBalance.
        /// </summary>
        /// <value>DetailBalance.</value>
        [DataMember(Name = "totalBalance", EmitDefaultValue = false)]
        public DetailBalance totalBalance { get; set; }


        /// <summary>
        /// balancePerAccount.
        /// </summary>
        /// <value>List<AccountDetailBalanceContainer></value>
        [DataMember(Name = "balancePerAccount", EmitDefaultValue = false)]
        public List<AccountDetailBalanceContainer> balancePerAccount { get; set; }


        /// <summary>
        /// submittedAsync.
        /// </summary>
        /// <value>true or false.</value>
        [DataMember(Name = "submittedAsync", EmitDefaultValue = false)]
        public bool submittedAsync { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="AccountHolderBalanceResponse" /> class.
        /// </summary>
        /// <param name="account">account.</param>
        public AccountHolderBalanceResponse(string resultCode = default(string), string pspReference = default(string), DetailBalance totalBalance = default(DetailBalance), bool submittedAsync = default(bool), List<AccountDetailBalanceContainer> balancePerAccount = default(List<AccountDetailBalanceContainer>))
        {
            this.resultCode = resultCode;
            this.pspReference = pspReference;
            this.totalBalance = totalBalance;
            this.submittedAsync = submittedAsync;
            this.balancePerAccount = balancePerAccount;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountHolderBalanceResponse {\n");
            sb.Append("  submittedAsync: ").Append(submittedAsync).Append("\n");
            sb.Append("  totalBalance: ").Append(totalBalance).Append("\n");
            sb.Append("  resultCode: ").Append(resultCode).Append("\n");
            sb.Append("  balancePerAccount: ").Append(balancePerAccount).Append("\n");
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
            return this.Equals(input as AccountHolderBalanceResponse);
        }

        /// <summary>
        /// Returns true if MerchantDevice instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantDevice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountHolderBalanceResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    this.submittedAsync == input.submittedAsync ||
                    (this.submittedAsync != null && this.submittedAsync.Equals(input.submittedAsync))
                )&&
                (
                    this.totalBalance == input.totalBalance ||
                    (this.totalBalance != null && this.totalBalance.Equals(input.totalBalance))
                ) &&
                (
                    this.resultCode == input.resultCode ||
                    (this.resultCode != null && this.resultCode.Equals(input.resultCode))
                ) &&
                (
                    this.balancePerAccount == input.balancePerAccount ||
                    (this.balancePerAccount != null && this.balancePerAccount.Equals(input.balancePerAccount))
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
                if (this.totalBalance != null)
                    hashCode = hashCode * 59 + this.totalBalance.GetHashCode();
                if (this.resultCode != null)
                    hashCode = hashCode * 59 + this.resultCode.GetHashCode();
                if (this.balancePerAccount != null)
                    hashCode = hashCode * 59 + this.balancePerAccount.GetHashCode();
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
