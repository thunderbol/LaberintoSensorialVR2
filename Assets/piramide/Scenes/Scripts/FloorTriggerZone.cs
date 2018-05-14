﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTriggerZone : MonoBehaviour
{
    public bool isDamaging;
    public float damage = 10;

    private void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player")
            col.SendMessage((isDamaging) ? "TakeDamage" : "HealDamage", Time.deltaTime * damage);
    }
}
