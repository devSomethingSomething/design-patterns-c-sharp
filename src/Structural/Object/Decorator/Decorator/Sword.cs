namespace Decorator
{
    public class Sword : IWeapon
    {
        public string GetDescription()
        {
            return "Sword";
        }

        public int Damage()
        {
            return 5;
        }
    }
}
