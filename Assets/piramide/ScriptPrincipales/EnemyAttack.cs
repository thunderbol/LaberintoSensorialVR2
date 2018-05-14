using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

    // Public variables

    public float timeBetweenAttAcks = 0.5f; //tiempo en seguntos de cada ataque 
    public int attackDamage = 10; // cantidad de daño generado por los ataques 


    // private variables

    Animator anim; //referenciar al animator component
    GameObject player; //Referencia al jugador
    PlayerHealth playerHealth; //Referencia la vida dle juegador
    //EnemyHealth enemyHealth; //referenciar la salud del enemigo
    bool playerInRange; //si el jugador esta dentro del activador y puede ser atacado
    float timer; //temporizador para contar hastael siguiente ataque 

	// Use this for initialization
	void Awake ()
    {

        //configurar la referencia
        player = GameObject.FindGameObjectWithTag("Player");

        playerHealth = player.GetComponent<PlayerHealth>();

        //enemyHealth = GetComponent<EnemyHealth>();
     
        anim = GetComponent<Animator>();
	}


    void OnTriggerEnter(Collider other)
    {
       // Si el player entra en el colisionador
        if (other.gameObject == player)
        {

            transform.LookAt(other.transform);
            //sim el player esta en el rango
            playerInRange = true;
            anim.SetBool("AttackingM", true);

        }
    }

    void OnTriggerExit(Collider other)
    {  // Si el colisionador que sale es el jugador ...
        if (other.gameObject == player)
        {
             //si el player ya no esta en el rango
            playerInRange = false;
            anim.SetBool("AttackingM", false);
        }
    }

    // Update is called once per frame
    void Update () {

        //Añade el tiempo desde que se actualizó por última vez al temporizador.
        timer += Time.deltaTime;

        // Si el temporizador excede el tiempo entre los ataques, el jugador está en el rango y este enemigo está vivo ...
        if (timer >= timeBetweenAttAcks && playerInRange /*&& enemyHealth.currentHealth > 0 */)
        {
            //llamamos la function attack
            Attack();
        }

        //Si el jugador tiene cero o menos salud ...
        if (playerHealth.currentHealth <= 0)
        {
            //llamamos al animador y le decimos que el player esta muerto y nos traiga la animación de muerte. 
            anim.SetTrigger("PlayerDead");
        }

	}

    void Attack()
    {

        timer = 0f;

        if(playerHealth.currentHealth > 0)
        {
            playerHealth.TakeDamage(attackDamage);

        }
    }
}
