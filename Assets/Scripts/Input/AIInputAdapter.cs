using Ships;
using Ships.Ship;
using UnityEngine;

namespace Input
{
    class AIInputAdapter : IInput
    {
        
        private readonly ShipMediator _ship;
        private int _currentDirectionX;

        public AIInputAdapter(ShipMediator ship)
        {
            _ship = ship;
            _currentDirectionX = 1;
        }

        public Vector2 GetDirection()
        {
            
            return new Vector2(_currentDirectionX, 0);
        }

        public bool IsFireActionPressed()
        {
            return Random.Range(0, 100) < 20;
        }
    }
}