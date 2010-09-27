namespace Adapter.business
{
    class Ace : IAce
    {
        private string name;

        public void SetName( string name )
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
    }
}
