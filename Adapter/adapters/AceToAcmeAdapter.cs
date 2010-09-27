using System;
using Adapter.business;

namespace Adapter.adapters
{
    class AceToAcmeAdapter : IAcme
    {
        private Ace ace;
        private string firstName;
        private string lastName;

        public AceToAcmeAdapter( Ace ace )
        {
            this.ace = ace;
            Char space = Convert.ToChar( " " );
            firstName = ace.GetName().Split( space )[ 0 ];
            lastName = ace.GetName().Split( space )[ 1 ];
        }

        public void SetFirstName( string firstName )
        {
            this.firstName = firstName;
            ace.SetName( firstName + " " + lastName );
        }

        public void SetLastName( string lastName )
        {
            this.lastName = lastName;
            ace.SetName( firstName + " " + lastName );
        }

        public string GetFirstName()
        {
            return firstName;
        }

        public string GetLastName()
        {
            return lastName;
        }
    }
}
