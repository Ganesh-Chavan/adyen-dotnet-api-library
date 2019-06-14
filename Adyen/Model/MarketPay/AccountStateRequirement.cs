using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// AccountStateRequirement
    /// </summary>
    [DataContract]
    public partial class AccountStateRequirement : IEquatable<AccountStateRequirement>, IValidatableObject
    {
        /// <summary>
        /// requiredFields.
        /// </summary>
        /// <value>requiredFields.</value>
        [DataMember(Name = "requiredFields", EmitDefaultValue = false)]
        public List<FieldType> requiredFields { get; set; }



        /// <summary>
        /// state.
        /// </summary>
        /// <value>state.</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public AccountState state { get; set; }




        /// <summary>
        /// Initializes a new instance of the <see cref="AccountStateRequirement" /> class.
        /// </summary>
        /// <param name="account">account.</param>
        public AccountStateRequirement(AccountState state = default(AccountState), List<FieldType> requiredFields = default(List<FieldType>))
        {
            this.state = state;
            this.requiredFields = requiredFields;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountStateRequirement {\n");
            sb.Append("  state: ").Append(state).Append("\n");
            sb.Append("  requiredFields: ").Append(requiredFields).Append("\n");
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
            return this.Equals(input as AccountStateRequirement);
        }

        /// <summary>
        /// Returns true if MerchantDevice instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantDevice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountStateRequirement input)
        {
            if (input == null)
                return false;

            return
                (
                    this.state == input.state ||
                    (this.state != null &&
                    this.state.Equals(input.state))
                )
                &&
                (
                    this.requiredFields == input.requiredFields ||
                    (this.requiredFields != null &&
                     this.requiredFields.Equals(input.requiredFields))
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
                if (this.state != null)
                    hashCode = hashCode * 59 + this.state.GetHashCode();
                if (this.requiredFields != null)
                    hashCode = hashCode * 59 + this.requiredFields.GetHashCode();
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
