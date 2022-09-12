namespace Decorator
{
    public abstract class Weapon
    {
        public string Description { private get; set; } = "Unknown weapon";

        public virtual string GetDescription()
        {
            return Description;
        }

        public abstract int Damage();
    }
}
