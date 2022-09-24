using System;

namespace Command
{
    public class LightOffCommand : ICommand
    {
        private Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.Off();
        }

        public void Undo()
        {
            Console.Write("UNDO: ");

            light.On();
        }
    }
}
