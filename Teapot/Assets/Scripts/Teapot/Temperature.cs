using UnityEngine;

public class Temperature : MonoBehaviour
{

    [SerializeField, ReadOnly] private float _temp;
    
    public float Temp
    {
        get => _temp;
        set => _temp = value;
    }
}
