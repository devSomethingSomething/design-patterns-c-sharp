using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    public class LightRobotComponentFactory : IRobotComponentFactory
    {
        public IMaterial CreateMaterial()
        {
            return new LightMaterial();
        }
    }
}
