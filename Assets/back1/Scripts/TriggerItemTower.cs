using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerItemTower : MonoBehaviour {

	public GameObject ubicacion;
    public GameObject player;
    bool Comprobador;

    private string playerget = "Player";
    
    public void TowerEnter()
    {
        Comprobador = true;
        StartCoroutine(EsperarPistas());

    }

    public void TowerExit()
    {
        Comprobador = false;
    }

    IEnumerator EsperarPistas()
    {
        yield return new WaitForSecondsRealtime(2.0f);
        if (Comprobador == true)
        {
            player.transform.position = ubicacion.transform.position;
        }
    }
}
