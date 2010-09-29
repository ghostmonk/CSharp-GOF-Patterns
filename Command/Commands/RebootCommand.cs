using System;
using Command.Core;

namespace Command.Commands
{
    class RebootCommand : Core.Command
    {
        private Receiver receiver;

        public RebootCommand( Receiver receiver )
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            receiver.Connect();
            receiver.Reboot();
            receiver.Disconnect();
            Console.WriteLine();
        }
    }
}
