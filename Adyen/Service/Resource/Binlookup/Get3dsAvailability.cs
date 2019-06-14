using System.Collections.Generic;
using Adyen.Constants;

namespace Adyen.Service.Resource.Binlookup
{
    public class Get3dsAvailability : ServiceResource
    {
        public Get3dsAvailability(AbstractService abstractService)
        : base(abstractService, abstractService.Client.Config.CheckoutEndpoint + Client.BIN_LOOKUP_PAL_SUFFIX + Client.BIN_LOOKUP_API_VERSION  +"/get3dsAvailability",
         new List<string> {"merchantAccount", "cardNumber" })
        {

        }
    }
}
