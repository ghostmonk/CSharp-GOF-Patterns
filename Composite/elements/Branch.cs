using System.Collections.Generic;
using Composite.elements.iterators;

namespace Composite.elements
{
    class Branch : Component
    {
        private List<Component> components;
        private int numChildren;

        public Branch( string name )
        {
            Name = name;
            numChildren = 0;
            components = new List<Component>();
            Iterator = new ComponentIterator( components );
        }

        public override void Add( Component component )
        {
            numChildren++;
            components.Add( component );
        }

        public override void Print()
        {
            while( Iterator.HasNext() )
            {
                ( (Component)Iterator.Next() ).Print();
            }
        }
    }
}
