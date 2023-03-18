using UnityEngine;

namespace Input
{
    class KeyboardInputAdapter : IInput
    {
        public Vector2 GetDirection()
        {
            var horizontal = UnityEngine.Input.GetAxis("Horizontal");
            var vertical = UnityEngine.Input.GetAxis("Vertical");
            var direction = new Vector2(horizontal, vertical);
            
            return direction;
        }

        public bool IsFireActionPressed()
        {
            return UnityEngine.Input.GetButton("Fire1");
        }
    }
}