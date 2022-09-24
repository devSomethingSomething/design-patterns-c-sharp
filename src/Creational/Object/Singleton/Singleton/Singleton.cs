using System;

namespace Singleton
{
    public class Singleton
    {
        private volatile static Singleton instance;

        private static object toLock = new object();

        private Singleton() { }

        public static Singleton Instance()
        {
            lock (toLock)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
            }

            return instance;
        }

        public void Test()
        {
            Console.WriteLine(nameof(Test));
        }
    }
}
