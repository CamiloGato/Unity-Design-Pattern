using Patterns.Mediator;
using UnityEngine;

public class Brake : MonoBehaviour
{
    [SerializeField] private Wheel[] wheels;
    [SerializeField] private VehicleLight[] breakLights;
    private IVehicle _vehicle;

    public void Configure(IVehicle vehicle)
    {
        _vehicle = vehicle;
    }
    
    private void Update()
    {
        if (UnityEngine.Input.GetButtonDown("Jump"))
        {
            Pressed();
        }
        else if (UnityEngine.Input.GetButtonUp("Jump"))
        {
            Released();
        }
    }

    private void Released()
    {
        foreach (var wheel in wheels)
        {
            wheel.RemoveFriction();
        }
        
        foreach (var breakLight in breakLights)
        {
            breakLight.TurnOff();
        }
    }

    private void Pressed()
    {
        foreach (var wheel in wheels)
        {
            wheel.AddFriction();
        }

        foreach (var breakLight in breakLights)
        {
            breakLight.TurnOn();
        }
    }
}
