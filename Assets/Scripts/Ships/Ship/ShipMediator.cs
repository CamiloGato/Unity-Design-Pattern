using System;
using Input;
using Ships.CheckLimits;
using Ships.Weapons;
using UnityEngine;

namespace Ships.Ship
{
    [RequireComponent(typeof(MovementController))]
    [RequireComponent(typeof(WeaponController))]
    public class ShipMediator : MonoBehaviour, IShip
    {
        private MovementController _movementController;
        private WeaponController _weaponController;

        private IInput _input;

        public void Configure(IInput input, ICheckLimits checkLimits)
        {
            _input = input;
            _movementController.Configure(this, checkLimits);
            _weaponController.Configure(this);
        }

        private void Awake()
        {
            _movementController = GetComponent<MovementController>();
            _weaponController = GetComponent<WeaponController>();
        }

        private void Update()
        {
            var direction = _input.GetDirection();
            _movementController.Move(direction);
            TryShoot();
        }

        private void TryShoot()
        {
            if (_input.IsFireActionPressed())
                _weaponController.TryShoot();
        }
    }
}