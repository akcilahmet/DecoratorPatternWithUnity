using UnityEngine;

namespace DecoratorPattern
{
    public class ShieldDecorator : WeaponDecorator
    {
        public ShieldDecorator(Weapon weapon) : base(weapon) { }

        public override void Fire()
        {
            base.Fire();
            Debug.Log("Weapon activates a shield while firing.");
        }
    }
}