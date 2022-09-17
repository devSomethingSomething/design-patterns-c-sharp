using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    public abstract class Robot
    {
        protected IMaterial material;

        public abstract string Build();
    }
}
