using System;
using Command.Core;

namespace Command.Commands
{
    class RunDiagnosticsCommand : Core.Command
    {
        private Receiver receiver;

        public RunDiagnosticsCommand( Receiver receiver )
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            receiver.Connect();
            receiver.Diagnostics();
            receiver.Disconnect();
            Console.WriteLine();
        }
    }
}
