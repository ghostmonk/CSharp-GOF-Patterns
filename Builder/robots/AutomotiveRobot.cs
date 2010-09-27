using System;

namespace Builder.robots
{
    class AutomotiveRobot : RobotTemplate
    {
        private string name;

        public AutomotiveRobot( string name )
        {
            this.name = name;
        }

        public override void Start()
        {
            Console.WriteLine( "{0}, Starting", name );
        }

        public override void GetParts()
        {
            Console.WriteLine( "{0}, GetParts", name );
        }

        public override void Assemble()
        {
            Console.WriteLine( "{0}, Assemble", name );
        }

        public override void Test()
        {
            Console.WriteLine( "{0}, Test", name );
        }

        public override void Stop()
        {
            Console.WriteLine( "{0}, Stop", name );
        }
    }
}
