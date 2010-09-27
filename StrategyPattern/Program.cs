using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StrategyPattern.vehicles;

namespace StrategyPattern
{
    class Program
    {
        private List<Vehicle> vehicles;

        public Program()
        {
            vehicles = new List<Vehicle> { new Jet(), new RaceCar(), new Helicopter() };

            foreach( Vehicle vehicle in vehicles )
            {
                vehicle.Go();
            }
        }

        static void Main( string[] args )
        {
            new Program();
            Console.ReadLine();
        }
    }
}
