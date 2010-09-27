using System;

namespace State.renting.stateMethods
{
    class RentalMethods
    {
        private RentalState rentalState;
        private int numberOfApartments;

        public RentalMethods( int numberOfApartments )
        {
            rentalState = RentalState.Waiting;
            this.numberOfApartments = numberOfApartments;
        }

        public void SubmitApplication()
        {
            switch( rentalState )
            {
                case RentalState.GotApplication :
                    Output( "We already have your application" );
                    return;
                case RentalState.Waiting :
                    rentalState = RentalState.GotApplication;
                    Output( "Thanks for the Application." );
                    return;
            }

            BadStateResponse();
        }

        public void CheckApplication()
        {
            if( rentalState == RentalState.GotApplication )
            {
                bool isApproved = ( new Random( DateTime.Now.Millisecond ).Next() % 10 ) > 4;

                if( isApproved && numberOfApartments > 0 )
                {
                    Output( "Congratulation, you were approved." );
                    rentalState = RentalState.ApartmentRented;
                    RentAppartment();
                }
                else
                {
                    Output( "Sorry, you were not approved" );
                    rentalState = RentalState.Waiting;
                }
                return;
            }

            BadStateResponse();
        }

        public void RentAppartment()
        {
            if( rentalState == RentalState.ApartmentRented )
            {
                Output( "Now renting you an appartment. You need your keys." );
                numberOfApartments--;
                DispenseKeys();
                return;
            }
            BadStateResponse();
        }

        public void DispenseKeys()
        {
            if( rentalState == RentalState.ApartmentRented )
            {
                Output( "Here are your keys." );
                rentalState = RentalState.Waiting;
                return;
            }
            BadStateResponse();
        }

        private void BadStateResponse()
        {
            switch( rentalState )
            {
                case RentalState.FullyRented:
                    Output( "Sorry, We're Fully Rented." );
                    break;
                case RentalState.Waiting:
                    Output( "You have to submit an application." );
                    break;
                case RentalState.GotApplication:
                    Output( "You must have your application checked." );
                    break;
                case RentalState.ApartmentRented:
                    Output( "Hang on we're renting you an appartment." );
                    break;
            }
        }

        private void Output( string message )
        {
            Console.WriteLine( message );
        }
    }
}
