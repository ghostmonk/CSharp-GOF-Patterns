using System;
using Command.Core;

namespace Command.Commands
{
    class ShutdownCommand : Core.Command
    {
        private Receiver receiver;

        public ShutdownCommand( Receiver receiver )
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            receiver.Connect();
            receiver.Shutdown();
            receiver.Disconnect();
            Console.WriteLine();
        }
    }
}
