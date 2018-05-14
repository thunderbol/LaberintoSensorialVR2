using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noise : MonoBehaviour
{
    float speed = 1.0f;
    Vector3 moveSize = Vector3.one;
    Vector3 basePosition;

    void Start()
    {
        basePosition = transform.localPosition;
    }

    void Update()
    {
        Vector3 offset = SmoothRandom.GetVector3(speed);
        offset -= new Vector3(0.5f, 0.5f, 0.5f);
        offset = Vector3.Scale(moveSize, offset);
        transform.localPosition = offset + basePosition;
    }
}