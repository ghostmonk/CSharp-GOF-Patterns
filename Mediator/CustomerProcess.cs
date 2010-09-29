using Mediator.Core;
using Mediator.Shops;

namespace Mediator
{
    class CustomerProcess : Core.Mediator
    {
        private Colleague welcome;
        private Colleague shop;
        private Colleague purchase;
        private Colleague exit;

        public CustomerProcess()
        {
            welcome = new Welcome( this );
            shop = new Shop( this );
            purchase = new Purchase( this );
            exit = new Exit( this );
        }

        public void Handle( ProcessType type )
        {
            switch( type )
            {
                case ProcessType.Welcome:
                    welcome.Go();
                    break;
                case ProcessType.Shop:
                    shop.Go();
                    break;
                case ProcessType.Purchase:
                    purchase.Go();
                    break;
                case ProcessType.Exit:
                    exit.Go();
                    break;
            }
        }
    }
}
