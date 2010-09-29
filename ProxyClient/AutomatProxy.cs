using System;
using System.Text;
using System.Net.Sockets;
using System.Threading;

namespace ProxyClient
{
    class AutomatProxy
    {
        private TcpClient client;
        private Thread requestThread;
        private NetworkStream stream;

        public AutomatProxy()
        {
            try
            {
                client = new TcpClient( "127.0.0.1", 13000 );
                stream = client.GetStream();
                Console.WriteLine( "Connecting..." );
            }
            catch( SocketException ex )
            {
                Console.WriteLine( "Socket Exception: {0}", ex.Message );
            }
        }

        public void Run()
        {
            requestThread = new Thread( ReadConsole );
            requestThread.Start();
        }

        public void GotApplication()
        {
            SendData( "apply\n" );
        }

        public void CheckApplication()
        {
            SendData( "check\n" );
        }

        public void RentApartment()
        {
            SendData( "rent\n" );
        }

        private void ReadConsole()
        {
            try
            {
                while( true )
                {
                    byte[] data = new byte[256];
                    Int32 bytes = stream.Read( data, 0, data.Length );
                    Console.WriteLine( Encoding.ASCII.GetString( data, 0, bytes ) );
                }
            }
            catch( SocketException ex )
            {
                Console.WriteLine( "Socket Exception: {0}", ex.Message );
            }
        }

        private void SendData( string msg )
        {
            byte[] data = Encoding.ASCII.GetBytes( msg );
            stream.Write( data, 0, data.Length );
            stream.Flush();
        }
    }
}
