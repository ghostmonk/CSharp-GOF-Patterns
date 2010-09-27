using System;

namespace Decorator.ComputerParts
{
    public class ComputerDecorator : Computer
    {
        public override string Description()
        {
            throw new Exception( "Must override Description Method in derivatives of Computer Decorator" );
        }
    }
}
