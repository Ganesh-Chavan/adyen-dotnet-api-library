using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// AccountHolderDetails
    /// </summary>
    [DataContract]
    public partial class AccountHolderDetails : IEquatable<AccountHolderDetails>, IValidatableObject
    {
        /// <summary>
        /// address.account holder address
        /// </summary>
        /// <value>address.</value>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public Address address { get; set; }

        /// <summary>
        /// phoneNumber.account holder phone number
        /// </summary>
        /// <value>phoneNumber.</value>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
        public PhoneNumber phoneNumber { get; set; }

        /// <summary>
        /// metadata.a map of key/value pairs of metadata sent by merchant
        /// </summary>
        /// <value> Dictionary<string,string>.</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> metadata { get; set; } = new Dictionary<string, string>();


        /// <summary>
        /// bankAccountDetails.Populate the virtual bankAccountDetails to bypass the bankAccountDetailsContainer list
        /// </summary>
        /// <value> bankAccountDetails</value>
        [DataMember(Name = "bankAccountDetails", EmitDefaultValue = false)]
        public List<BankAccountDetail> bankAccountDetails { get; set; }

        /// <summary>
        /// individualDetails.properties specific to Individual legal entities. Populated only if the account holder represents an Individual legal entity
        /// </summary>
        /// <value> individualDetails</value>
        [DataMember(Name = "individualDetails", EmitDefaultValue = false)]
        public IndividualDetails individualDetails { get; set; }

        /// <summary>
        /// webAddress.
        /// </summary>
        /// <value>webAddress.</value>
        [DataMember(Name = "webAddress", EmitDefaultValue = false)]
        public string webAddress { get; set; }


        /// <summary>
        /// merchantCategoryCode.
        /// </summary>
        /// <value>merchantCategoryCode.</value>
        [DataMember(Name = "merchantCategoryCode", EmitDefaultValue = false)]
        public string merchantCategoryCode { get; set; }

        /// <summary>
        /// fullPhoneNumber.
        /// </summary>
        /// <value>fullPhoneNumber.</value>
        [DataMember(Name = "fullPhoneNumber", EmitDefaultValue = false)]
        public string fullPhoneNumber { get; set; }

        /// <summary>
        /// businessDetails.
        /// </summary>
        /// <value>businessDetails.</value>
        [DataMember(Name = "businessDetails", EmitDefaultValue = false)]
        public BusinessDetails businessDetails { get; set; }

        /// <summary>
        /// email.
        /// </summary>
        /// <value>email.</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string email { get; set; }



        /// <summary>
        /// Initializes a new instance of the <see cref="AccountHolderDetails" /> class.
        /// </summary>
        /// <param name="account">account.</param>
        public AccountHolderDetails(IndividualDetails individualDetails = default(IndividualDetails))
        {
            this.individualDetails = individualDetails;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountHolderDetails {\n");
            sb.Append("    metadata: ").Append( metadata).Append("\n");
            sb.Append("    address: ").Append( address).Append("\n");
            sb.Append("    phoneNumber: ").Append( phoneNumber).Append("\n");
            sb.Append("    bankAccountDetails: ").Append( bankAccountDetails).Append("\n");
            sb.Append("    individualDetails: ").Append( individualDetails).Append("\n");
            sb.Append("    webAddress: ").Append( webAddress).Append("\n");
            sb.Append("    merchantCategoryCode: ").Append( merchantCategoryCode).Append("\n");
            sb.Append("    fullPhoneNumber: ").Append( fullPhoneNumber).Append("\n");
            sb.Append("    businessDetails: ").Append( businessDetails).Append("\n");
            sb.Append("    email: ").Append( email).Append("\n");
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
            return this.Equals(input as AccountHolderDetails);
        }

        /// <summary>
        /// Returns true if MerchantDevice instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantDevice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountHolderDetails input)
        {
            if (input == null)
                return false;

            return
                (
                    this.metadata == input.metadata ||
                    (this.metadata != null &&
                    this.metadata.Equals(input.metadata))
                )
                &&
                (
                    this.address == input.address ||
                    (this.address != null &&
                     this.address.Equals(input.address))
                ) &&
                (
                    this.phoneNumber == input.phoneNumber ||
                    (this.phoneNumber != null &&
                     this.phoneNumber.Equals(input.phoneNumber))
                ) &&
                (
                    this.bankAccountDetails == input.bankAccountDetails ||
                    (this.bankAccountDetails != null &&
                     this.bankAccountDetails.Equals(input.bankAccountDetails))
                ) &&
                (
                    this.individualDetails == input.individualDetails ||
                    (this.individualDetails != null &&
                     this.individualDetails.Equals(input.individualDetails))
                ) &&
                (
                    this.webAddress == input.webAddress ||
                    (this.webAddress != null &&
                     this.webAddress.Equals(input.webAddress))
                ) &&
                (
                    this.merchantCategoryCode == input.merchantCategoryCode ||
                    (this.merchantCategoryCode != null &&
                     this.merchantCategoryCode.Equals(input.merchantCategoryCode))
                ) &&
                (
                    this.fullPhoneNumber == input.fullPhoneNumber ||
                    (this.fullPhoneNumber != null &&
                     this.fullPhoneNumber.Equals(input.fullPhoneNumber))
                ) &&
                (
                    this.businessDetails == input.businessDetails ||
                    (this.businessDetails != null &&
                     this.businessDetails.Equals(input.businessDetails))
                ) &&
                (
                    this.email == input.email ||
                    (this.email != null &&
                     this.email.Equals(input.email))
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
                if (this.metadata != null)
                    hashCode = hashCode * 59 + this.metadata.GetHashCode();
                if (this.address != null)
                    hashCode = hashCode * 59 + this.address.GetHashCode();
                if (this.phoneNumber != null)
                    hashCode = hashCode * 59 + this.phoneNumber.GetHashCode();
                if (this.bankAccountDetails != null)
                    hashCode = hashCode * 59 + this.bankAccountDetails.GetHashCode();
                if (this.individualDetails != null)
                    hashCode = hashCode * 59 + this.individualDetails.GetHashCode();
                if (this.webAddress != null)
                    hashCode = hashCode * 59 + this.webAddress.GetHashCode();
                if (this.merchantCategoryCode != null)
                    hashCode = hashCode * 59 + this.merchantCategoryCode.GetHashCode();
                if (this.fullPhoneNumber != null)
                    hashCode = hashCode * 59 + this.fullPhoneNumber.GetHashCode();
                if (this.businessDetails != null)
                    hashCode = hashCode * 59 + this.businessDetails.GetHashCode();
                if (this.email != null)
                    hashCode = hashCode * 59 + this.email.GetHashCode();

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
    }
}
