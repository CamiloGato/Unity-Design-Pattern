using UnityEngine;

namespace Patterns.Mediator
{
    class VehicleMediator : MonoBehaviour, IVehicle
    {
        [SerializeField] private Wheel[] wheels;
        [SerializeField] private VehicleLight[] lights;
        [SerializeField] private SteeringWheel steeringWheel;
        [SerializeField] private Brake brake;
    }
}