namespace SimpleFactory
{
    public class SimpleRobotFactory : IFactory<IRobot>
    {
        public IRobot Create(string type)
        {
            switch (type)
            {
                case nameof(AFrame):
                    return new AFrame();
                case nameof(BFrame):
                    return new BFrame();
                default:
                    return null;
            }
        }
    }
}
