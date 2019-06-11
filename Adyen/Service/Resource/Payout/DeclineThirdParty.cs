using System.Collections.Generic;

namespace Adyen.Service.Resource.Payout
{
    public class DeclineThirdParty : ServiceResource
    {
        public DeclineThirdParty(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.Endpoint + "/pal/servlet/Payout/" + abstractService.Client.ApiVersion + "/declineThirdParty",null)
        {
        }
    }
}
