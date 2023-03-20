using System;
using UnityEngine;

namespace Patterns.Mediator
{
    public class VehicleMediator : MonoBehaviour, IVehicle
    {
        [SerializeField] private Wheel[] wheels;
        [SerializeField] private VehicleLight[] lights;
        [SerializeField] private SteeringWheel steeringWheel;
        [SerializeField] private Brake brake;
        [SerializeField] private Autopilot autopilot;

        private void Awake()
        {
            brake.Configure(this);
            steeringWheel.Configure(this);
            autopilot.Configure(this);
            
            foreach (var wheel in wheels)
            {
                wheel.Configure(this);
            }
            
            foreach (var vehicleLight in lights)
            {
                vehicleLight.Configure(this);
            }
        }

        public void BrakePressed()
        {
            foreach (var wheel in wheels)
            {
                wheel.AddFriction();
            }

            foreach (var breakLight in lights)
            {
                breakLight.TurnOn();
            }
        }

        public void BrakeReleased()
        {
            foreach (var wheel in wheels)
            {
                wheel.RemoveFriction();
            }
        
            foreach (var breakLight in lights)
            {
                breakLight.TurnOff();
            }
        }

        public void LeftPressed()
        {
            foreach (var wheel in wheels)
            {
                wheel.TurnLeft();
            }
        }

        public void RightPressed()
        {
            foreach (var wheel in wheels)
            {
                wheel.TurnRight();
            }
        }

        public void ObstacleDetected()
        {
            BrakePressed();
        }
    }
}