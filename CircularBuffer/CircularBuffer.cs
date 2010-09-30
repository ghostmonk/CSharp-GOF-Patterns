using System;
using System.Collections.Generic;

namespace CircularBuffer
{
    class CircularBuffer
    {
        private List<int> data;
        private int head;
        private int tail;
        private int capacity;

        public CircularBuffer( int length )
        {
            capacity = length;
            data = new List<int>( length );
            head = 0;
            tail = 0;
        }
        
        public bool Store( int value )
        {
            if( BufferFull() ) return false;
            data[ tail++ ] = value;
            if( tail == capacity ) tail = 0;
            return true;
        }

        public bool BufferFull()
        {
            if( tail + 1 == head ) return true;
            if( tail == ( data.Count - 1 ) && head == 0 ) return true;
            return false;
        }

        public int? Read()
        {
            if( head == tail ) return null;
            int value = data[ head++ ];
            if( head == data.Count ) head = 0;
            return value;
        }
    }
}
