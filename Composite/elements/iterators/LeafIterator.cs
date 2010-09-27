using Composite.utils;

namespace Composite.elements.iterators
{
    class LeafIterator : Iterator
    {
        private Leaf leaf;

        public LeafIterator( Leaf leaf )
        {
            this.leaf = leaf;
        }

        public bool HasNext()
        {
            return false;
        }

        public object Next()
        {
            return leaf;
        }

        public void Remove() {}
    }
}
