namespace Decorator.ComputerParts
{
    public class Disk : ComputerDecorator
    {
        private Computer comp;

        public Disk(Computer comp)
        {
            this.comp = comp;
        }

        public override string Description()
        {
            return comp.Description() + " and a Disk";
        }
    }
}
