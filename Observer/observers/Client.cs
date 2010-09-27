using System;

namespace Observer.observers
{
    class Client : Observer
    {
        public void Update( string operation, string record )
        {
            Console.WriteLine( "{0} : operation = {1}, record = {2}", GetType(), operation, record ); 
        }
    }
}
