using System;

namespace Decorator.ComputerParts
{
    public class Monitor : ComputerDecorator
    {
        private Computer comp;

        public Monitor( Computer comp )
        {
            this.comp = comp;
        }

        public override string Description()
        {
            return comp.Description() + " and a Monitor";
        }
    }
}
