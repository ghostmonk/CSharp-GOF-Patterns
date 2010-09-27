using System;
using Composite.elements.iterators;

namespace Composite.elements
{
    class Leaf : Component
    {
        private string category;

        public Leaf( string name, string category )
        {
            Name = name;
            Iterator = new LeafIterator( this );
            this.category = category;
        }

        public override void Add( Component component ) { }

        public override void Print()
        {
            Console.WriteLine( "Name:{0}, Category:{1}", Name, category );
        }
    }
}
