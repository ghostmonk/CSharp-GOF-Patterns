using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using State.renting.stateObjects;
using State.renting.stateObjects.states;

namespace Proxy
{
    class AutomatServer : IAutomat
    {
        private BaseState state;
        private Thread thread;
        private TcpListener server;

        public AutomatServer()
        {
            NumberOfApartments = 9;
            WaitingState = new WaitingState( this );
            GotApplicationState = new GotApplicationState( this );
            ApartmentRentedState = new ApartmentRentedState( this );
            FullyRentedState = new FullyRentedState( this );
            state = WaitingState;

            thread = new Thread( Run );
        }

        public int NumberOfApartments { get; set; }

        public BaseState WaitingState { get; private set; }

        public BaseState GotApplicationState { get; private set; }

        public BaseState ApartmentRentedState { get; private set; }

        public BaseState FullyRentedState { get; private set; }

        public void GotApplication()
        {
            state.GotApplication();
        }

        public void CheckApplication()
        {
            state.CheckApplication();
            if( state == ApartmentRentedState ) RentApartment();
        }

        public void RentApartment()
        {
            state.RentApartment();
            state.DispenseKeys();
        }

        public void SetState( BaseState state )
        {
            this.state = state;
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
                Console.WriteLine("Socet Exception: {0}", ex.Message);
            }
        }

        private void ConnectedTcpClient( Object client )
        {
            TcpClient tcpClient = (TcpClient)client;
            try
            {
                NetworkStream stream = tcpClient.GetStream();
                int i;
            
                Byte[] bytes = new Byte[256];
                string data;

                while( ( i = stream.Read( bytes, 0, bytes.Length ) ) != 0 )
                {
                    data = Encoding.ASCII.GetString( bytes, 0, i );
                    Console.WriteLine( "Recieved: {0}", data );
                    data = data.ToUpper();
                    byte[] msg = Encoding.ASCII.GetBytes( data );

                    stream.Write( msg, 0, msg.Length );
                    Console.WriteLine( "Sent: {0}", data );
                }

                tcpClient.Close();
            }
            catch( SocketException ex )
            {
                Console.WriteLine( "Socket Exception: {0}", ex.Message );
            }
        }
    }
}
