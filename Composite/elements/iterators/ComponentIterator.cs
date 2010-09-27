using System.Collections.Generic;
using Composite.utils;

namespace Composite.elements.iterators
{
    class ComponentIterator : Iterator
    {
        private List<Component> components;
        private int location;

        public ComponentIterator( List<Component> components )
        {
            this.components = components;
            location = 0;
        }

        public bool HasNext()
        {
            return location < components.Count && components[ location ] != null;
        }

        public object Next()
        {
            return components[ location++ ];
        }

        public void Remove() {}
    }
}
