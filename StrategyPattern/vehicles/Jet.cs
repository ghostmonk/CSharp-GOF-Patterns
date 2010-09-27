using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StrategyPattern.algorithms;

namespace StrategyPattern.vehicles
{
    class Jet : Vehicle
    {
        public Jet()
        {
            GoAlgorithm = new GoByFlyingFast();
        }
    }
}
