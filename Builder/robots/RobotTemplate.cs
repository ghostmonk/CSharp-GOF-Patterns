using System;

namespace Builder.robots
{
    class RobotTemplate 
    {
        public virtual void Start()
        {
            Console.WriteLine( "default Start" );
        }

        public virtual void GetParts()
        {
            Console.WriteLine( "default GetParts" );
        }

        public virtual void Assemble()
        {
            Console.WriteLine( "default Assemble" );
        }

        public virtual void Test()
        {
            Console.WriteLine( "default Test" );
        }

        public virtual void Stop()
        {
            Console.WriteLine( "default Stop" );
        }
    }
}
