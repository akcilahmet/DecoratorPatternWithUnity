using System;
using System.Collections.Generic;
using System.Text;
using DecoratorPattern.Data;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

namespace DecoratorPattern
{
    public class WeaponManager : MonoBehaviour
    {
        /// <summary>
        /// A list of added weapon features (decorators).
        /// </summary>
        private List<string> addedFeatures = new List<string>();
        
        /// <summary>
        /// A dictionary to map card types to corresponding weapon decorators.
        /// </summary>
        private Dictionary<Card.CardType, Func<Weapon, Weapon>> _decorators;
        
        [Tooltip("Data representing the basic weapon configuration.")]
        [SerializeField]
        private WeaponData _basicWeaponData;

        [Tooltip("UI text element to display the current weapon's features.")]
        [SerializeField]
        private TMP_Text weaponStatsText;

        public Weapon CurrentWeapon { get; private set; }

        private void Start()
        {
            CurrentWeapon = new MachineGun(_basicWeaponData);
            
            _decorators = new Dictionary<Card.CardType, Func<Weapon, Weapon>>
            {
                { Card.CardType.Regen, weapon => new RegenDecorator(weapon) },
                { Card.CardType.Spell, weapon => new SpellCasterDecorator(weapon) },
                { Card.CardType.ExplosiveAmmo, weapon => new ExplosiveAmmoDecorator(weapon) },
                { Card.CardType.RapidFire, weapon => new RapidFireDecorator(weapon) },
                { Card.CardType.Freeze, weapon => new FreezeDecorator(weapon) },
                { Card.CardType.Poison, weapon => new PoisonDecorator(weapon) },
                { Card.CardType.Shield, weapon => new ShieldDecorator(weapon) }
            };
        }

        /// <summary>
        /// Adds a weapon decorator based on the selected card type.
        /// </summary>
        /// <param name="cardType">The card type representing the feature to be added to the weapon.</param>
        public void AddDecorator(Card.CardType cardType)
        {
            if (_decorators.ContainsKey(cardType))
            {
                CurrentWeapon = _decorators[cardType](CurrentWeapon);
                addedFeatures.Add(cardType.ToString());
                UpdateWeaponStats();
                Debug.Log($"{cardType} added to weapon.");
            }
            else
            {
                Debug.LogWarning("Invalid card type.");
            }
        }

        /// <summary>
        /// Fires the current weapon with all its applied decorators.
        /// </summary>
        public void FireWeapon()
        {
            CurrentWeapon.Fire();
        }

        /// <summary>
        /// Updates the displayed weapon statistics, showing all applied features.
        /// </summary>
        private void UpdateWeaponStats()
        {
            var stats = new StringBuilder("Current Weapon Features:\n");

            foreach (var feature in addedFeatures)
            {
                stats.AppendLine("- " + feature);
            }

            weaponStatsText.text = stats.ToString();
        }
    }
}