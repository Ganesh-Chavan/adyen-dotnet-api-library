using System.Collections.Generic;
using Adyen.Constants;

namespace Adyen.Service.Resource.Fund
{
    public class AccountHolderTransactionList : ServiceResource
    {
        public AccountHolderTransactionList(AbstractService abstractService)
        : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Fund/" + ClientConfig.MARKETPAY_FUND_API_VERSION + "/accountHolderTransactionList", null)
        {

        }
    }
}
