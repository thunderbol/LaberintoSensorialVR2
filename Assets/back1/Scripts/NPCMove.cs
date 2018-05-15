using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCMove : MonoBehaviour {

    [Serializefield]

    public Transform _destination;
    public GameObject Player;
    public GameObject ObjectWithNav;

    private NavMeshAgent _navMeshAgent;

	void Start () {

       _navMeshAgent = this.GetComponent<NavMeshAgent>();
    }

    void OnEnable()
    {
        ObjectWithNav.transform.position = Player.transform.position;

    }

    void FixedUpdate ()
    {
        Vector3 targetVector = _destination.transform.position;
        _navMeshAgent.SetDestination(targetVector);
    }
}
