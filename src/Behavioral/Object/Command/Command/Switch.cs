namespace Command
{
    public class Switch
    {
        private ICommand onCommand;
        private ICommand offCommand;

        private ICommand undoCommand;

        public Switch()
        {
            onCommand = new NoCommand();
            offCommand = new NoCommand();

            undoCommand = new NoCommand();
        }

        public void SetCommands(ICommand onCommand, ICommand offCommand)
        {
            this.onCommand = onCommand;
            this.offCommand = offCommand;
        }

        public void On()
        {
            undoCommand = onCommand;

            onCommand.Execute();
        }

        public void Off()
        {
            undoCommand = offCommand;

            offCommand.Execute();
        }

        public void Undo()
        {
            undoCommand.Undo();
        }
    }
}
