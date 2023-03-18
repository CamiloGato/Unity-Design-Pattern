using UnityEngine;

namespace Ships
{
    public class ShipInstaller : MonoBehaviour
    {
        [SerializeField] private bool useKeyboard;
        [SerializeField] private Joystick joystick;
        [SerializeField] private Ship ship;
        
        private void Awake()
        {
            ship.Configure(GetInput());
        }

        private IInput GetInput()
        {
            if (useKeyboard)
            {
                Destroy(joystick.gameObject);
                return new KeyboardInputAdapter();
            }
            
            return new JoystickInputAdapter(joystick);
        }
    }
}