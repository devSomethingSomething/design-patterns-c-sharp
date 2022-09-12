namespace Decorator
{
    public abstract class WeaponModifierDecorator : IWeapon
    {
        private IWeapon weapon;

        public WeaponModifierDecorator(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public virtual string GetDescription()
        {
            return weapon.GetDescription();
        }

        public virtual int Damage()
        {
            return weapon.Damage();
        }
    }
}
