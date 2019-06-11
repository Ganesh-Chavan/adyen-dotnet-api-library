using Adyen.Model.AdditionalData;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Adyen.Model.ApplicationInformation;
using Adyen.Util;

namespace Adyen.Model
{
    [DataContract]
    public class ModifyRequest
    {
       
        [DataMember(Name = "merchantAccount", EmitDefaultValue = false)]
        private string merchantAccount = null;  

        [DataMember(Name = "originalReference", EmitDefaultValue = false)]
        private string originalReference = null;  

        [DataMember(Name = "additionalData", EmitDefaultValue = false)]
        private Dictionary<string, string> additionalData = null;  


    public string getMerchantAccount() {
        return merchantAccount;
    }

    public void setMerchantAccount(string merchantAccount) {
        this.merchantAccount = merchantAccount;
    }

    public string getOriginalReference() {
        return originalReference;
    }

    public void setOriginalReference(string originalReference) {
        this.originalReference = originalReference;
    }

    public Dictionary<string, string> getAdditionalData() {
        return additionalData;
    }

    public void setAdditionalData(Dictionary<string, string> additionalData) {
        this.additionalData = additionalData;
    }

   public override string ToString() {
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