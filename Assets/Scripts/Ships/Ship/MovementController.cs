using System;
using Ships.CheckLimits;
using UnityEngine;

namespace Ships.Ship
{
    public class MovementController : MonoBehaviour
    {
        [SerializeField] private float speed;

        private IShip _ship;
        private Transform _transform;
        
        private ICheckLimits _checkLimits;
        
        public void Configure(IShip ship, ICheckLimits checkLimits)
        {
            _ship = ship;
            _checkLimits = checkLimits;
        }

        private void Awake()
        {
            _transform = transform;
        }

        public void Move(Vector2 direction)
        {
            _transform.Translate(direction * (speed * Time.deltaTime));
            _checkLimits.ClampFinalPosition();
        }
        
    }
}