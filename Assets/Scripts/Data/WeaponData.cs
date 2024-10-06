using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

namespace DecoratorPattern.Data
{
    [CreateAssetMenu(fileName = "New Weapon Data", menuName = "Weapon/WeaponData")]
    public class WeaponData : ScriptableObject
    {
        /// <summary>
        /// The name of the weapon.
        /// </summary>
        [field: SerializeField]
        public string WeaponName = "Basic Weapon";

        /// <summary>
        /// The base damage dealt by the weapon.
        /// </summary>
        [field: SerializeField]
        public float Damage { get; set; } = 10f;

        /// <summary>
        /// The critical damage multiplier applied when a critical hit occurs.
        /// For example, a value of 1.5 represents 150% critical damage.
        /// </summary>
        [field: SerializeField]
        public float CriticalDamage { get; set; } = 1.5f; // %150 kritik hasar

        /// <summary>
        /// The number of bullets the weapon can hold in a single magazine.
        /// </summary>
        [field: SerializeField]
        public int BulletCapacity { get; set; } = 30; // Mermi kapasitesi

       
        [field: SerializeField]
        public float BulletSpeed { get; set; } = .5f;
        
        [field: SerializeField]
        public float ReloadSpeed { get; set; } = 2f;
    }
}