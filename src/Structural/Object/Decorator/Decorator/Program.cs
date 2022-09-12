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
            WeaponModifierDecorator heavy = new Heavy(weapon);
            WeaponModifierDecorator fire = new Fire(heavy);

            // Use delegation to invoke methods
            Console.WriteLine(fire.GetDescription() + "\n" + fire.Damage());

            Console.ReadKey(true);
        }
    }
}
