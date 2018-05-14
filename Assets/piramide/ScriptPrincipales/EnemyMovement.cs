using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour {

    public Transform player;
    PlayerHealth playerHealth;
    //EnemyHealth enemyHealth;
 //private NavMeshAgent nav;
    

    // Use this for initialization
    void Awake () {

        // Set up the references.
        player = GameObject.FindGameObjectWithTag("Player").transform;
        playerHealth = player.GetComponent<PlayerHealth>();
        //enemyHealth = GetComponent<EnemyHealth>();
        //nav = GetComponent<NavMeshAgent>();

    }
	
	// Update is called once per frame
	void Update () {
        // Si el enemigo y el jugador tienen salud ...

        // if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
        //  {
        
        // .. establezca el destino del agente de malla de navegación al player.
        //nav.SetDestination(player.position);
      //  }
        // Otherwise...
      //  else
       // {
            // ... disable the nav mesh agent.
       //     nav.enabled = false;
       // }
    }
}
