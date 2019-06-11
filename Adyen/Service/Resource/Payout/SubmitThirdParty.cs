using System.Collections.Generic;

namespace Adyen.Service.Resource.Payout
{
    public class SubmitThirdParty : ServiceResource
    {
        public SubmitThirdParty(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.Endpoint + "/pal/servlet/Payout/" + abstractService.Client.ApiVersion + "/submitThirdParty",null)
        {
        }
    }
}
