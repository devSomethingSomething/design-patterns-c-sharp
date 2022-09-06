using System;

namespace Strategy
{
    public class Program
    {
        private static void Main()
        {
            Duck duck = new MallardDuck();
            TestDuck(duck);

            duck = new RubberDuck();
            TestDuck(duck);

            Console.ReadKey(true);
        }

        private static void TestDuck(Duck duck)
        {
            Console.WriteLine(duck.Display());
            Console.WriteLine(duck.QuackBehavior.Quacking());
            Console.WriteLine(duck.FlyBehavior.Fly());
            Console.WriteLine(duck.Swim());

            Console.WriteLine();
        }
    }
}
