using System;

namespace StrategyPattern.algorithms
{
    class GoByFlying : GoAlgorithm
    {
        public void Go()
        {
            Console.WriteLine( "Flying flying" );
        }
    }
}
