namespace Strategy
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Squeak();
        }

        public override string Display()
        {
            return "I'm a rubber duck";
        }
    }
}
