namespace SimpleFactory
{
    public class RobotAssembler
    {
        private IFactory<IRobot> factory;

        public RobotAssembler(IFactory<IRobot> factory)
        {
            this.factory = factory;
        }

        public IRobot AssembleRobot(string type)
        {
            IRobot robot = factory.Create(type);

            robot.Register();
            robot.Start();
            robot.Update();

            return robot;
        }
    }
}
