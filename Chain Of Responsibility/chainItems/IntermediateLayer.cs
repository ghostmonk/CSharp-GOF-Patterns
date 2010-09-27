using System;

namespace Chain_Of_Responsibility.chainItems
{
    class IntermediateLayer : HelpInterface
    {
        private HelpInterface successor;

        public IntermediateLayer( HelpInterface successor )
        {
            this.successor = successor;
        }

        public void GetHelp( HelpItem item )
        {
            if( item == HelpItem.IntermediateLayer )
                Console.WriteLine( "IntermediateLayer is for Business Logic" );
            else
                successor.GetHelp( item );
        }
    }
}
