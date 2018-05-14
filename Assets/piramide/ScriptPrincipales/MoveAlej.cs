using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAlejandria : MonoBehaviour
{
    private Animator anim;

    // Use this for initialization
    void Awake()
    {

        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("c"))     
        {
            anim.SetTrigger("JumpAttack");
       }

      //  if (Input.GetKeyDown("v"))
      //  {
           // anim.SetTrigger("Saltar");
      //}

    }

}
