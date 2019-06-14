using Newtonsoft.Json;
using System.Runtime.Serialization;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Enum
{
    /// <summary>
    ///Gets or Sets schedule
    /// </summary>
    /// <value>Gets or Sets schedule</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ScheduleEnum
    {

        /// <summary>
        /// Enum DAILY for "DAILY"
        /// </summary>
        [EnumMember(Value = "DAILY")]
        DAILY,

        /// <summary>
        /// Enum DEFAULT for "DEFAULT"
        /// </summary>
        [EnumMember(Value = "DEFAULT")]
        DEFAULT,

        /// <summary>
        /// Enum HOLD for "HOLD"
        /// </summary>
        [EnumMember(Value = "HOLD")]
        HOLD,

        /// <summary>
        /// Enum MONTHLY for "MONTHLY"
        /// </summary>
        [EnumMember(Value = "MONTHLY")]
        MONTHLY,

        /// <summary>
        /// Enum WEEKLY for "WEEKLY"
        /// </summary>
        [EnumMember(Value = "WEEKLY")]
        WEEKLY
    }
}
