using UnityEngine;

namespace Patterns.Mediator
{
    public class VehicleLight : MonoBehaviour
    {
        [SerializeField] private Light light;
        
        public void TurnOn()
        {
            light.enabled = true;
        }
        
        public void TurnOff()
        {
            light.enabled = false;
        }
        
    }
}