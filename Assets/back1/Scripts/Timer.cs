using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text TimeText;
    float starTime;
    float T;
    string Minutes;
    string Seconds;
    bool finished = false;

    public TextMesh Time3D;
    float countDown = 50;
    public float AumentarTiempo;

    void Start () {
        starTime = Time.time;

        Time3D.text = "" + countDown;

    }
	

	void Update () {

        if (finished)
            return; // si se pone en true, no ejecute lo que hay de aca para abajo

        T = Time.time - starTime;
        Minutes = ((int)T / 60).ToString();
        Seconds = ((T % 60)).ToString("f0"); //"f2" si se quiere ver los milisegundos
        TimeText.text = Minutes + ":" + Seconds;

        countDown -= Time.deltaTime;
        Time3D.text = "" + countDown.ToString("f2");
        
        //
        if (Input.GetButtonUp("Fire3")) // C en el control
        {
            countDown = countDown - AumentarTiempo;
            // activar pista
        }
        //
        if (countDown <= 0)
        {
            Time3D.text = "Tiempo Acabado";
            //colocar aca resto de condiciones
        }
	}
    public void Finish()
    {
        finished = true;
        TimeText.color = Color.yellow;
    }

    public void MostrarPista()
    {
        countDown = countDown + AumentarTiempo;
    }
}
