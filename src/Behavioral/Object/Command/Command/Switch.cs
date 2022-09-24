namespace Command
{
    public class Switch
    {
        private ICommand onCommand;
        private ICommand offCommand;

        public Switch()
        {
            onCommand = new NoCommand();
            offCommand = new NoCommand();
        }

        public void SetCommands(ICommand onCommand, ICommand offCommand)
        {
            this.onCommand = onCommand;
            this.offCommand = offCommand;
        }

        public void On()
        {
            onCommand.Execute();
        }

        public void Off()
        {
            offCommand.Execute();
        }
    }
}
