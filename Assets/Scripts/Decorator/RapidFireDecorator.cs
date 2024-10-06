using UnityEngine;

namespace DecoratorPattern
{
    public class RapidFireDecorator: WeaponDecorator
    {
        public RapidFireDecorator(Weapon weapon) : base(weapon)
        {
        }
        
        public override void Fire()
        {
            base.Fire();
            Debug.Log("Weapon fires rapidly.");
        }
    }
}