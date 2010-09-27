using System;
using Template.robotMaker;

namespace Template
{
    class Program
    {
        public Program()
        {
            AutomotiveRobot carMaker = new AutomotiveRobot( "Car Maker" );
            ExectureRobot( carMaker );
            Console.WriteLine();
            CookieRobot cookieMaker = new CookieRobot( "Cookie Maker" );
            ExectureRobot( cookieMaker );
        }

        private void ExectureRobot( RobotTemplate robot )
        {
            robot.Go();
        }

        static void Main( string[] args )
        {
            new Program();
            Console.ReadLine();
        }
    }
}