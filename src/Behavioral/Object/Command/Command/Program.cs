using System;

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

            Console.ReadKey(true);
        }
    }
}
