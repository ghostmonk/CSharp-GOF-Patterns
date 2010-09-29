using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mediator.Core;

namespace Mediator.Shops
{
    class Shop : Colleague
    {
        private Core.Mediator mediator;

        public Shop( Core.Mediator mediator )
        {
            this.mediator = mediator;
        }

        public void Go()
        {
            Console.WriteLine( "Do you want to Purchase?" );
            string response = Console.ReadLine();

            if( response == "y" )
                mediator.Handle( ProcessType.Purchase );
            else
                mediator.Handle( ProcessType.Exit );
        }
    }
}
