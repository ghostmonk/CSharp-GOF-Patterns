namespace Decorator.ComputerParts
{
    public class CD : ComputerDecorator
    {
        private Computer comp;

        public CD( Computer comp )
        {
            this.comp = comp;
        }

        public override string Description()
        {
            return comp.Description() + " and a CD";
        }
    }
}
