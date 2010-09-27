using System;

namespace Chain_Of_Responsibility.chainItems
{
    class Backend : HelpInterface
    {
        private HelpInterface successor;

        public Backend( HelpInterface successor )
        {
            this.successor = successor;
        }

        public void GetHelp( HelpItem item )
        {
            if( item == HelpItem.Backend )
                Console.WriteLine( "Backend is for DB Communication" );
            else
                successor.GetHelp( item );
        }
    }
}
