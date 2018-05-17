using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerItemRay : MonoBehaviour
{

    public GameObject Cubo;
    //public GameObject Player;
    public float Tiempo;
    bool Comprobador;


    public void RayoEnter()
    {
        Comprobador = true;
        StartCoroutine(EsperarPistas());
    }

    public void RayoExit()
    {
        Comprobador = false;
    }

    IEnumerator ContarTiempo()
    {
        yield return new WaitForSecondsRealtime(Tiempo);
        print(Tiempo);
        Cubo.SetActive(false);
        //StartCoroutine(ContarTiempo());
    }
    IEnumerator EsperarPistas()
    {
        yield return new WaitForSecondsRealtime(2.0f);
        if (Comprobador == true)
        {
            Cubo.SetActive(true);
            StartCoroutine(ContarTiempo());
        }
    }
}
