using UnityEngine;

namespace Patterns.Mediator
{
    public class VehicleLight : MonoBehaviour
    {
        [SerializeField] private new Light light;
        private IVehicle _vehicle;

        public void Configure(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }
        
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