using System;
using Mediator.Core;

namespace Mediator.Shops
{
    class Welcome : Colleague
    {
        private Core.Mediator mediator;

        public Welcome( Core.Mediator mediator )
        {
            this.mediator = mediator;
        }

        public void Go()
        {
            Console.WriteLine( "Do you want to shop?" );
            string response = Console.ReadLine();

            if( response == "y" )
                mediator.Handle( ProcessType.Shop );
            else
                mediator.Handle( ProcessType.Exit );
        }
    }
}
