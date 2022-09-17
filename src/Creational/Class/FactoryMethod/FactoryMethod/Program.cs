using System;

namespace FactoryMethod
{
    public class Program
    {
        private static void Main()
        {
            RobotAssembler robotAssembler = new LightRobotAssembler();
            Robot robot = robotAssembler.AssembleRobot(nameof(LightAFrame));
            robot.Start();

            Console.WriteLine();

            robotAssembler = new HeavyRobotAssembler();
            robot = robotAssembler.AssembleRobot(nameof(HeavyAFrame));
            robot.Start();

            Console.ReadKey(true);
        }
    }
}
