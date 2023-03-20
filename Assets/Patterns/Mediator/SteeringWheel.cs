using System;
using UnityEngine;

namespace Patterns.Mediator
{
    public class SteeringWheel : MonoBehaviour
    {
        private IVehicle _vehicle;

        public void Configure(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }
        
        private void Update()
        {
            if (UnityEngine.Input.GetKeyDown(KeyCode.A))
            {
                _vehicle.LeftPressed();
            }
            else if (UnityEngine.Input.GetKeyDown(KeyCode.D))
            {
                _vehicle.RightPressed();
            }
        }
    }
}