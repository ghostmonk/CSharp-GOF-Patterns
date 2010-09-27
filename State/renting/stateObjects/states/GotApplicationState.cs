using System;

namespace State.renting.stateObjects.states
{
    public class GotApplicationState : BaseState
    {
        private IAutomat automat;

        public GotApplicationState( IAutomat automat )
        {
            DefaultMessage = "We already got your application";
            this.automat = automat;
        }

        public override string CheckApplication()
        {
            bool isApproved = ( new Random( DateTime.Now.Millisecond ).Next() % 10 ) > 4;

            if( isApproved && automat.NumberOfApartments > 0 )
            {
                automat.SetState( automat.ApartmentRentedState );
                return "Congratulation, you were approved.";
            }
            else
            {
                automat.SetState( automat.WaitingState );
                return "Sorry, you were not approved";
            }
        }
    }
}
