using System.Collections.Generic;
using Adyen.Constants;

namespace Adyen.Service.Resource.Fund
{
    public class TransferFunds : ServiceResource
    {
        public TransferFunds(AbstractService abstractService)
        : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Fund/" + ClientConfig.MARKETPAY_FUND_API_VERSION + "/transferFunds", null)
        {

        }
    }
}
