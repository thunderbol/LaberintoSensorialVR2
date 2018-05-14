using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fisica : MonoBehaviour
{
    public float hoverForce;
    Rigidbody rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        StartCoroutine(Gravedad());
    }

    IEnumerator Gravedad()
    {
        yield return new WaitForSecondsRealtime(0.1f);
        rb.AddForce(0, -hoverForce, 0, ForceMode.VelocityChange);
        StartCoroutine(Gravedad());
    }
}