namespace Decorator
{
    public class Heavy : WeaponModifierDecorator
    {
        public Heavy(IWeapon weapon) : base(weapon) { }

        public override string GetDescription()
        {
            return base.GetDescription() + "\nHeavy";
        }

        public override int Damage()
        {
            return base.Damage() + 5;
        }
    }
}
