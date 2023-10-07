using UnityEngine;

[RequireComponent(typeof(Temperature), typeof(Renderer))]
public class Heatmap : MonoBehaviour
{
    private Temperature _temperature;
    private Renderer _renderer;
    
    private void Awake()
    {
        _temperature = GetComponent<Temperature>();
        _renderer = GetComponent<Renderer>();
    }
    
    private void UpdateColour()
    {
        var tempPercent = Mathf.Clamp01(_temperature.Temp / 150f); // Divide by whatever the max temp is approximately... (Should max temp be a hard limit?)
        var heatmap = ThermodynamicsManager.Instance.Settings.Heatmap;
        var pixelPos = tempPercent * (heatmap.width - 1);
        var colour = heatmap.GetPixel((int)pixelPos, 0);
        _renderer.material.color = colour;
    }

    private void Update()
    {
        // TODO: If temperature is changing...
        UpdateColour();
    }
}
