using System;

namespace FactoryMethod
{
    public class BFrame : IRobot
    {
        public void Register()
        {
            Console.WriteLine("BFrame registered");
        }

        public void Start()
        {
            Console.WriteLine("BFrame started");
        }

        public void Update()
        {
            Console.WriteLine("BFrame updated");
        }
    }
}
