namespace DecoratorPattern
{
    public abstract class WeaponDecorator : Weapon
    {
        protected Weapon _decoratedWeapon;
        protected WeaponDecorator(Weapon weapon)
        {
            _decoratedWeapon = weapon;
        }
        public override void Fire()
        {
            _decoratedWeapon.Fire();
        }
    }
}