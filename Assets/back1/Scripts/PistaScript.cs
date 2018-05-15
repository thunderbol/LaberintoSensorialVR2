using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistaScript : MonoBehaviour {

    Movimiento movScript;
    public GameObject BrazoAll;
    public GameObject player;
    public GameObject[] Pistas;
    public Animator[] animPist;
    Collider ColPista;
    bool Comprobador;
    float ValorRot;

    void Start()
    {
        animPist[0] = Pistas[0].GetComponent<Animator>();
        animPist[1] = Pistas[1].GetComponent<Animator>();
        animPist[2] = Pistas[2].GetComponent<Animator>();
        animPist[3] = Pistas[3].GetComponent<Animator>();
        ColPista = Pistas[0].GetComponent<Collider>();

        Comprobador = false;
    }

    void Update () {

        BrazoAll.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, (player.transform.position.z));
        ValorRot = player.transform.eulerAngles.y;
        BrazoAll.transform.eulerAngles = new Vector3(0, ValorRot, 0);

        if (BrazoAll.activeInHierarchy == false)
        {
            Comprobador = false;
            Pistas[0].SetActive(false);
            animPist[0].SetBool("Mostrar", false);
            ColPista.enabled = false;
        }
        else if (Comprobador == false)
        {
            Pistas[0].SetActive(true);
            animPist[0].SetBool("Mostrar", true);
            StartCoroutine(EsperarCollider());
        }

        if (Comprobador == false)
        {
            Pistas[1].SetActive(false);
            Pistas[2].SetActive(false);
            Pistas[3].SetActive(false);
            animPist[1].SetBool("Mostrar", false);
            animPist[2].SetBool("Mostrar", false);
            animPist[3].SetBool("Mostrar", false);
        }

    }
    public void MostrarPistas()
    {
        Comprobador = true;
        StartCoroutine(EsperarPistas());
    }
    public void NoMostrarPistas()
    {
        Comprobador = false;
    }

    IEnumerator EsperarPistas()
    {
        yield return new WaitForSecondsRealtime(2.0f);
        if (Comprobador == true)
        {
            Pistas[0].SetActive(false);
            Pistas[1].SetActive(true);
            Pistas[2].SetActive(true);
            Pistas[3].SetActive(true);
            animPist[1].SetBool("Mostrar", true);
            animPist[2].SetBool("Mostrar", true);
            animPist[3].SetBool("Mostrar", true);
        }
    }

    IEnumerator EsperarCollider()
    {
        yield return new WaitForSecondsRealtime(0.4f);
        ColPista.enabled = true;
    }

    public void MostrarPistas1()
    {
        Debug.Log("Mostrar Pista1");
    }
    public void NoMostrarPistas1()
    {
        Debug.Log("No Mostrar Pista2");
    }
    public void MostrarPistas2()
    {
        Debug.Log("Mostrar Pista2");
    }
    public void NoMostrarPistas2()
    {
        Debug.Log("No Mostrar Pista2");
    }
    public void MostrarPistas3()
    {
        Debug.Log("Mostrar Pista3");
    }
    public void NoMostrarPistas3()
    {
        Debug.Log("No Mostrar Pista3");
    }
}
