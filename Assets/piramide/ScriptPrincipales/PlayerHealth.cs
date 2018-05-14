using Invector.CharacterController;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {


    //public variables

    public int startingHealth = 100;  //el inicio de la salud 
    public int currentHealth; // nuesta salud actual 
    public Slider healthslider; // control deslizando de la salud 
    public Image damageImage; // imagen en la pantalla que parpadea al ser herido nuestro player  
    public AudioClip deathClip;  //el audio que se repduce cuando nuestro player Muera 
    public float flashSpeed = 5f; // velocidad en la que la imagen sedaña 
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f); // El color que muestra la imagen dañada, al parpadear

    //other private Variables

    Animator anim; //referenciamos el animator component
    AudioSource playerAudio; //referenciamos AudioSource component
    
    // PlayerMovement playerMovement; //referenciamos el movimiento del jugador 
    vThirdPersonInput vThirdPersonInput;
    vThirdPersonController vthirPersonController;

    // PlayerShooting playerShooting; //referenciamos la secuencia de comandos 
    bool isDead; //si el jugador esta muerto
    bool damaged; // es true si dañan al player 



    // Use this for initialization
    void Awake()
    {
        //Configurar las referencias 

        anim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();

        //playerMovement = GetComponent<PlayerMovement>();
        vThirdPersonInput = GetComponent<vThirdPersonInput>();
        vthirPersonController = GetComponent<vThirdPersonController>();

        //playerShooting = GetComponentInChildren<PlayerShooting>();

        //establece el estado inicial del player 

        currentHealth = startingHealth;
	}
	
	// si el juegador recibe daño
	void Update () {

        if (damaged)

            //fija le color de la imagen daño al color del flash
        {
            damageImage.color = flashColour;

            //Si no 
        }
        else
        {
            //pasar el color de nuevo a claro
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }

        //reestablecer el indicador de daño 
        damaged = false;
    }

    public void TakeDamage (int amount)

    {
        //Establecer el indicaro de daño para que la pantalla parpadee.
        damaged = true;

        //Reducir la salud actual para la catidad de daño 
        currentHealth -= amount;

        //Establecer el valor de la barra  de la salud en el estado actual
        healthslider.value = currentHealth;

        //Reproducir el efecto de sonido de daño 
       // playerAudio.Play();



        //si el jugador ha perdido su estado de salud y la barra de muerte aun no ah sido ajustada 
        if (currentHealth <= 0 && !isDead)
        {
            //debe morir
            Death();
        }
    }

    void Death()
    {
        isDead = true;

        //playerShooting.disableEffectcts();

        anim.SetTrigger("Dead");
        playerAudio.clip = deathClip;
        playerAudio.Play();

        vThirdPersonInput.enabled = false;
        vthirPersonController.enabled = false;
        //playerMovement.enabled = false;

        //playerShooting.enabled = true;

    }


}
