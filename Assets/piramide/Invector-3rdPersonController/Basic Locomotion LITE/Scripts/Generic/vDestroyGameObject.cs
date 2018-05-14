using UnityEngine;
using System.Collections;
using System;

public class vDestroyGameObject : MonoBehaviour
{
    public float delay;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(delay);
        Destroy(gameObject);
    }

    internal static vDestroyGameObject FindGameObjectWithTag(string v)
    {
        throw new NotImplementedException();
    }
}
