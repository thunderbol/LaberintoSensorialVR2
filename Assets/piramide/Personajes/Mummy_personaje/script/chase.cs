using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chase : MonoBehaviour {
    public float velocidad;

    private Transform playerTransform;
    private float distMin= 1f, distMAx;
    static Animator anim;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        distMAx = GetComponent<SphereCollider>().radius*2;
    }
    
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            playerTransform = other.transform;            
            Vector3 distancia = transform.position - playerTransform.position;
            if(distancia.magnitude >= distMin && distancia.magnitude<= distMAx)
            {
                anim.SetBool("isWalking", true);
                transform.LookAt(other.transform);
                transform.Translate(Vector3.forward * Time.deltaTime*velocidad);
            }
            else if( distancia.magnitude < distMin)
            {
                //transform.Translate( new Vector3(0f,0f,0.5f) * Time.deltaTime * velocidad);
                anim.SetBool("isWalking", false);
                anim.SetBool("isAttacking", true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("isAttacking", false);

        }
    }

    // Update is called once per frame
    /* void Update()
     {
         Vector3 direction = player.position - transform.position;
         float angle = Vector3.Angle(direction, this.transform.forward);
         if (Vector3.Distance(player.position, this.transform.position) < 10 && angle < 60)
         {

             direction.y = 0;
        .....----__._._: // Se reemplaza Rotación de Quartenion con funcion de unity llamada LookAt.


             this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                                         Quaternion.LookRotation(direction), 0.1f);

             anim.SetBool("isIdle", false);
             if (direction.magnitude > 5)
             {
                 this.transform.Translate(0, 0, 0.05f);
                 anim.SetBool("isWalking", true);
                 anim.SetBool("isAttacking", false);

             }
             else
             {
 //                anim.SetBool("isWalking", false);

             }
         }
         else
         {
             anim.SetBool("isIdle", true);
             anim.SetBool("isWalking", false);
             anim.SetBool("isAttacking", false);
         }
     }*/

}
