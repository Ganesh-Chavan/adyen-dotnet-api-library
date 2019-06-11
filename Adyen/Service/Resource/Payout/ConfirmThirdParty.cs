using System.Collections.Generic;

namespace Adyen.Service.Resource.Payout
{
    public class ConfirmThirdParty : ServiceResource
    {
        public ConfirmThirdParty(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.Endpoint + "/pal/servlet/Payout/" + abstractService.Client.ApiVersion + "/confirmThirdParty",null)
        {
        }
    }
}
