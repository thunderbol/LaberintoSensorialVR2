using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivarCode : MonoBehaviour {

	public GameObject player;
	Movimiento scriptMovimiento;
	public GameObject Master;

	void Start () {

		scriptMovimiento = Master.GetComponent<Movimiento>();

	}

    void OnTriggerEnter(Collider other)
	{
		if (other.gameObject == player)
		{

			StartCoroutine(Esperar());
		}
	}

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {

			scriptMovimiento.enabled = true;
        }
	}

	IEnumerator Esperar()
	{

		yield return new WaitForSecondsRealtime(1.0f);
		scriptMovimiento.enabled = false;
	}

}
