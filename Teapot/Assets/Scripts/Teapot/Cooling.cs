using UnityEngine;

[RequireComponent(typeof(Temperature))]
public class Cooling : MonoBehaviour
{
    private Temperature _temperature;
    
    private void Awake()
    {
        _temperature = GetComponent<Temperature>();
    }
    
    private void TendToRoom()
    {
        var tempDiff = (_temperature.Temp - ThermodynamicsManager.Instance.Settings.RoomTemperature);
        _temperature.Temp -= tempDiff * Time.deltaTime * 0.5f;
    }

    private void Update()
    {
        // TODO: If temperature is NOT room temperature...
        TendToRoom();
    }
}
