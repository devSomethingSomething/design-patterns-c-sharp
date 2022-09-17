using System;

namespace AbstractFactory
{
    public class Program
    {
        private static void Main()
        {
            RobotAssembler robotAssembler = new LightRobotAssembler();

            Robot robot = robotAssembler.AssembleRobot(nameof(AFrame));

            Console.WriteLine(robot.Build());

            Console.ReadKey(true);
        }
    }
}
