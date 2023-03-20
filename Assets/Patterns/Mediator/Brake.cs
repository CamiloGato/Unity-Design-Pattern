using Patterns.Mediator;
using UnityEngine;

public class Brake : MonoBehaviour
{
    private IVehicle _vehicle;

    public void Configure(IVehicle vehicle)
    {
        _vehicle = vehicle;
    }
    
    private void Update()
    {
        if (UnityEngine.Input.GetButtonDown("Jump"))
        {
            _vehicle.BrakePressed();
        }
        else if (UnityEngine.Input.GetButtonUp("Jump"))
        {
            _vehicle.BrakeReleased();
        }
    }
}
