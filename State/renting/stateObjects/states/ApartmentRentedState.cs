namespace State.renting.stateObjects.states
{
    public class ApartmentRentedState : BaseState
    {
        private IAutomat automat;

        public ApartmentRentedState( IAutomat automat )
        {
            DefaultMessage = "Hang on, we're renting you an apartment.";
            this.automat = automat;
        }

        public override string RentApartment()
        {
            automat.NumberOfApartments--;
            return "Renting you an apartment.";
        }

        public override string DispenseKeys()
        {
            BaseState state = automat.NumberOfApartments <= 0 ? automat.FullyRentedState : automat.WaitingState;
            automat.SetState( state );
            return "Here are your keys";
        }
    }
}
