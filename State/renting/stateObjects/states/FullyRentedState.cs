namespace State.renting.stateObjects.states
{
    class FullyRentedState : BaseState
    {
        private IAutomat automat;

        public FullyRentedState( IAutomat automat )
        {
            DefaultMessage = "Sorry We're Fully Rented.";
            this.automat = automat;
        }
    }
}
