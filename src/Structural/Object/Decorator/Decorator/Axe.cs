namespace Decorator
{
    public class Axe : IWeapon
    {
        public string GetDescription()
        {
            return "Axe";
        }

        public int Damage()
        {
            return 10;
        }
    }
}
