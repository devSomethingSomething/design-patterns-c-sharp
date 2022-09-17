using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    public class LightRobotAssembler : RobotAssembler
    {
        protected override Robot Create(string type)
        {
            IRobotComponentFactory robotComponentFactory = new LightRobotComponentFactory();

            switch (type)
            {
                case nameof(AFrame):
                    return new AFrame(robotComponentFactory);
                default:
                    return null;
            }
        }
    }
}
