using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Adyen.Model.Modification
{
    [DataContract]
    public class TechnicalCancelRequest : AbstractModificationRequest<CancelOrRefundRequest>
    {

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TechnicalCancelRequest {\n");
            sb.Append(base.ToString());
            sb.Append("}");
            return sb.ToString();
        }
    }
}
