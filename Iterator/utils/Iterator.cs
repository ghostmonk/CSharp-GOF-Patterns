namespace Iterator.utils
{
    interface Iterator
    {
        bool HasNext();

        object Next();

        void Remove();
    }
}
