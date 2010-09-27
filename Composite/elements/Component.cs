using Composite.utils;

namespace Composite.elements
{
    public abstract class Component
    {
        public string Name { get; protected set; }

        public Iterator Iterator { get; protected set; }

        public abstract void Add( Component component );

        public abstract void Print();
    }
}
