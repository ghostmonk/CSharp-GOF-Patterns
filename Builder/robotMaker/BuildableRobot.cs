using System.Collections.Generic;
using Builder.robots;

namespace Builder.robotMaker
{
    class BuildableRobot : IBuildableRobot
    {
        private string name;
        private List<BuildAction> actions;
        private RobotTemplate robot;

        public BuildableRobot( RobotTemplate robot )
        {
            this.robot = robot;
        }

        public void LoadActions( List<BuildAction> actions )
        {
            this.actions = actions;
        }

        public void Go()
        {
            IEnumerator<BuildAction> iterator = actions.GetEnumerator();

            while( iterator.MoveNext() )
            {
                switch( iterator.Current )
                {
                    case BuildAction.Start:
                        robot.Start();
                        break;
                    case BuildAction.GetParts:
                        robot.GetParts();
                        break;
                    case BuildAction.Assemble:
                        robot.Assemble();
                        break;
                    case BuildAction.Test:
                        robot.Test();
                        break;
                    case BuildAction.Stop:
                        robot.Stop();
                        break;
                }
            }
        }
    }
}
