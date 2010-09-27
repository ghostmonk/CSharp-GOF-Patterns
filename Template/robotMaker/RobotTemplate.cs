using System;

namespace Template.robotMaker
{
    public abstract class RobotTemplate
    {
        private bool testOK = true;

        public void Go()
        {
            Start();
            GetParts();
            Assemble();
            if( testOK ) Test();
            Stop();
        }

        public void SkipTest()
        {
            testOK = false;
        }

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
