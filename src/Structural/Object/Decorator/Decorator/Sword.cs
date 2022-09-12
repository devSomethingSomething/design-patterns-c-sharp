namespace Decorator
{
    public class Sword : Weapon
    {
        public Sword()
        {
            Description = "Sword";
        }

        public override int Damage()
        {
            return 5;
        }
    }
}
