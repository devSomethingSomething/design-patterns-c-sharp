namespace SimpleFactory
{
    public class SimpleRobotFactory : IFactory
    {
        public object Create(string type)
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
