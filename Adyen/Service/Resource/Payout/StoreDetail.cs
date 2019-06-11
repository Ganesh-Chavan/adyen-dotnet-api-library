using System.Collections.Generic;

namespace Adyen.Service.Resource.Payout
{
    public class StoreDetail : ServiceResource
    {
        public StoreDetail(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.Endpoint + "/pal/servlet/Payout/" + abstractService.Client.ApiVersion + "/storeDetail",null)
        {
        }
    }
}
