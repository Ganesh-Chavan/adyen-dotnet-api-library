using Newtonsoft.Json;
using System.Runtime.Serialization;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Enum
{
    /// <summary>
    ///Gets or Sets account processing state
    /// </summary>
    /// <value>Gets or Sets schedule</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StateTypeEnum
    {

        /// <summary>
        /// Enum LimitedPayout for "LIMITEDPAYOUT"
        /// </summary>
        [EnumMember(Value = "LimitedPayout")]
        LIMITEDPAYOUT,

        /// <summary>
        /// Enum LimitedProcessing for "LIMITEDPROCESSING"
        /// </summary>
        [EnumMember(Value = "LimitedProcessing")]
        LIMITEDPROCESSING,

        /// <summary>
        /// Enum LimitlessPayout for "LIMITLESSPAYOUT"
        /// </summary>
        [EnumMember(Value = "LimitlessPayout")]
        LIMITLESSPROCESSING,

        /// <summary>
        /// Enum Payout for "LIMITLESSPROCESSING"
        /// </summary>
        [EnumMember(Value = "Payout")]
        PAYOUT,

        /// <summary>
        /// Enum Processing for "PROCESSING"
        /// </summary>
        [EnumMember(Value = "Processing")]
        PROCESSING


    }
}
