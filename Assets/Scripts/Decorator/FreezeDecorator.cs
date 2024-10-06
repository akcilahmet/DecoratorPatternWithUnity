using UnityEngine;

namespace DecoratorPattern
{
    public class FreezeDecorator : WeaponDecorator
    {
        public FreezeDecorator(Weapon weapon) : base(weapon) { }

        public override void Fire()
        {
            base.Fire();
            Debug.Log("Weapon freezes enemies on hit.");
        }
    }
}