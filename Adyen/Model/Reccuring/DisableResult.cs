﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Adyen.Model.Reccuring
{
    [DataContract]
    public class DisableResult
    {
        [DataMember(Name = "response", EmitDefaultValue = false)]
        public string Response { get; set; }

        [DataMember(Name = "details", EmitDefaultValue = false)]
        public List<RecurringDetail> Details { get; set; }

        [DataMember(Name = "shopperReference", EmitDefaultValue = false)]
        public string ShopperReference { get; set; }

        [DataMember(Name = "invalidOneclickContracts", EmitDefaultValue = false)]
        public string InvalidOneclickContracts { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisableRequest {\n");
            sb.Append("  response: ").Append(Response).Append("\n");
            sb.Append("  details: ").Append(Details).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
