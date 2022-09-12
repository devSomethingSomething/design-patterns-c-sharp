namespace Decorator
{
    public class Heavy : WeaponModifierDecorator
    {
        private Weapon weapon;

        public Heavy(Weapon weapon)
        {
            this.weapon = weapon;
        }

        public override string GetDescription()
        {
            return weapon.GetDescription() + "\nHeavy";
        }

        public override int Damage()
        {
            return weapon.Damage() + 5;
        }
    }
}
