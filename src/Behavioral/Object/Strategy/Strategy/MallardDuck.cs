namespace Strategy
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new Quack();
        }

        public override string Display()
        {
            return "I'm a mallard duck";
        }
    }
}
