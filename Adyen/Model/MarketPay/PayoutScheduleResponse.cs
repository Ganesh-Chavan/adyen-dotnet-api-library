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
    /// Account
    /// </summary>
    [DataContract]
    public partial class PayoutScheduleResponse : IEquatable<PayoutScheduleResponse>, IValidatableObject
    {


        /// <summary>
        /// schedule
        /// </summary>
        /// <value>schedule.</value>
        [DataMember(Name = "schedule", EmitDefaultValue = false)]
        public ScheduleEnum schedule { get; set; }

        /// <summary>
        /// nextScheduledPayout
        /// </summary>
        /// <value>nextScheduledPayout.</value>
        [DataMember(Name = "nextScheduledPayout", EmitDefaultValue = false)]
        public DateTime nextScheduledPayout { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayoutScheduleResponse {\n");
            sb.Append("  schedule: ").Append(schedule).Append("\n");
            sb.Append("  nextScheduledPayout: ").Append(nextScheduledPayout).Append("\n");
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
            return this.Equals(input as Account);
        }

        /// <summary>
        /// Returns true if PayoutScheduleResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PayoutScheduleResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayoutScheduleResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    this.schedule == input.schedule ||
                    (this.schedule != null &&
                    this.schedule.Equals(input.schedule))
                ) &&
                (
                    this.nextScheduledPayout == input.nextScheduledPayout ||
                    (this.nextScheduledPayout != null &&
                    this.nextScheduledPayout.Equals(input.nextScheduledPayout))
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
                if (this.schedule != null)
                    hashCode = hashCode * 59 + this.schedule.GetHashCode();
                if (this.nextScheduledPayout != null)
                    hashCode = hashCode * 59 + this.nextScheduledPayout.GetHashCode();
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
