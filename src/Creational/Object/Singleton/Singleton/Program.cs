using System;

namespace Singleton
{
    public class Program
    {
        private static void Main()
        {
            Singleton.Instance().Test();

            Console.ReadKey(true);
        }
    }
}
