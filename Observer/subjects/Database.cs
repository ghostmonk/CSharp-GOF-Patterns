using System.Collections.Generic;

namespace Observer.subjects
{
    public class Database : Subject
    {
        private readonly List<observers.Observer> observers = new List<observers.Observer>();
        private string operation;
        private string record;

        #region Subject Members

        public void RegisterObserver( observers.Observer observer )
        {
            observers.Add( observer );
        }

        public void RemoveObserver( observers.Observer observer )
        {
            observers.Remove( observer );
        }

        public void NotifyObservers()
        {
            foreach( observers.Observer currentObserver in observers )
            {
                currentObserver.Update( operation, record );
            }
        }

        #endregion

        public void EditRecord( string operation, string record )
        {
            this.operation = operation;
            this.record = record;
            NotifyObservers();
        }
    }
}