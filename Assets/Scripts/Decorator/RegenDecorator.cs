using UnityEngine;

namespace DecoratorPattern
{
    public class RegenDecorator : WeaponDecorator
    {
        public RegenDecorator(Weapon weapon) : base(weapon)
        {
        }
        public override void Fire()
        {
            base.Fire();
            Debug.Log("Weapon fires regeneration.");
        }
    }
}