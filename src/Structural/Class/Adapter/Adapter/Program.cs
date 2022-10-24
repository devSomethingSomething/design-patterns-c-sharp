namespace Adapter
{
    public class Program
    {
        private static void Main()
        {
            new Adapter(new TestAdaptee()).Action();
        }
    }

    public interface ITarget
    {
        void Action();
    }

    public class TestTarget : ITarget
    {
        public void Action() { }
    }

    public interface IAdaptee
    {
        void DifferentAction();
    }

    public class TestAdaptee : IAdaptee
    {
        public void DifferentAction() { }
    }

    public class Adapter : ITarget
    {
        private IAdaptee adaptee;

        public Adapter(IAdaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        public void Action()
        {
            adaptee.DifferentAction();
        }
    }
}
