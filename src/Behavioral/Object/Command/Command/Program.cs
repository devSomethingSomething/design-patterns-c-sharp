using System;

namespace Command
{
    public class Program
    {
        private static void Main()
        {
            var tempSwitch = new Switch(
                new LightOnCommand(new Light()),
                new LightOffCommand(new Light()));

            tempSwitch.On();
            tempSwitch.Off();

            Console.ReadKey(true);
        }
    }
}
