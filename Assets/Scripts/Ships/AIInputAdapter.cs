﻿using UnityEngine;

namespace Ships
{
    class AIInputAdapter : IInput
    {
        
        private readonly Ship _ship;
        private int _currentDirectionX;

        public AIInputAdapter(Ship ship)
        {
            _ship = ship;
            _currentDirectionX = 1;
        }

        public Vector2 GetDirection()
        {
            
            return new Vector2(_currentDirectionX, 0);
        }
    }
}