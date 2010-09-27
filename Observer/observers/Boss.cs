using System;

namespace Observer.observers
{
    class Boss : Observer
    {
        public void Update( string operation, string record )
        {
            Console.WriteLine( "{0} : operation = {1}, record = {2}", GetType(), operation, record );
        }
    }
}
