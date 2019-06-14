/*
 *                       ######
 *                       ######
 * ############    ####( ######  #####. ######  ############   ############
 * #############  #####( ######  #####. ######  #############  #############
 *        ######  #####( ######  #####. ######  #####  ######  #####  ######
 * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
 * ###### ######  #####( ######  #####. ######  #####          #####  ######
 * #############  #############  #############  #############  #####  ######
 *  ############   ############  #############   ############  #####  ######
 *                                      ######
 *                               #############
 *                               ############
 *
 * Adyen .NET API Library
 *
 * Copyright (c) 2019 Adyen B.V.
 * This file is open source and available under the MIT license.
 * See the LICENSE file for more info.
 */
using Adyen.Model.AdditionalData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Adyen.Model.ApplicationInformation;
using Adyen.Util;
using Newtonsoft.Json;


namespace Adyen.Model.MarketPay
{

    /// <summary>
    /// Account
    /// </summary>
    [DataContract]
    public partial class Account : IEquatable<Account>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        /// <param name="accountCode">accountCode..</param>
        /// <param name="beneficiaryAccount">beneficiaryAccount..</param>
        /// <param name="beneficiaryMerchantReference">beneficiaryMerchantReference.</param>
        public Account(string accountCode = default(string), string status = default(string), string beneficiaryAccount = default(string), string beneficiaryMerchantReference = default(string), PayoutScheduleResponse payoutSchedule = default(PayoutScheduleResponse))
        {
            this.accountCode = accountCode;
            this.status = status;
            this.beneficiaryAccount = beneficiaryAccount;
            this.beneficiaryMerchantReference = beneficiaryMerchantReference;
            this.payoutSchedule = payoutSchedule;

        }

        /// <summary>
        /// accountCode
        /// </summary>
        /// <value>accountCode.</value>
        [DataMember(Name = "accountCode", EmitDefaultValue = false)]
        public string accountCode { get; set; }

        /// <summary>
        /// beneficiaryAccount  Account's beneficiary account
        /// </summary>
        /// <value>beneficiaryAccount.</value>
        [DataMember(Name = "beneficiaryAccount", EmitDefaultValue = false)]
        public string beneficiaryAccount { get; set; }

        /// <summary>
        /// description. Reason beneficiary was setup
        /// </summary>
        /// <value>description.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string description { get; set; }


        /// <summary>
        /// payoutSchedule. Account's payout schedule
        /// </summary>
        /// <value>payoutSchedule.</value>
        [DataMember(Name = "payoutSchedule", EmitDefaultValue = false)]
        public PayoutScheduleResponse payoutSchedule { get; set; }

        /// <summary>
        /// status
        /// </summary>
        /// <value>status.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string status { get; set; }




        /// <summary>
        /// beneficiaryMerchantReference. Reason beneficiary was setup
        /// </summary>
        /// <value>beneficiaryMerchantReference.</value>
        [DataMember(Name = "beneficiaryMerchantReference", EmitDefaultValue = false)]
        public string beneficiaryMerchantReference { get; set; }


        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append("class Account {\n");
            sb.Append("  accountCode: ").Append(accountCode).Append("\n");
            sb.Append("  beneficiaryAccount: ").Append(beneficiaryAccount).Append("\n");
            sb.Append("  beneficiaryMerchantReference: ").Append(beneficiaryMerchantReference).Append("\n");
            sb.Append("  description: ").Append(description).Append("\n");
            sb.Append("  payoutSchedule: ").Append(payoutSchedule).Append("\n");
            sb.Append("  status: ").Append(status).Append("\n");
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
        /// Returns true if MerchantDevice instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantDevice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Account input)
        {
            if (input == null)
                return false;

            return
                (
                    this.accountCode == input.accountCode ||
                    (this.accountCode != null &&
                    this.accountCode.Equals(input.accountCode))
                ) &&
                (
                    this.beneficiaryAccount == input.beneficiaryAccount ||
                    (this.beneficiaryAccount != null &&
                    this.beneficiaryAccount.Equals(input.beneficiaryAccount))
                ) &&
                (
                    this.beneficiaryMerchantReference == input.beneficiaryMerchantReference ||
                    (this.beneficiaryMerchantReference != null &&
                    this.beneficiaryMerchantReference.Equals(input.beneficiaryMerchantReference))
                )
                &&
                (
                    this.payoutSchedule == input.payoutSchedule ||
                    (this.payoutSchedule != null &&
                     this.payoutSchedule.Equals(input.payoutSchedule))
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
                if (this.accountCode != null)
                    hashCode = hashCode * 59 + this.accountCode.GetHashCode();
                if (this.beneficiaryAccount != null)
                    hashCode = hashCode * 59 + this.beneficiaryAccount.GetHashCode();
                if (this.beneficiaryMerchantReference != null)
                    hashCode = hashCode * 59 + this.beneficiaryMerchantReference.GetHashCode();
                if (this.payoutSchedule != null)
                    hashCode = hashCode * 59 + this.payoutSchedule.GetHashCode();
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


