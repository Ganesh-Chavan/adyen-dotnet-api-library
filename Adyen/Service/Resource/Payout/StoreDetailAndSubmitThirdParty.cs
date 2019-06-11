using System.Collections.Generic;

namespace Adyen.Service.Resource.Payout
{
    public class StoreDetailAndSubmitThirdParty : ServiceResource
    {
        public StoreDetailAndSubmitThirdParty(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.Endpoint + "/pal/servlet/Payout/" + abstractService.Client.ApiVersion + "/storeDetailAndSubmitThirdParty",null)
        {
        }
    }
}
