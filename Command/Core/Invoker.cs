namespace Command.Core
{
    class Invoker
    {
        private Command command;

        public void SetCommand( Command command )
        {
            this.command = command;
        }

        public void Run()
        {
            command.Execute();
        }
    }
}
