using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    public class LightMaterial : IMaterial
    {
        public string GetDescription()
        {
            return "Light material";
        }
    }
}
