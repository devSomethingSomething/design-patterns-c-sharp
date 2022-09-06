namespace Strategy
{
    public class Squeak : IQuackBehavior
    {
        public string Quacking()
        {
            return $"{nameof(Squeak)}";
        }
    }
}
