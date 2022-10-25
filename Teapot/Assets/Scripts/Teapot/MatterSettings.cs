using UnityEngine;

[CreateAssetMenu(menuName = "MatterSettings")]
public class MatterSettings : ScriptableObject
{
    public PhaseTransitionPoints PhaseTransitionPoints;
}

[System.Serializable]
public struct PhaseTransitionPoints
{
    [SerializeField] private int _meltingPoint;
    public int MeltingPoint => _meltingPoint;

    [SerializeField] private int _boilingPoint;
    public int BoilingPoint => _boilingPoint;
}
