namespace FactoryMethod
{
    public class HeavyRobotAssembler : RobotAssembler
    {
        protected override Robot Create(string type)
        {
            switch (type)
            {
                case nameof(HeavyAFrame):
                    return new HeavyAFrame();
                case nameof(HeavyBFrame):
                    return new HeavyBFrame();
                default:
                    return null;
            }
        }
    }
}
