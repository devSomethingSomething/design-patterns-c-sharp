namespace FactoryMethod
{
    public abstract class RobotAssembler
    {
        public Robot AssembleRobot(string type)
        {
            Robot robot = Create(type);

            robot.Register();
            robot.Start();
            robot.Update();

            return robot;
        }

        protected abstract Robot Create(string type);
    }
}
