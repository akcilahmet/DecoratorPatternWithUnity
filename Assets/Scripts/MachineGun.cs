using DecoratorPattern.Data;
using UnityEngine;

namespace DecoratorPattern
{
    public class MachineGun : Weapon
    {
        private WeaponData _weaponData;
        public MachineGun(WeaponData weaponData)
        {
            _weaponData = weaponData;
        }
        
        public override void Fire()
        {
            Debug.Log("Machine gun firing!");
        }
    }
}