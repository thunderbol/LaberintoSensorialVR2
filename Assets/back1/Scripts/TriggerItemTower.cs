using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerItemTower : MonoBehaviour {

    Vector3 ubacation = new Vector3();

    public Rigidbody rb;
    public GameObject player;

    private string playerget = "Player";


    public float x1;
    public float y1;
    public float z1;
    



  void Start()
    {
      
        rb = GetComponent<Rigidbody>();
        //hola.text = "";

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == playerget)
        {

            player.transform.position = new Vector3(x1, y1, z1);
            //Destruirimeos el item por el momento hay que serializarlo para ponerlo en el canvas. 
            Destroy(gameObject);
        }
    }

}
