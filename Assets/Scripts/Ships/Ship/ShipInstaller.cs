using Input;
using Ships.CheckLimits;
using UnityEngine;

namespace Ships.Ship
{
    public class ShipInstaller : MonoBehaviour
    {
        [SerializeField] private bool useAI;
        [SerializeField] private bool useKeyboard;
        [SerializeField] private Joystick joystick;
        [SerializeField] private JoyButton fireButton;
        [SerializeField] private ShipMediator shipMediator;
        
        private void Awake()
        {
            shipMediator.Configure(GetInput(), GetCheckLimitsStrategy());
        }

        private ICheckLimits GetCheckLimitsStrategy()
        {
            if (useAI)
            {
                return new InitialPositionCheckLimits(shipMediator.transform, 2f);
            }
            return new ViewportCheckLimits(Camera.main, shipMediator.transform);
        }

        private IInput GetInput()
        {
            if (useAI)
            {
                return new AIInputAdapter(shipMediator);
            }
            
            if (!useKeyboard)
            {
                return new JoystickInputAdapter(joystick,fireButton);
            }
            
            Destroy(joystick.gameObject);
            Destroy(fireButton.gameObject);
            return new KeyboardInputAdapter();
        }
    }
}