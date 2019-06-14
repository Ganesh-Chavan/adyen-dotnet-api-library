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
    public enum StatusEnum
    {

        /// <summary>
        /// Enum Active for "ACTIVE"
        /// </summary>
        [EnumMember(Value = "Active")]
        ACTIVE,

        /// <summary>
        /// Enum CLOSED for "Closed"
        /// </summary>
        [EnumMember(Value = "Closed")]
        CLOSED,

        /// <summary>
        /// Enum Inactive for "INACTIVE"
        /// </summary>
        [EnumMember(Value = "Inactive")]
        INACTIVE,

        /// <summary>
        /// Enum Suspended for "SUSPENDED"
        /// </summary>
        [EnumMember(Value = "Suspended")]
        SUSPENDED

       
    }
}
