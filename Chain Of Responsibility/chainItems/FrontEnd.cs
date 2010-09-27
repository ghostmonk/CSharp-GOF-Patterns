using System;

namespace Chain_Of_Responsibility.chainItems
{
    class FrontEnd : HelpInterface
    {
        private HelpInterface successor;

        public FrontEnd( HelpInterface successor )
        {
            this.successor = successor;
        }

        public void GetHelp( HelpItem item )
        {
            if( item == HelpItem.FrontEnd )
                Console.WriteLine( "Front end is for UI" );
            else
                successor.GetHelp( item );
        }
    }
}
