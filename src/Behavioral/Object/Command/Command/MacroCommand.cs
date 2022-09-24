using System.Collections.Generic;

namespace Command
{
    public class MacroCommand : ICommand
    {
        private List<ICommand> commands;

        public MacroCommand(List<ICommand> commands)
        {
            this.commands = commands;
        }

        public void Execute()
        {
            foreach (ICommand command in commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            foreach (ICommand command in commands)
            {
                command.Undo();
            }
        }
    }
}
