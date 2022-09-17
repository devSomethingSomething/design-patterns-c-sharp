using System;

namespace FactoryMethod
{
    public class LightAFrame : Robot
    {
        public override void Register()
        {
            base.Register();
            Console.WriteLine("Light AFrame registered");
        }

        public override void Start()
        {
            base.Start();
            Console.WriteLine("Light AFrame started");
        }

        public override void Update()
        {
            base.Update();
            Console.WriteLine("Light AFrame updated");
        }
    }
}
