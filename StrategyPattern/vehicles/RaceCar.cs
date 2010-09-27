using StrategyPattern.algorithms;

namespace StrategyPattern.vehicles
{
    class RaceCar : Vehicle
    {
        public RaceCar()
        {
            GoAlgorithm = new GoByDrivingAlgorithm();
        }
    }
}
