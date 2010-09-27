using State.renting.stateObjects.states;

namespace State.renting.stateObjects
{
    public interface IAutomat
    {
        int NumberOfApartments { get; set; }

        BaseState WaitingState { get; }

        BaseState GotApplicationState { get; }

        BaseState ApartmentRentedState { get; }

        BaseState FullyRentedState { get; }

        void GotApplication();

        void CheckApplication();

        void RentApartment();

        void SetState( BaseState state );
    }
}
