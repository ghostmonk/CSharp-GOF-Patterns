using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern.algorithms
{
    class GoByFlyingFast : GoAlgorithm
    {
        public void Go()
        {
            Console.WriteLine( "Super sonic flight" );
        }
    }
}
