namespace FactoryMethod
{
    public abstract class RobotAssembler
    {
        public IRobot AssembleRobot(string type)
        {
            IRobot robot = Create(type);

            robot.Register();
            robot.Start();
            robot.Update();

            return robot;
        }

        protected abstract IRobot Create(string type);
    }
}
