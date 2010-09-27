using System;
using Builder.robotMaker;
using Builder.robots;

namespace Builder
{
    /// <summary>
    /// A builder allows client code to construct
    /// the object of the builder. It is like the
    /// template method, but allows external modification.
    /// </summary>
    class Program
    {
        public Program()
        {
            RobotBuilder builder = new RobotBuilder( new BuildableRobot( new CookieRobot( "CookieMan" ) ) );
            builder.AddStop();
            builder.AddGetParts();
            builder.AddAssemble();
            builder.AddGetParts();
            builder.AddGetParts();
            builder.GetRobot().Go();
        }

        static void Main( string[] args )
        {
            new Program();
            Console.ReadLine();
        }
    }
}