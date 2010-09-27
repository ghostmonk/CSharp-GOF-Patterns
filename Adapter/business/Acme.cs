using Adapter.business;

namespace Adapter
{
    class Acme : IAcme
    {
        private string firstName;
        private string lastName;

        public void SetFirstName( string firstName )
        {
            this.firstName = firstName;
        }

        public void SetLastName( string lastName )
        {
            this.lastName = lastName;
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
