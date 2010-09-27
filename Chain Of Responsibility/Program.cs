using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chain_Of_Responsibility.chainItems;

namespace Chain_Of_Responsibility
{
    class Program
    {
        public Program()
        {
            Database database = new Database();
            Backend backend = new Backend( database );
            IntermediateLayer intermediate = new IntermediateLayer( backend );
            FrontEnd frontEnd = new FrontEnd( intermediate );
            frontEnd.GetHelp( HelpItem.FrontEnd );
        }

        static void Main( string[] args )
        {
            new Program();
            Console.ReadLine();
        }
    }
}