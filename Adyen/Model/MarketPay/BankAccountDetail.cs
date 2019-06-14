using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// BankAccountDetail
    /// </summary>
    [DataContract]
    public partial class BankAccountDetail : IEquatable<BankAccountDetail>, IValidatableObject
    {
        [DataMember(Name = "ownerNationality", EmitDefaultValue = false)]
        public string ownerNationality { get; set; }

        [DataMember(Name = "ownerPostalCode", EmitDefaultValue = false)]
        public string ownerPostalCode { get; set; }

        [DataMember(Name = "ownerCountryCode", EmitDefaultValue = false)]
        public string ownerCountryCode { get; set; }

        [DataMember(Name = "bankName", EmitDefaultValue = false)]
        public string bankName { get; set; }

        [DataMember(Name = "ownerState", EmitDefaultValue = false)]
        public string ownerState { get; set; }

        [DataMember(Name = "bankAccountUUID", EmitDefaultValue = false)]
        public string bankAccountUUID { get; set; }

        [DataMember(Name = "ownerName", EmitDefaultValue = false)]
        public string ownerName { get; set; }

        [DataMember(Name = "bankBicSwift", EmitDefaultValue = false)]
        public string bankBicSwift { get; set; }

        [DataMember(Name = "ownerDateOfBirth", EmitDefaultValue = false)]
        public string ownerDateOfBirth { get; set; }

        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string countryCode { get; set; }

        [DataMember(Name = "ownerStreet", EmitDefaultValue = false)]
        public string ownerStreet { get; set; }

        [DataMember(Name = "bankAccountName", EmitDefaultValue = false)]
        public string bankAccountName { get; set; }

        [DataMember(Name = "ownerHouseNumberOrName", EmitDefaultValue = false)]
        public string ownerHouseNumberOrName { get; set; }

        [DataMember(Name = "bankCode", EmitDefaultValue = false)]
        public string bankCode { get; set; }

        [DataMember(Name = "accountType", EmitDefaultValue = false)]
        public string accountType { get; set; }

        [DataMember(Name = "accountNumber", EmitDefaultValue = false)]
        public string accountNumber { get; set; }

        [DataMember(Name = "primaryAccount", EmitDefaultValue = false)]
        public bool? primaryAccount { get; set; }

        [DataMember(Name = "bankCity", EmitDefaultValue = false)]
        public string bankCity { get; set; }

        [DataMember(Name = "checkCode", EmitDefaultValue = false)]
        public string checkCode { get; set; }

        [DataMember(Name = "branchCode", EmitDefaultValue = false)]
        public string branchCode { get; set; }

        [DataMember(Name = "taxId", EmitDefaultValue = false)]
        public string taxId { get; set; }

        [DataMember(Name = "iban", EmitDefaultValue = false)]
        public string iban { get; set; }

        [DataMember(Name = "ownerCity", EmitDefaultValue = false)]
        public string ownerCity { get; set; }

        [DataMember(Name = "urlForVerification", EmitDefaultValue = false)]
        public string urlForVerification { get; set; }

        [DataMember(Name = "currencyCode", EmitDefaultValue = false)]
        public string currencyCode { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountDetail" /> class.
        /// </summary>
        /// <param name="account">account.</param>
        public BankAccountDetail(string bankAccountUUID = default(string))
        {
            this.bankAccountUUID = bankAccountUUID;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BankAccountDetail {\n");
            sb.Append("    ownerNationality: ").Append(toIndentedString(ownerNationality)).Append("\n");
            sb.Append("    ownerPostalCode: ").Append(toIndentedString(ownerPostalCode)).Append("\n");
            sb.Append("    ownerCountryCode: ").Append(toIndentedString(ownerCountryCode)).Append("\n");
            sb.Append("    bankName: ").Append(toIndentedString(bankName)).Append("\n");
            sb.Append("    ownerState: ").Append(toIndentedString(ownerState)).Append("\n");
            sb.Append("    bankAccountUUID: ").Append(toIndentedString(bankAccountUUID)).Append("\n");
            sb.Append("    ownerName: ").Append(toIndentedString(ownerName)).Append("\n");
            sb.Append("    bankBicSwift: ").Append(toIndentedString(bankBicSwift)).Append("\n");
            sb.Append("    ownerDateOfBirth: ").Append(toIndentedString(ownerDateOfBirth)).Append("\n");
            sb.Append("    countryCode: ").Append(toIndentedString(countryCode)).Append("\n");
            sb.Append("    ownerStreet: ").Append(toIndentedString(ownerStreet)).Append("\n");
            sb.Append("    bankAccountName: ").Append(toIndentedString(bankAccountName)).Append("\n");
            sb.Append("    ownerHouseNumberOrName: ").Append(toIndentedString(ownerHouseNumberOrName)).Append("\n");
            sb.Append("    bankCode: ").Append(toIndentedString(bankCode)).Append("\n");
            sb.Append("    accountType: ").Append(toIndentedString(accountType)).Append("\n");
            sb.Append("    accountNumber: ").Append(toIndentedString(accountNumber)).Append("\n");
            sb.Append("    primaryAccount: ").Append(toIndentedString(primaryAccount)).Append("\n");
            sb.Append("    bankCity: ").Append(toIndentedString(bankCity)).Append("\n");
            sb.Append("    checkCode: ").Append(toIndentedString(checkCode)).Append("\n");
            sb.Append("    branchCode: ").Append(toIndentedString(branchCode)).Append("\n");
            sb.Append("    taxId: ").Append(toIndentedString(taxId)).Append("\n");
            sb.Append("    iban: ").Append(toIndentedString(iban)).Append("\n");
            sb.Append("    ownerCity: ").Append(toIndentedString(ownerCity)).Append("\n");
            sb.Append("    urlForVerification: ").Append(toIndentedString(urlForVerification)).Append("\n");
            sb.Append("    currencyCode: ").Append(toIndentedString(currencyCode)).Append("\n");
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
            return this.Equals(input as BankAccountDetail);
        }

        /// <summary>
        /// Returns true if MerchantDevice instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantDevice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankAccountDetail input)
        {
            if (input == null)
                return false;

            return (this.ownerNationality == input.ownerNationality ||  (this.ownerNationality != null && this.ownerNationality.Equals(input.ownerNationality)))
                && (this.ownerPostalCode == input.ownerPostalCode || (this.ownerPostalCode != null && this.ownerPostalCode.Equals(input.ownerPostalCode)))
                && (this.ownerCountryCode == input.ownerCountryCode || (this.ownerCountryCode != null && this.ownerCountryCode.Equals(input.ownerCountryCode)))
                && (this.bankName == input.bankName || (this.bankName != null && this.bankName.Equals(input.bankName)))
                && (this.ownerState == input.ownerState || (this.ownerState != null && this.ownerState.Equals(input.ownerState)))
                && (this.bankAccountUUID == input.bankAccountUUID || (this.bankAccountUUID != null && this.bankAccountUUID.Equals(input.bankAccountUUID)))
                && (this.ownerName == input.ownerName || (this.ownerName != null && this.ownerName.Equals(input.ownerName)))
                && (this.bankBicSwift == input.bankBicSwift || (this.bankBicSwift != null && this.bankBicSwift.Equals(input.bankBicSwift)))
                && (this.ownerDateOfBirth == input.ownerDateOfBirth || (this.ownerDateOfBirth != null && this.ownerDateOfBirth.Equals(input.ownerDateOfBirth)))
                && (this.countryCode == input.countryCode || (this.countryCode != null && this.countryCode.Equals(input.countryCode)))
                && (this.ownerStreet == input.ownerStreet || (this.ownerStreet != null && this.ownerStreet.Equals(input.ownerStreet)))
                && (this.bankAccountName == input.bankAccountName || (this.bankAccountName != null && this.bankAccountName.Equals(input.bankAccountName)))
                && (this.ownerHouseNumberOrName == input.ownerHouseNumberOrName || (this.ownerHouseNumberOrName != null && this.ownerHouseNumberOrName.Equals(input.ownerHouseNumberOrName)))
                && (this.bankCode == input.bankCode || (this.bankCode != null && this.bankCode.Equals(input.bankCode)))
                && (this.accountType == input.accountType || (this.accountType != null && this.accountType.Equals(input.accountType)))
                && (this.accountNumber == input.accountNumber || (this.accountNumber != null && this.accountNumber.Equals(input.accountNumber)))
                && (this.primaryAccount == input.primaryAccount || (this.primaryAccount != null && this.primaryAccount.Equals(input.primaryAccount)))
                && (this.bankCity == input.bankCity || (this.bankCity != null && this.bankCity.Equals(input.bankCity)))
                && (this.checkCode == input.checkCode || (this.checkCode != null && this.checkCode.Equals(input.checkCode)))
                && (this.branchCode == input.branchCode || (this.branchCode != null && this.branchCode.Equals(input.branchCode)))
                && (this.taxId == input.taxId || (this.taxId != null && this.taxId.Equals(input.taxId)))
                && (this.iban == input.iban || (this.iban != null && this.iban.Equals(input.iban)))
                && (this.ownerCity == input.ownerCity || (this.ownerCity != null && this.ownerCity.Equals(input.ownerCity)))
                && (this.urlForVerification == input.urlForVerification || (this.urlForVerification != null && this.urlForVerification.Equals(input.urlForVerification)))
                && (this.currencyCode == input.currencyCode || (this.currencyCode != null && this.currencyCode.Equals(input.currencyCode)))
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
                if (this.ownerNationality != null) hashCode = hashCode * 59 + this.ownerNationality.GetHashCode();
                if (this.ownerPostalCode != null) hashCode = hashCode * 59 + this.ownerPostalCode.GetHashCode();
                if (this.ownerCountryCode != null) hashCode = hashCode * 59 + this.ownerCountryCode.GetHashCode();
                if (this.bankName != null) hashCode = hashCode * 59 + this.bankName.GetHashCode();
                if (this.ownerState != null) hashCode = hashCode * 59 + this.ownerState.GetHashCode();
                if (this.bankAccountUUID != null) hashCode = hashCode * 59 + this.bankAccountUUID.GetHashCode();
                if (this.ownerName != null) hashCode = hashCode * 59 + this.ownerName.GetHashCode();
                if (this.bankBicSwift != null) hashCode = hashCode * 59 + this.bankBicSwift.GetHashCode();
                if (this.ownerDateOfBirth != null) hashCode = hashCode * 59 + this.ownerDateOfBirth.GetHashCode();
                if (this.countryCode != null) hashCode = hashCode * 59 + this.countryCode.GetHashCode();
                if (this.ownerStreet != null) hashCode = hashCode * 59 + this.ownerStreet.GetHashCode();
                if (this.bankAccountName != null) hashCode = hashCode * 59 + this.bankAccountName.GetHashCode();
                if (this.ownerHouseNumberOrName != null) hashCode = hashCode * 59 + this.ownerHouseNumberOrName.GetHashCode();
                if (this.bankCode != null) hashCode = hashCode * 59 + this.bankCode.GetHashCode();
                if (this.accountType != null) hashCode = hashCode * 59 + this.accountType.GetHashCode();
                if (this.accountNumber != null) hashCode = hashCode * 59 + this.accountNumber.GetHashCode();
                if (this.primaryAccount != null) hashCode = hashCode * 59 + this.primaryAccount.GetHashCode();
                if (this.bankCity != null) hashCode = hashCode * 59 + this.bankCity.GetHashCode();
                if (this.checkCode != null) hashCode = hashCode * 59 + this.checkCode.GetHashCode();
                if (this.branchCode != null) hashCode = hashCode * 59 + this.branchCode.GetHashCode();
                if (this.taxId != null) hashCode = hashCode * 59 + this.taxId.GetHashCode();
                if (this.iban != null) hashCode = hashCode * 59 + this.iban.GetHashCode();
                if (this.ownerCity != null) hashCode = hashCode * 59 + this.ownerCity.GetHashCode();
                if (this.urlForVerification != null) hashCode = hashCode * 59 + this.urlForVerification.GetHashCode();
                if (this.currencyCode != null) hashCode = hashCode * 59 + this.currencyCode.GetHashCode();
                return hashCode;
            }
        }


        /// <summary>
        /// Convert the given object to string with each line indented by 4 spaces
        /// (except the first line).
        /// </summary>
        private string toIndentedString(object o)
        {
            if (o == null)
            {
                return "null";
            }

            return o.ToString().Replace("\n", "\n    ");
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
