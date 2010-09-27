using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StrategyPattern.algorithms;

namespace StrategyPattern.vehicles
{
    class Vehicle
    {
        protected GoAlgorithm GoAlgorithm { set; private get; }

        public void Go()
        {
            GoAlgorithm.Go();
        }
    }
}
