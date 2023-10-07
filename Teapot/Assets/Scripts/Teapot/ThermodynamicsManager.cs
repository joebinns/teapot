using UnityEngine;

public class ThermodynamicsManager : MonoBehaviour 
{
    public static ThermodynamicsManager Instance { get; private set; }

    public ThermodynamicsSettings Settings;
    
    private void Awake() 
    { 
        // If there is an instance, and it's not me, delete myself.
    
        if (Instance != null && Instance != this) 
        { 
            Destroy(this); 
        } 
        else 
        { 
            Instance = this; 
        } 
    }
}