using System.Collections.Generic;
using Adyen.Constants;

namespace Adyen.Service.Resource.Account
{
    public class UpdateAccount : ServiceResource
    {
        public UpdateAccount(AbstractService abstractService)
        : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Account/" + ClientConfig.MARKETPAY_ACCOUNT_API_VERSION + "/updateAccount", null)
        {

        }
    }
}
