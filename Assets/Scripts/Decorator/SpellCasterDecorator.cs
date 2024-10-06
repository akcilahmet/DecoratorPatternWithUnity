using UnityEngine;

namespace DecoratorPattern
{
    public class SpellCasterDecorator : WeaponDecorator
    {
        public SpellCasterDecorator(Weapon weapon) : base(weapon)
        {
        }

        public  override void Fire()
        {
            base.Fire();
            Debug.Log("Weapon can cast powerful spells!");
        }
        
    }
}