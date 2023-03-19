using System;
using UnityEngine;

namespace Patterns.Mediator
{
    public class SteeringWheel : MonoBehaviour
    {
        [SerializeField] private Wheel[] wheels;

        private void Update()
        {
            if (UnityEngine.Input.GetKeyDown(KeyCode.A))
            {
                TurnLeft();
            }
            else if (UnityEngine.Input.GetKeyDown(KeyCode.D))
            {
                TurnRight();
            }
        }

        private void TurnLeft()
        {
            foreach (var wheel in wheels)
            {
                wheel.TurnLeft();
            }
        }
        
        private void TurnRight()
        {
            foreach (var wheel in wheels)
            {
                wheel.TurnRight();
            }
        }
    }
}