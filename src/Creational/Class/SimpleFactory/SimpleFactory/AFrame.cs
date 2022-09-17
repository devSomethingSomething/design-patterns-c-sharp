using System;

namespace SimpleFactory
{
    public class AFrame : IRobot
    {
        public void Register()
        {
            Console.WriteLine("AFrame registered");
        }

        public void Start()
        {
            Console.WriteLine("AFrame started");
        }

        public void Update()
        {
            Console.WriteLine("AFrame updated");
        }
    }
}
