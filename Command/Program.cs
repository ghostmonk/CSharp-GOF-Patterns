using System;
using Command.Commands;
using Command.Core;
using Command.Servers;

namespace Command
{
    class Program
    {
        private Invoker invoker;

        public Program()
        {
            invoker = new Invoker();

            AsiaServer asiaServer = new AsiaServer();
            EuroServer euroServer = new EuroServer();
            USServer usServer = new USServer();

            ShutdownCommand asiaShutdown = new ShutdownCommand( asiaServer );
            RunDiagnosticsCommand asiaDiagnostics = new RunDiagnosticsCommand( asiaServer );
            RebootCommand asiaReboot = new RebootCommand( asiaServer );

            ShutdownCommand euroShutdown = new ShutdownCommand( euroServer );
            RunDiagnosticsCommand euroDiagnostics = new RunDiagnosticsCommand( euroServer );
            RebootCommand euroReboot = new RebootCommand( euroServer );

            ShutdownCommand usShutdown = new ShutdownCommand( usServer );
            RunDiagnosticsCommand usDiagnostics = new RunDiagnosticsCommand( usServer );
            RebootCommand usReboot = new RebootCommand( usServer );

            RunCommand( asiaShutdown );
            RunCommand( asiaDiagnostics );
            RunCommand( asiaReboot );

            RunCommand( euroShutdown );
            RunCommand( euroDiagnostics );
            RunCommand( euroReboot );

            RunCommand( usShutdown );
            RunCommand( usDiagnostics );
            RunCommand( usReboot );
        }

        private void RunCommand( Core.Command cmd )
        {
            invoker.SetCommand( cmd );
            invoker.Run();
        }

        static void Main( string[] args )
        {
            new Program();
            Console.ReadLine();
        }
    }
}
