using Adyen.Model.AdditionalData;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Adyen.Model.ApplicationInformation;
using Adyen.Util;

namespace Adyen.Model.Binlookup
{

    [DataContract]
    public partial class CardBin
    {
        /// <summary>
        /// bin.The first 6 digit of the card number. Enable this field via merchant account settings.
        /// </summary>
        /// <value>bin.</value>
        [DataMember(Name = "bin", EmitDefaultValue = false)]
        public string bin { get; set; }


        /// <summary>
        /// If true, it indicates a commercial card. Enable this field via merchant account settings..
        /// </summary>
        /// <value>true.</value>
        [DataMember(Name = "commercial", EmitDefaultValue = false)]
        public bool commercial { get; set; }

        /// <summary>
        /// fundingSource.
        ///  The card funding source. Valid values are: * CREDIT * DEBIT * PREPAID * PREPAID_RELOADABLE * DEFERRED_DEBIT * CHARGED &gt; Enable this field via merchant account settings.
        /// </summary>
        /// <value>fundingSource.</value>
        [DataMember(Name = "fundingSource", EmitDefaultValue = false)]
        public string fundingSource { get; set; }

        /// <summary>
        /// fundsAvailability.
        ///     * Indicates availability of funds.  Visa: * \&quot;I\&quot; (fast funds are supported) * \&quot;N\&quot; (otherwise)  Mastercard: * \&quot;I\&quot; (product type is Prepaid or Debit, or issuing
        /// * country is in CEE/HGEM list) * \&quot;N\&quot; (otherwise) &gt; Returned when you verify a card BIN or estimate costs, and only if &#x60;payoutEligible&#x60; is different from \&quot;N\&quot;
        /// * or \&quot;U\&quot;.
        /// </summary>
        /// <value>fundsAvailability</value>
        [DataMember(Name = "fundsAvailability", EmitDefaultValue = false)]
        public string fundsAvailability { get; set; }

        /// <summary>
        /// issuingBank.The issuing bank of the card.
        /// </summary>
        /// <value>issuingBank.</value>
        [DataMember(Name = "issuingBank", EmitDefaultValue = false)]
        public string issuingBank { get; set; }

        /// <summary>
        /// IssuerCountry. The country where the card was issued from.
        /// </summary>
        /// <value>Merchant device reference.</value>
        [DataMember(Name = "issuerCountry", EmitDefaultValue = false)]
        public string issuingCountry { get; set; }

        /// <summary>
        /// issuingCurrency. The currency of the card.
        /// </summary>
        /// <value>issuingCurrency.</value>
        [DataMember(Name = "issuingCurrency", EmitDefaultValue = false)]
        public string issuingCurrency { get; set; }

        /// <summary>
        /// paymentMethod. The payment method associated with the card (e.g. visa, mc, or amex).
        /// </summary>
        /// <value>paymentMethod.</value>
        [DataMember(Name = "paymentMethod", EmitDefaultValue = false)]
        public string paymentMethod { get; set; }

        /// <summary>
        /// payoutEligible.   * Indicates whether a payout is eligible or not for this card.  Visa: * \&quot;Y\&quot; * \&quot;N\&quot;  Mastercard: * \&quot;Y\&quot; (domestic and cross-border) * \&quot;D\&quot; (only
        /// * domestic) * \&quot;N\&quot; (no MoneySend) * \&quot;U\&quot; (unknown) &gt; Returned when you verify a card BIN or estimate costs, and only if &#x60;payoutEligible&#x60; is different from
        /// * \&quot;N\&quot; or \&quot;U\&quot;.
        /// </summary>
        /// <value>payoutEligible.</value>
        [DataMember(Name = "payoutEligible", EmitDefaultValue = false)]
        public string payoutEligible { get; set; }

        /// <summary>
        /// summary.The last four digits of the card number.
        /// </summary>
        /// <value>summary.</value>
        [DataMember(Name = "summary", EmitDefaultValue = false)]
        public string summary { get; set; }



    }
}
