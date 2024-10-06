using UnityEngine;

namespace DecoratorPattern
{
    public class ExplosiveAmmoDecorator : WeaponDecorator
    {
        public ExplosiveAmmoDecorator(Weapon weapon) : base(weapon)
        {
        }
        
        public override void Fire()
        {
            base.Fire();
            Debug.Log("Weapon uses explosive ammo, dealing area damage.");
        }
    }
}