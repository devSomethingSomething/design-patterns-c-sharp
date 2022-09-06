namespace Strategy
{
    public class Quack : IQuackBehavior
    {
        public string Quacking()
        {
            return $"{nameof(Quack)}";
        }
    }
}
