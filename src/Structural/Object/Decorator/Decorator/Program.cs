using System;

namespace Decorator
{
    public class Program
    {
        private static void Main()
        {
            // Create base weapon with no modifiers
            IWeapon weapon = new Sword();

            // Create modifiers around weapon
            WeaponModifierDecorator modifiedWeapon = new Fire(new Heavy(weapon));

            // Use delegation to invoke methods
            Console.WriteLine(modifiedWeapon.GetDescription() + "\n" + modifiedWeapon.Damage());

            Console.ReadKey(true);
        }
    }
}
