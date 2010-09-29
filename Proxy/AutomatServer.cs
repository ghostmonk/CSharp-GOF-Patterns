using System;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using State.renting.stateObjects;
using State.renting.stateObjects.states;

namespace Proxy
{
    internal class AutomatServer : IAutomat
    {
        private BaseState state;
        private Thread thread;
        private TcpListener server;
        private NetworkStream currentStream;

        public AutomatServer()
        {
            NumberOfApartments = 9;
            WaitingState = new WaitingState( this );
            GotApplicationState = new GotApplicationState( this );
            ApartmentRentedState = new ApartmentRentedState( this );
            FullyRentedState = new FullyRentedState( this );
            state = WaitingState;

            thread = new Thread( Run );
            thread.Start();
        }

        public int NumberOfApartments { get; set; }

        public BaseState WaitingState { get; private set; }

        public BaseState GotApplicationState { get; private set; }

        public BaseState ApartmentRentedState { get; private set; }

        public BaseState FullyRentedState { get; private set; }

        public void GotApplication()
        {
            SendToClient( state.GotApplication() );
        }

        public void CheckApplication()
        {
            SendToClient( state.CheckApplication() );
            if( state == ApartmentRentedState )
                RentApartment();
        }

        public void RentApartment()
        {
            SendToClient( state.RentApartment() );
            SendToClient( state.DispenseKeys() );
        }

        public void SetState( BaseState state )
        {
            this.state = state;
        }

        private void SendToClient( string msg )
        {
            byte[] response = Encoding.ASCII.GetBytes( msg );
            currentStream.Write( response, 0, msg.Length );
        }

        private void Run()
        {
            try
            {
                server = new TcpListener( IPAddress.Parse( "127.0.0.1" ), 13000 );
                server.Start();

                while( true )
                {
                    Console.WriteLine( "Waiting for a connection..." );
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine( "Connected {0}", client.Client.RemoteEndPoint );
                    Thread clientThread = new Thread( ConnectedTcpClient );
                    clientThread.Start( client );
                }
            }
            catch( SocketException ex )
            {
                Console.WriteLine( "Socet Exception: {0}", ex.Message );
            }
        }

        private void ConnectedTcpClient( Object client )
        {
            TcpClient tcpClient = (TcpClient)client;
            try
            {
                NetworkStream stream = tcpClient.GetStream();
                int i;

                string command = String.Empty;
                Byte[] bytes = new Byte[256];

                int bufferSize = 0;

                while( ( i = stream.Read( bytes, bufferSize, bytes.Length - bufferSize ) ) != 0 )
                {
                    bufferSize += i;

                    int x = 0;
                    while( x < bufferSize )
                    {
                        if( bytes[ x++ ] != '\n' ) continue;

                        InvokeCmd( Encoding.ASCII.GetString( bytes, 0, x - 1 ), tcpClient );
                        bufferSize -= x;
                        Buffer.BlockCopy( bytes, x, bytes, 0, bufferSize );
                        x = 0;
                    }
                }

                tcpClient.Close();
            }
            catch( SocketException ex )
            {
                Console.WriteLine( "Socket Exception: {0}", ex.Message );
            }
            catch( IOException ex )
            {
                Console.WriteLine( "Exception: {0}", ex.Message );
            }
        }

        private void InvokeCmd( string command, TcpClient client )
        {
            currentStream = client.GetStream();
            switch( command )
            {
                case "check":
                    CheckApplication();
                    break;
                case "apply":
                    GotApplication();
                    break;
                case "rent":
                    RentApartment();
                    break;
                default:
                    Console.WriteLine( "Unknown Command: {0}", command );
                    break;
            }
        }
    }
}