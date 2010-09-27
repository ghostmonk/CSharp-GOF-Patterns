namespace Observer.subjects
{
    public interface Subject
    {
        void RegisterObserver( observers.Observer observer );
        void RemoveObserver( observers.Observer observer );
        void NotifyObservers();
    }
}