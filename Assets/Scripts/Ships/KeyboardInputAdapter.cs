using UnityEngine;

namespace Ships
{
    class KeyboardInputAdapter : IInput
    {
        public Vector2 GetDirection()
        {
            var horizontal = Input.GetAxis("Horizontal");
            var vertical = Input.GetAxis("Vertical");
            var direction = new Vector2(horizontal, vertical);
            
            return direction;
        }
    }
}