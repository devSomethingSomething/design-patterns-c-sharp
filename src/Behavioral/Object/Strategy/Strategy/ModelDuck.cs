namespace Strategy
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Quack();
        }

        public override string Display()
        {
            return "I'm a model duck";
        }
    }
}
