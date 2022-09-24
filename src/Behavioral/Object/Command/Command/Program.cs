using System;
using System.Collections.Generic;

namespace Command
{
    public class Program
    {
        private static void Main()
        {
            var tempSwitch = new Switch();

            tempSwitch.SetCommands(
                new LightOnCommand(new Light()),
                new LightOffCommand(new Light()));

            tempSwitch.On();
            tempSwitch.Off();

            tempSwitch.Undo();

            MacroCommand onMacroCommand = new MacroCommand(new List<ICommand>()
            {
                new LightOnCommand(new Light()),
                new LightOffCommand(new Light())
            });

            tempSwitch.SetCommands(onMacroCommand, new NoCommand());

            tempSwitch.On();

            tempSwitch.Undo();

            Console.ReadKey(true);
        }
    }
}
