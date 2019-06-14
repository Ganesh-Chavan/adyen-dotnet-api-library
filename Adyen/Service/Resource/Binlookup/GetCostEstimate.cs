using System.Collections.Generic;
using Adyen.Constants;

namespace Adyen.Service.Resource.Binlookup
{
    public class GetCostEstimate : ServiceResource
    {
        public GetCostEstimate(AbstractService abstractService)
        : base(abstractService, abstractService.Client.Config.CheckoutEndpoint + Client.BIN_LOOKUP_PAL_SUFFIX + Client.BIN_LOOKUP_API_VERSION  +"/getCostEstimate",
         new List<string> {"merchantAccount", "amount" })
        {

        }
    }
}
