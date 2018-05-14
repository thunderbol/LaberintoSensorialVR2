using UnityEngine;
using System.Collections;

public class Outer_Tornado : MonoBehaviour
{

    public float radius = 19.48f;
    public float outsideSpeed = 0.7f;
    public float maxPullInLength = 24.96f;
    public float power = 1;


    Collider[] colliders;

    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }

	void Update ()
    {
        transform.RotateAround(transform.parent.transform.position, Vector3.up, outsideSpeed);
        colliders = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider c in colliders)
        {
            if (c.GetComponent<Rigidbody>() == null)
            {
                continue;
            }
            Rigidbody rigidbody = c.GetComponent<Rigidbody>();
            Ray ray = new Ray(transform.position, c.transform.position - transform.position);
            RaycastHit hit;
            Physics.Raycast(ray, out hit);
            if (hit.distance > maxPullInLength)
            {
                continue;
            }
            if (c.transform.position.z > 8.5)
            {
                Vector3 Force = new Vector3(transform.position.x - c.transform.position.x, rigidbody.velocity.y / 2, transform.position.z - c.transform.position.z) * power;
                rigidbody.AddForceAtPosition(Force, transform.position);
            }
            rigidbody.AddForceAtPosition((transform.position - c.transform.position) * power, transform.position);
        }
	}
}
