using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tocado : MonoBehaviour {

    public GameObject Texto3D;
    public GameObject Modelo;

    void Start()
    {

        Texto3D.SetActive(false);


    }

    public void AparecerEscalar()
    {

        Texto3D.SetActive(true);
        Modelo.GetComponent<Transform>().transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);

    }

    public void NoAparecerEscalar()
    {

        Texto3D.SetActive(false);
        Modelo.GetComponent<Transform>().transform.localScale = new Vector3(1, 1, 1);

    }

}
