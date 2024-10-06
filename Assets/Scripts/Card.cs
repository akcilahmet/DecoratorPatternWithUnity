using UnityEngine;

namespace DecoratorPattern
{
    public class Card : MonoBehaviour
    {
        [SerializeField]
        private CardType _cardType;

        public CardType GetCardType
        {
            get { return _cardType; }
            set { _cardType = value; }
        }

        public enum CardType
        {
            Regen,
            Spell,
            ExplosiveAmmo,
            RapidFire,
            Freeze,
            Poison,
            Shield
        }
    }
}