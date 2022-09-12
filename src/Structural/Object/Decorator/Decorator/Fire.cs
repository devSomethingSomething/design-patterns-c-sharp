namespace Decorator
{
    public class Fire : WeaponModifierDecorator
    {
        private Weapon weapon;

        public Fire(Weapon weapon)
        {
            this.weapon = weapon;
        }

        public override string GetDescription()
        {
            return weapon.GetDescription() + "\nFire";
        }

        public override int Damage()
        {
            return weapon.Damage() + 3;
        }
    }
}
