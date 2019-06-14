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
    public partial class BinDetail
    {
        /// <summary>
        /// IssuerCountry.
        /// </summary>
        /// <value>Merchant device reference.</value>
        [DataMember(Name = "issuerCountry", EmitDefaultValue = false)]
        public string issuerCountry { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BinDetail {\n");
            sb.Append("  issuerCountry: ").Append(issuerCountry).Append("\n");
    
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
