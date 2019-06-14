using Adyen.Model.AdditionalData;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Adyen.Model.ApplicationInformation;
using Adyen.Util;
using System.Text;

namespace Adyen.Model.Payout
{
    [DataContract]
    public class ModifyResponse
    {
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        public string pspReference { get; set; }

        [DataMember(Name = "response", EmitDefaultValue = false)]
        public string response { get; set; }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ModifyResponse {\n");
            sb.Append("    pspReference: ").Append(toIndentedString(pspReference)).Append("\n");
            sb.Append("    response: ").Append(toIndentedString(response)).Append("\n");
            sb.Append("}");
            return sb.ToString();
        }

        /// <summary>
        /// Convert the given object to string with each line indented by 4 spaces (except the first line).
        /// </summary>
        private string toIndentedString(object o)
        {
            if (o == null)
            {
                return "null";
            }

            return o.ToString().Replace("\n", "\n    ");
        }
    }
}
