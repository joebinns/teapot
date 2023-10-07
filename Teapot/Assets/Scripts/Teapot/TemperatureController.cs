using UnityEngine;

[RequireComponent(typeof(Temperature), typeof(Stove))]
public class TemperatureController : MonoBehaviour
{
    // TODO: Should I make this a subclass of Temperature?
    
    private Temperature _temperature;
    
    private void Awake()
    {
        _temperature = GetComponent<Temperature>();
        
        var stove = GetComponent<Stove>();
        stove.Light += ToggleHeating;
        stove.Extinguish += ToggleHeating;
    }

    private bool _isHeating = false;
    
    private void ToggleHeating()
    {
        _isHeating = !_isHeating;
    }

    private void Update()
    {
        _temperature.Temp = 0f;
        if (_isHeating)
        {
            _temperature.Temp = 200f;
        }
    }
}
