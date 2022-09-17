namespace AbstractFactory
{
    public abstract class RobotAssembler
    {
        public Robot AssembleRobot(string type)
        {
            Robot robot = Create(type);

            robot.Build();

            return robot;
        }

        protected abstract Robot Create(string type);
    }
}
