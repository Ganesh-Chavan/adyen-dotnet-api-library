using Adyen.Model;
using Adyen.Service.Resource.Payout;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Adyen.Service
{
    public class Payout : AbstractService
    {
        private StoreDetailAndSubmitThirdParty _storeDetailAndSubmitThirdParty;
        private ConfirmThirdParty _confirmThirdParty;
        private DeclineThirdParty _declineThirdParty;
        private StoreDetail _storeDetail;
        private SubmitThirdParty _submitThirdparty;

        public Payout(Client client)
            : base(client)
        {
         
            _storeDetailAndSubmitThirdParty=new StoreDetailAndSubmitThirdParty(this);
            _confirmThirdParty=new ConfirmThirdParty(this);
            _declineThirdParty=new DeclineThirdParty(this);
            _storeDetail=new StoreDetail(this);
            _submitThirdparty=new SubmitThirdParty(this);

        }


    }
}
