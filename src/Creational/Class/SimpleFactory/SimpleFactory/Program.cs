using System;

namespace SimpleFactory
{
    public class Program
    {
        private static void Main()
        {
            IFactory<IRobot> factory = new SimpleRobotFactory();

            RobotAssembler robotAssembler = new RobotAssembler(factory);

            robotAssembler.AssembleRobot(nameof(AFrame));
            robotAssembler.AssembleRobot(nameof(BFrame));

            Console.ReadKey(true);
        }
    }
}
