using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPista : MonoBehaviour {

    public string Player = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == Player)
        {
            GameObject.Find("Master").SendMessage("MostrarPista");
            Destroy(gameObject);
            //  Destroy(this); // si se quiere destruir solo el script y dejar la pista como "inhabilitada"
        }
    }
}
