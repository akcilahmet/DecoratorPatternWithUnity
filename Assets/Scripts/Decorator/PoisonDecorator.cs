using UnityEngine;

namespace DecoratorPattern
{
    public class PoisonDecorator : WeaponDecorator
    {
        public PoisonDecorator(Weapon weapon) : base(weapon)
        {
        }

        public override void Fire()
        {
            base.Fire();
            Debug.Log("Weapon poisons enemies, causing damage over time.");
        }
    }
}