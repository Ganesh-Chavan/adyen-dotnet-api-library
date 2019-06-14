using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Adyen.Constants;
using Adyen.Model.ApplicationInformation;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.MarketPay.Notification
{


    /// <summary>
    /// AccountCreatedContent
    /// </summary>
    [DataContract]
    public class AccountCreatedContent : IEquatable<AccountCreatedContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountCreatedContent" /> class.
        /// </summary>
        public AccountCreatedContent()
        {
          
        }

        /// <summary>
        /// Gets or Sets pspReference
        /// </summary>
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        public string PspReference { get; private set; }

        /// <summary>
        /// Gets or Sets accountHolderCode
        /// </summary>
        [DataMember(Name = "accountHolderCode", EmitDefaultValue = false)]
        public string AccountHolderCode { get; private set; }

        /// <summary>
        /// Gets or Sets accountCode
        /// </summary>
        [DataMember(Name = "accountCode", EmitDefaultValue = false)]
        public string AccountCode { get; private set; }

  
       // [DataMember(Name = "status", EmitDefaultValue = false)]
        //public string status { get; private set; }

        // <summary>
        /// Indicator of how long this shopper account exists in the merchant&#39;s environment.
        /// </summary>
        /// <value>Indicator of how long this shopper account exists in the merchant&#39;s environment.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum status
        {

            /// <summary>
            /// Enum NotApplicable for value: notApplicable
            /// </summary>
            [EnumMember(Value = "notApplicable")]
            NotApplicable = 1,

            /// <summary>
            /// Enum ThisTransaction for value: thisTransaction
            /// </summary>
            [EnumMember(Value = "thisTransaction")]
            ThisTransaction = 2,

            /// <summary>
            /// Enum LessThan30Days for value: lessThan30Days
            /// </summary>
            [EnumMember(Value = "lessThan30Days")]
            LessThan30Days = 3,

            /// <summary>
            /// Enum From30To60Days for value: from30To60Days
            /// </summary>
            [EnumMember(Value = "from30To60Days")]
            From30To60Days = 4,

            /// <summary>
            /// Enum MoreThan60Days for value: moreThan60Days
            /// </summary>
            [EnumMember(Value = "moreThan60Days")]
            MoreThan60Days = 5
        }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountCreatedContent {\n");
            sb.Append("  AdyenLibrary: ").Append(AdyenLibrary).Append("\n");
            sb.Append("  AdyenPaymentSource: ").Append(AdyenPaymentSource).Append("\n");
            sb.Append("  ExternalPlatform: ").Append(ExternalPlatform).Append("\n");
            sb.Append("  MerchantApplication: ").Append(MerchantApplication).Append("\n");
            sb.Append("  MerchantDevice: ").Append(MerchantDevice).Append("\n");
            sb.Append("  ShopperInteractionDevice: ").Append(ShopperInteractionDevice).Append("\n");
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
            return this.Equals(input as ApplicationInformation.ApplicationInfo);
        }

        /// <summary>
        /// Returns true if ApplicationInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationInformation.ApplicationInfo input)
        {
            if (input == null)
                return false;

            return
                (
                    this.AdyenLibrary == input.AdyenLibrary ||
                    (this.AdyenLibrary != null &&
                    this.AdyenLibrary.Equals(input.AdyenLibrary))
                ) &&
                (
                    this.AdyenPaymentSource == input.AdyenPaymentSource ||
                    (this.AdyenPaymentSource != null &&
                    this.AdyenPaymentSource.Equals(input.AdyenPaymentSource))
                ) &&
                (
                    this.ExternalPlatform == input.ExternalPlatform ||
                    (this.ExternalPlatform != null &&
                    this.ExternalPlatform.Equals(input.ExternalPlatform))
                ) &&
                (
                    this.MerchantApplication == input.MerchantApplication ||
                    (this.MerchantApplication != null &&
                    this.MerchantApplication.Equals(input.MerchantApplication))
                ) &&
                (
                    this.MerchantDevice == input.MerchantDevice ||
                    (this.MerchantDevice != null &&
                    this.MerchantDevice.Equals(input.MerchantDevice))
                ) &&
                (
                    this.ShopperInteractionDevice == input.ShopperInteractionDevice ||
                    (this.ShopperInteractionDevice != null &&
                    this.ShopperInteractionDevice.Equals(input.ShopperInteractionDevice))
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
                if (this.AdyenLibrary != null)
                    hashCode = hashCode * 59 + this.AdyenLibrary.GetHashCode();
                if (this.AdyenPaymentSource != null)
                    hashCode = hashCode * 59 + this.AdyenPaymentSource.GetHashCode();
                if (this.ExternalPlatform != null)
                    hashCode = hashCode * 59 + this.ExternalPlatform.GetHashCode();
                if (this.MerchantApplication != null)
                    hashCode = hashCode * 59 + this.MerchantApplication.GetHashCode();
                if (this.MerchantDevice != null)
                    hashCode = hashCode * 59 + this.MerchantDevice.GetHashCode();
                if (this.ShopperInteractionDevice != null)
                    hashCode = hashCode * 59 + this.ShopperInteractionDevice.GetHashCode();
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
