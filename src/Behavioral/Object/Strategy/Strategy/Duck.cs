namespace Strategy
{
    public abstract class Duck
    {
        public IFlyBehavior FlyBehavior { get; set; }

        public IQuackBehavior QuackBehavior { get; set; }

        public abstract string Display();

        public string Swim()
        {
            return "I can swim";
        }
    }
}
