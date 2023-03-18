
using UnityEngine;

namespace Input
{
    class JoystickInputAdapter : IInput
    {
        
        private readonly Joystick _joystick;
        private readonly JoyButton _fireButton;

        public JoystickInputAdapter(Joystick joystick, JoyButton fireButton)
        {
            _joystick = joystick;
            _fireButton = fireButton;
        }

        public Vector2 GetDirection()
        {
            return new Vector2(_joystick.Horizontal, _joystick.Vertical);
        }

        public bool IsFireActionPressed()
        {
            return _fireButton.IsPressed;
        }
    }
}