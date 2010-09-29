using System;
using Command.Core;

namespace Command.Servers
{
    class AsiaServer : Receiver
    {
        public void Connect()
        {
            Console.WriteLine( "{0} Connect", this );
        }

        public void Diagnostics()
        {
            Console.WriteLine( "{0} Diagnostics", this );
        }

        public void Reboot()
        {
            Console.WriteLine( "{0} Reboot", this );
        }

        public void Shutdown()
        {
            Console.WriteLine( "{0} Shutdown", this );
        }

        public void Disconnect()
        {
            Console.WriteLine( "{0} Disconnect", this );
        }
    }
}
