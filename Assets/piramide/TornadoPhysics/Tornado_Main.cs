using UnityEngine;
using System.Collections;

public class Tornado_Main : MonoBehaviour {

    [Tooltip("This controls the radius of your tornados pull range")]
    public float radius = 65.28f;
    public float maxRadiusToPullIn = 10;
    [Tooltip("NEGATIVE NUMBERS ONLY. This pulls objects into the tornado")]
    public float PullingInPower = -70;
    public float MaxPullingIn = 20;

    Collider[] colliders;

    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }
	
	void Update()
    {
        colliders = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider c in colliders)
        {
            if (c.GetComponent<Rigidbody>() == null)
            {
                continue;
            }
            Ray ray = new Ray(transform.position, c.transform.position - transform.position);
            RaycastHit hit;
            Physics.Raycast(ray, out hit);
            if (hit.collider.name != c.gameObject.name || hit.distance < MaxPullingIn)
            {
                continue;
            }
            else
            {
                Rigidbody rigidbody = c.GetComponent<Rigidbody>();
                rigidbody.AddExplosionForce(PullingInPower, transform.position, radius);
            }
        }
	}
}
