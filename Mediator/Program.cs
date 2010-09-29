using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mediator.Shops;

namespace Mediator
{
    class Program
    {
        public Program()
        {
            new CustomerProcess().Handle( ProcessType.Welcome );
        }

        static void Main( string[] args )
        {
            new Program();
            Console.ReadLine();
        }
    }
}
