using Newtonsoft.Json;
using System.Runtime.Serialization;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Enum
{
    /// <summary>
    ///Gets or Sets TransactionStatusesEnum
    /// </summary>
    /// <value>Gets or Sets TransactionStatusesEnum </value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionStatusesEnum
    {

        /// <summary>
        /// Enum Chargeback for "CHARGEBACK"
        /// </summary>
        [EnumMember(Value = "Chargeback")]
        CHARGEBACK,

        /// <summary>
        /// Enum ChargebackReceived for "CHARGEBACKRECEIVED"
        /// </summary>
        [EnumMember(Value = "ChargebackReceived")]
        CHARGEBACKRECEIVED,

        /// <summary>
        /// Enum ChargebackReversed for "CHARGEBACKREVERSED"
        /// </summary>
        [EnumMember(Value = "ChargebackReversed")]
        CHARGEBACKREVERSED,

        /// <summary>
        /// Enum ChargebackReversedReceived for "CHARGEBACKREVERSEDRECEIVED"
        /// </summary>
        [EnumMember(Value = "ChargebackReversedReceived")]
        CHARGEBACKREVERSEDRECEIVED,

        /// <summary>
        /// Enum CreditFailed for "CREDITFAILED"
        /// </summary>
        [EnumMember(Value = "CreditFailed")]
        CREDITFAILED,

        /// <summary>
        /// Enum Credited for "CREDITED"
        /// </summary>
        [EnumMember(Value = "Credited")]
        CREDITED,

        /// <summary>
        /// Enum DebitFailed for "DEBITFAILED"
        /// </summary>
        [EnumMember(Value = "DebitFailed")]
        DEBITFAILED,

        /// <summary>
        /// Enum DebitReversedReceived for "DEBITREVERSEDRECEIVED"
        /// </summary>
        [EnumMember(Value = "DebitReversedReceived")]
        DEBITREVERSEDRECEIVED,

        /// <summary>
        /// Enum DebitedReversed for "DEBITEDREVERSED"
        /// </summary>
        [EnumMember(Value = "DebitedReversed")]
        DEBITEDREVERSED,

   
        /// <summary>
        /// Enum FundTransfer for "FUNDTRANSFER"
        /// </summary>
        [EnumMember(Value = "FundTransfer")]
        FUNDTRANSFER,

        /// <summary>
        /// Enum Payout for "PAYOUT"
        /// </summary>
        [EnumMember(Value = "Payout")]
        PAYOUT,


        /// <summary>
        /// Enum PayoutReversed for "PAYOUTREVERSED"
        /// </summary>
        [EnumMember(Value = "PayoutReversed")]
        PAYOUTREVERSED,
        /// <summary>
        /// Enum PendingCredit for "PENDINGCREDIT"
        /// </summary>
        [EnumMember(Value = "PendingCredit")]
        PENDINGCREDIT,
        /// <summary>
        /// Enum PendingDebit for "PENDINGDEBIT"
        /// </summary>
        [EnumMember(Value = "PendingDebit")]
        PENDINGDEBIT,
        /// <summary>
        /// Enum PendingFundTransfer for "PENDINGFUNDTRANSFER"
        /// </summary>
        [EnumMember(Value = "PendingFundTransfer")]
        PENDINGFUNDTRANSFER

    }
}
