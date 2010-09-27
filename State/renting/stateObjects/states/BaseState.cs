namespace State.renting.stateObjects.states
{
    public abstract class BaseState
    {
        protected string DefaultMessage { set; private get; }

        public virtual string GotApplication()
        {
            return DefaultMessage;
        }

        public virtual string CheckApplication()
        {
            return DefaultMessage;
        }

        public virtual string RentApartment()
        {
            return DefaultMessage;
        }

        public virtual string DispenseKeys()
        {
            return DefaultMessage;
        }
    }
}
