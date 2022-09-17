using System;

namespace FactoryMethod
{
    public abstract class Robot
    {
        public virtual void Register()
        {
            Console.WriteLine("Generic robot registration");
        }

        public virtual void Start()
        {
            Console.WriteLine("Generic robot start");
        }

        public virtual void Update()
        {
            Console.WriteLine("Generic robot update");
        }
    }
}
