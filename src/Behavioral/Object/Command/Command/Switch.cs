namespace Command
{
    public class Switch
    {
        private ICommand command;

        public Switch(ICommand command)
        {
            this.command = command;
        }

        public void On()
        {
            command.Execute();
        }
    }
}
