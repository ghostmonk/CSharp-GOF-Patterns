using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.robotMaker
{
    interface IRobotBuilder
    {
        void AddStart();

        void AddGetParts();

        void AddAssemble();

        void AddTest();

        void AddStop();

        IBuildableRobot GetRobot();
    }
}
