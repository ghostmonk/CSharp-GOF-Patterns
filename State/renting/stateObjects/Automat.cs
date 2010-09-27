using System;
using State.renting.stateObjects.states;

namespace State.renting.stateObjects
{
    public class Automat : IAutomat
    {
        private BaseState state;

        public Automat( int numberOfApartments )
        {
            NumberOfApartments = numberOfApartments;
            WaitingState = new WaitingState( this );
            GotApplicationState = new GotApplicationState( this );
            ApartmentRentedState = new ApartmentRentedState( this );
            FullyRentedState = new FullyRentedState( this );
            state = WaitingState;
        }

        public int NumberOfApartments { get; set; }

        public BaseState WaitingState { get; private set; }

        public BaseState GotApplicationState { get; private set; }

        public BaseState ApartmentRentedState { get; private set; }

        public BaseState FullyRentedState { get; private set; }
        
        public void GotApplication()
        {
            Output( state.GotApplication() );
        }

        public void CheckApplication()
        {
            Output( state.CheckApplication() );
            if( state == ApartmentRentedState ) RentApartment();
        }

        public void RentApartment()
        {
            Output( state.RentApartment() );
            Output( state.DispenseKeys() );
        }

        public void SetState( BaseState state )
        {
            this.state = state;
        }

        private void Output( string message )
        {
            Console.WriteLine( message );
        }
    }
}
