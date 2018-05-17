using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerItemTower : MonoBehaviour {

	public GameObject ubicacion;
    public GameObject player;

    private string playerget = "Player";
    
    public void EnterTower()
    {
      
		player.transform.position = ubicacion.transform.position;
    }

}
