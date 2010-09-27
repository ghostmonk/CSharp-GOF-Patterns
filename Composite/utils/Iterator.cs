namespace Composite.utils
{
    public interface Iterator
    {
        bool HasNext();

        object Next();

        void Remove();
    }
}
