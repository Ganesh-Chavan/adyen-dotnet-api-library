using System.Collections.Generic;
using Adyen.Constants;

namespace Adyen.Service.Resource.Account
{
    public class CreateAccountHolder : ServiceResource
    {
        public CreateAccountHolder(AbstractService abstractService)
        : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Account/" + ClientConfig.MARKETPAY_ACCOUNT_API_VERSION + "/createAccountHolder", null)
        {

        }
    }
}
