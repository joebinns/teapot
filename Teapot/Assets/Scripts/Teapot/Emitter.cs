using UnityEngine;

[RequireComponent(typeof(Temperature))]
public class Emitter : MonoBehaviour
{
    [SerializeField] private float _radiusFactor = 1f;
    [SerializeField] private float _emissivity = 1f;
    
    private Collider[] _nearbyColliders;
    private Temperature _temperature;
    
    private void Awake()
    {
        _temperature = GetComponent<Temperature>();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, transform.lossyScale.magnitude * _radiusFactor);
    }

    private void EmitHeat()
    {
        _nearbyColliders = Physics.OverlapSphere(transform.position, transform.lossyScale.magnitude * _radiusFactor);

        foreach (Collider nearbyCollider in _nearbyColliders)
        {
            var thisGameObject = gameObject;
            var nearbyTemperature = nearbyCollider.GetComponent<Temperature>();
            if (nearbyCollider.gameObject == thisGameObject | nearbyTemperature == null)
            {
                continue;
            }
            
            var tempDiff = (_temperature.Temp - nearbyTemperature.Temp);
            // If this object is hotter than the nearby object...
            if (tempDiff > 0)
            {
                // Calculate distance
                var distance = Vector3.Distance(transform.position, nearbyCollider.transform.position);
                
                // Heat up the nearby object
                nearbyTemperature.Temp += tempDiff * Time.deltaTime * Mathf.Pow(distance, -2) * _emissivity;
            }
        }
    }

    void Update()
    {
        EmitHeat();
    }
}
