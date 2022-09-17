namespace FactoryMethod
{
    public class HeavyRobotAssembler : RobotAssembler
    {
        protected override IRobot Create(string type)
        {
            // Add logic to determine which type to return
            return null;
        }
    }
}
