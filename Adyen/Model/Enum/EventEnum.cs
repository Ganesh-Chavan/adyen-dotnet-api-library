using Newtonsoft.Json;
using System.Runtime.Serialization;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Enum
{
    /// <summary>
    ///Gets or Sets event
    /// </summary>
    /// <value>Gets or Sets event</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EventEnum
    {

        /// <summary>
        /// Enum InactivateAccount for "INACTIVATEACCOUNT"
        /// </summary>
        [EnumMember(Value = "InactivateAccount")]
        INACTIVATEACCOUNT,

        /// <summary>
        /// Enum RefundNotPaidOutTransfers for "REFUNDNOTPAIDOUTTRANSFERS"
        /// </summary>
        [EnumMember(Value = "RefundNotPaidOutTransfers")]
        REFUNDNOTPAIDOUTTRANSFERS,

        /// <summary>
        /// Enum UNKNOWN for "UNKNOWN"
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN
    }
}
