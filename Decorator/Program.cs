using System;
using Decorator.ComputerParts;

namespace Decorator
{
    class Program
    {
        public Program()
        {
            Computer comp = new Computer();
            comp = new Disk( comp );
            comp = new Monitor( comp );
            comp = new CD( comp );
            comp = new CD( comp );
            Console.WriteLine( comp.Description() );
        }

        static void Main(string[] args)
        {
            new Program();
            Console.ReadLine();
        }
    }
}
