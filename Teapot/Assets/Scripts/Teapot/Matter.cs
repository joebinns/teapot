using UnityEngine;

public class Matter : MonoBehaviour
{
    public MatterSettings MatterSettings;

    private void Awake()
    {
        Debug.Log(MatterSettings.PhaseTransitionPoints.MeltingPoint);
    }
}
