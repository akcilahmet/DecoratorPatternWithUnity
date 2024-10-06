using UnityEngine;

namespace DecoratorPattern
{
    public class GameSceneBootstrapper : MonoBehaviour
    {
        [Header("Business Models")]
        [SerializeField]
        private WeaponManager _weaponManager;

        [Header("View")]
        [SerializeField]
        private DropHandler _dropHandler;

        private void Awake()
        {
            _dropHandler.SetWeaponManager(_weaponManager);
        }
    }
}