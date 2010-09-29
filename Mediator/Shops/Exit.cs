using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mediator.Core;

namespace Mediator.Shops
{
    class Exit : Colleague
    {
        private Core.Mediator mediator;

        public Exit( Core.Mediator mediator )
        {
            this.mediator = mediator;
        }

        public void Go()
        {
            Console.WriteLine( "Goodbye!" );
        }
    }
}
