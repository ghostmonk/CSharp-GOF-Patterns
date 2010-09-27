using System;

namespace State.renting.stateObjects.states
{
    public class WaitingState : BaseState
    {
        private IAutomat automat;

        public WaitingState( IAutomat automat )
        {
            this.automat = automat;
            DefaultMessage = "You have to submit an application";
        }

        public override string GotApplication()
        {
            automat.SetState( automat.GotApplicationState );
            return "Thanks for the Application";
        }
    }
}
