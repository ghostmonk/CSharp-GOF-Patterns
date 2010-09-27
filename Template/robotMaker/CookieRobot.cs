using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template.robotMaker
{
    class CookieRobot : RobotTemplate
    {
        private string name;

        public CookieRobot( string name )
        {
            this.name = name;
            SkipTest();
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
