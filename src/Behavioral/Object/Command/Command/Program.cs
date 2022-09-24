using System;

namespace Command
{
    public class Program
    {
        private static void Main()
        {
            var tempSwitch = new Switch(new LightOnCommand(new Light()));

            tempSwitch.On();

            Console.ReadKey(true);
        }
    }
}
