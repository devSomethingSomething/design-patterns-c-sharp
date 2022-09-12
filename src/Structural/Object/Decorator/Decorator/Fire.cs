namespace Decorator
{
    public class Fire : WeaponModifierDecorator
    {
        public Fire(IWeapon weapon) : base(weapon) { }

        public override string GetDescription()
        {
            return base.GetDescription() + "\nFire";
        }

        public override int Damage()
        {
            return base.Damage() + 3;
        }
    }
}
