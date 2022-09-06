namespace Strategy
{
    public class FlyNoWay : IFlyBehavior
    {
        public string Fly()
        {
            return "I cannot fly";
        }
    }
}
