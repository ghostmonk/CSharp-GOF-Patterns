using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircularBuffer
{
    class Program
    {
        static void Main( string[] args )
        {
            CircularBuffer circularBuffer = new CircularBuffer( 8 );

            Console.WriteLine( "Storing 1" );
            circularBuffer.Store( 1 );
            Console.WriteLine( "Reading: {0}", circularBuffer.Read() );
            Console.WriteLine( "Storing 2" );
            circularBuffer.Store( 2 );
            Console.WriteLine( "Storing 3" );
            circularBuffer.Store( 3 );
            Console.WriteLine( "Storing 4" );
            circularBuffer.Store( 4 );
            Console.WriteLine( "Reading: {0}", circularBuffer.Read() );
            Console.WriteLine( "Storing 5" );
            circularBuffer.Store( 5 );
            Console.WriteLine( "Storing 6" );
            circularBuffer.Store( 6 );
            Console.WriteLine( "Storing 7" );
            circularBuffer.Store( 7 );
            Console.WriteLine( "Reading: {0}", circularBuffer.Read() );
            Console.WriteLine( "Storing 8" );
            circularBuffer.Store( 8 );
            Console.WriteLine( "Storing 9" );
            circularBuffer.Store( 9 );
            Console.WriteLine( "Storing 10" );
            circularBuffer.Store( 10 );
            Console.WriteLine( "Storing 11" );
            circularBuffer.Store( 11 );
            Console.WriteLine( "Storing 12" );
            circularBuffer.Store( 12 );
            Console.WriteLine( "Reading: {0}", circularBuffer.Read() );
            Console.WriteLine( "Reading: {0}", circularBuffer.Read() );
            Console.WriteLine( "Reading: {0}", circularBuffer.Read() );
            Console.WriteLine( "Reading: {0}", circularBuffer.Read() );
            Console.WriteLine( "Reading: {0}", circularBuffer.Read() );
            Console.WriteLine( "Reading: {0}", circularBuffer.Read() );
            Console.WriteLine( "Reading: {0}", circularBuffer.Read() );
            Console.WriteLine( "Reading: {0}", circularBuffer.Read() );
            Console.ReadLine();
        }
    }
}
