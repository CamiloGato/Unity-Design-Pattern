using UnityEngine;

namespace Ships
{
    public class ShipInstaller : MonoBehaviour
    {
        [SerializeField] private bool useAI;
        [SerializeField] private bool useKeyboard;
        [SerializeField] private Joystick joystick;
        [SerializeField] private Ship ship;
        
        private void Awake()
        {
            ship.Configure(GetInput(), GetCheckLimitsStrategy());
        }

        private ICheckLimits GetCheckLimitsStrategy()
        {
            if (useAI)
            {
                return new InitialPositionCheckLimits(ship.transform, 2f);
            }
            return new ViewportCheckLimits(Camera.main, ship.transform);
        }

        private IInput GetInput()
        {
            if (useAI)
            {
                return new AIInputAdapter(ship);
            }
            
            if (!useKeyboard)
            {
                return new JoystickInputAdapter(joystick);
            }
        
            Destroy(joystick.gameObject);
            return new KeyboardInputAdapter();
        }
    }
}