namespace FactoryMethod
{
    public class LightRobotAssembler : RobotAssembler
    {
        protected override Robot Create(string type)
        {
            switch (type)
            {
                case nameof(LightAFrame):
                    return new LightAFrame();
                case nameof(LightBFrame):
                    return new LightBFrame();
                default:
                    return null;
            }
        }
    }
}
