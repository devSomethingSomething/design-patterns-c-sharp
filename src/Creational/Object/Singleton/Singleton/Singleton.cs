using System;

namespace Singleton
{
    public class Singleton
    {
        public static Singleton Instance { get; private set; } = new Singleton();

        private Singleton() { }

        public void Test()
        {
            Console.WriteLine(nameof(Test));
        }
    }
}
