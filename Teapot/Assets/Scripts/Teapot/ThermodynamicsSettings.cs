
using UnityEngine;

[CreateAssetMenu(menuName = "ThermodynamicsSettings")]
public class ThermodynamicsSettings : ScriptableObject
{
    public Texture2D Heatmap;

    public float RoomTemperature => _roomTemperature;
    [SerializeField, ReadOnly] private float _roomTemperature = 25f;
}