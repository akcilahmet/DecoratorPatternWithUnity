using UnityEngine;
using UnityEngine.EventSystems;

namespace DecoratorPattern
{
    public class DropHandler : MonoBehaviour, IDropHandler
    {
        private WeaponManager _weaponManager;

        public void SetWeaponManager(WeaponManager weaponManager)
        {
            _weaponManager = weaponManager;
        }

        public void OnDrop(PointerEventData eventData)
        {
            GameObject droppedObject = eventData.pointerDrag;
            var cardComponent = droppedObject.GetComponent<Card>();

            if (cardComponent != null)
            {
                _weaponManager.AddDecorator(cardComponent.GetCardType);
                Destroy(droppedObject);
                Debug.Log("Feature added: " + droppedObject.name);
            }
            else
            {
                Debug.LogError("Dropped object does not have a Card component.");
            }
        }
    }
}