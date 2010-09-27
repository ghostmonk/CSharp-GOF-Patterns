using System;
using State.renting.stateMethods;
using State.renting.stateObjects;

namespace State
{
    class Program
    {
        public Program()
        {
            //UsingStateMethods();
            UsingStateObjects();
        }

        public void UsingStateObjects()
        {
            Automat automat = new Automat( 9 );
            automat.GotApplication();
            automat.CheckApplication();
        }

        public void UsingStateMethods()
        {
            RentalMethods rentalMethods = new RentalMethods( 9 );
            rentalMethods.SubmitApplication();
            rentalMethods.CheckApplication();
        }

        static void Main( string[] args )
        {
            new Program();
            Console.ReadLine();
        }
    }
}
