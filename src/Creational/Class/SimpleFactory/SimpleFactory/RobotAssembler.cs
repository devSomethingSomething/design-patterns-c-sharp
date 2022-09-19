namespace SimpleFactory
{
    public class RobotAssembler
    {
        private IFactory factory;

        public RobotAssembler(IFactory factory)
        {
            this.factory = factory;
        }

        public IRobot AssembleRobot(string type)
        {
            IRobot robot = factory.Create(type) as IRobot;

            robot.Register();
            robot.Start();
            robot.Update();

            return robot;
        }
    }
}
