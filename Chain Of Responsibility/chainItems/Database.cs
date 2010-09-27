using System;

namespace Chain_Of_Responsibility.chainItems
{
    class Database : HelpInterface
    {
        private HelpInterface successor;
        
        public Database() {}

        public Database( HelpInterface successor )
        {
            this.successor = successor;
        }

        public void GetHelp( HelpItem item )
        {
            Console.WriteLine( "Database is for Model & Storage" );
        }
    }
}
