using System;

namespace Iterator.corporation
{
    class Employee
    {
        public Employee( string name, Division division )
        {
            Name = name;
            Division = division;
        }

        public string Name { get; private set; }

        public Division Division { get; private set; }

        public void Print()
        {
            Console.WriteLine( "Name: {0}, Division: {1}", Name, Division );
        }
    }
}
