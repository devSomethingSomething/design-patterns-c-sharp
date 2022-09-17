using System;

namespace FactoryMethod
{
    public class LightBFrame : Robot
    {
        public override void Register()
        {
            base.Register();
            Console.WriteLine("Light BFrame registered");
        }

        public override void Start()
        {
            base.Start();
            Console.WriteLine("Light BFrame started");
        }

        public override void Update()
        {
            base.Update();
            Console.WriteLine("Light BFrame updated");
        }
    }
}
