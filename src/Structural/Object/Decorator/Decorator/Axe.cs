namespace Decorator
{
    public class Axe : Weapon
    {
        public Axe()
        {
            Description = "Axe";
        }

        public override int Damage()
        {
            return 10;
        }
    }
}
