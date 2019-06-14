using System.Collections.Generic;
using Adyen.Constants;

namespace Adyen.Service.Resource.Account
{
    public class CloseAccountHolder : ServiceResource
    {
        public CloseAccountHolder(AbstractService abstractService)
        : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Account/" + ClientConfig.MARKETPAY_ACCOUNT_API_VERSION + "/closeAccountHolder", null)
        {

        }
    }
}
