using Adyen.Model.AdditionalData;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Adyen.Model.ApplicationInformation;
using Adyen.Util;

namespace Adyen.Model.Payout
{
    [DataContract]
    public class ModifyRequest
    {
        [DataMember(Name = "merchantAccount", EmitDefaultValue = false)]
        public string merchantAccount { get; set; }

        [DataMember(Name = "originalReference", EmitDefaultValue = false)]
        public string originalReference { get; set; }

        [DataMember(Name = "additionalData", EmitDefaultValue = false)]
        public Dictionary<string, string> additionalData { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ModifyRequest {\n");
            sb.Append("    merchantAccount: ").Append(toIndentedString(merchantAccount)).Append("\n");
            sb.Append("    originalReference: ").Append(toIndentedString(originalReference)).Append("\n");
            sb.Append("    additionalData: ").Append(toIndentedString(additionalData)).Append("\n");
            sb.Append("}");
            return sb.ToString();
            }

    /**
     * Convert the given object to string with each line indented by 4 spaces (except the first line).
     */
    private string toIndentedString(Object o) {
        if (o == null) {
            return "null";
        }
        return o.ToString().Replace("\n", "\n    ");
    }

    }
}