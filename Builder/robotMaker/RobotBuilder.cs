using System.Collections.Generic;

namespace Builder.robotMaker
{
    class RobotBuilder : IRobotBuilder
    {
        private BuildableRobot buildableRobot;
        private List<BuildAction> actions;

        public RobotBuilder( BuildableRobot buildableRobot )
        {
            this.buildableRobot = buildableRobot;
            actions = new List<BuildAction>();
        }

        public void AddStart()
        {
            actions.Add( BuildAction.Start );
        }

        public void AddGetParts()
        {
            actions.Add( BuildAction.GetParts );
        }

        public void AddAssemble()
        {
            actions.Add( BuildAction.Assemble );
        }

        public void AddTest()
        {
            actions.Add( BuildAction.Test );
        }

        public void AddStop()
        {
            actions.Add( BuildAction.Stop );
        }

        public IBuildableRobot GetRobot()
        {
            buildableRobot.LoadActions( actions );
            return buildableRobot;
        }
    }
}
