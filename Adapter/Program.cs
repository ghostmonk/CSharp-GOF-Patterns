using System;
using Adapter.adapters;
using Adapter.business;

namespace Adapter
{
    class Program
    {
        public Program()
        {
            Ace ace = new Ace();
            ace.SetName( "Cary Grant" );

            AceToAcmeAdapter acmeAdapter = new AceToAcmeAdapter( ace );
            Console.WriteLine( "First Name : {0}", acmeAdapter.GetFirstName() );
            Console.WriteLine( "Last Name : {0}", acmeAdapter.GetLastName() );
        }

        static void Main( string[] args )
        {
            new Program();
            Console.ReadLine();
        }
    }
}
