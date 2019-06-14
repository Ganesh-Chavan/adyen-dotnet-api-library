using System.Collections.Generic;
using Adyen.Constants;

namespace Adyen.Service.Resource.Account
{
    public class GetUploadedDocuments : ServiceResource
    {
        public GetUploadedDocuments(AbstractService abstractService)
        : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Account/" + ClientConfig.MARKETPAY_ACCOUNT_API_VERSION + "/getUploadedDocuments", null)
        {

        }
    }
}
