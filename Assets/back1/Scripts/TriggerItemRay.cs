using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerItemRay : MonoBehaviour {

    public GameObject Cubo;
    //public GameObject Player;
    public float Tiempo = 50000f;


     void Start()
    {
        
    }
    private void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        Cubo.SetActive(true);
        StartCoroutine(ContarTiempo());


    }

    IEnumerator ContarTiempo()
    {
        yield return new WaitForSecondsRealtime(Tiempo);
            print(Tiempo);
            Cubo.SetActive(false);
        





        //StartCoroutine(ContarTiempo());
    }
}
