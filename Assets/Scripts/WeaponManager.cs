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
        private List<string> addedFeatures = new List<string>();
        private Dictionary<Card.CardType, Func<Weapon, Weapon>> _decorators;
        
        [SerializeField]
        private WeaponData _basicWeaponData;

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

        public void FireWeapon()
        {
            CurrentWeapon.Fire();
        }

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