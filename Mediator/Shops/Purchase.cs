using System;
using Mediator.Core;

namespace Mediator.Shops
{
    class Purchase : Colleague
    {
        private Core.Mediator mediator;

        public Purchase( Core.Mediator mediator )
        {
            this.mediator = mediator;
        }

        public void Go()
        {
            Console.WriteLine( "Bye the item now?" );
            string response = Console.ReadLine();

            if( response == "y" )
                Console.WriteLine( "Thanks for your purchase" );

            mediator.Handle( ProcessType.Exit );
        }
    }
}