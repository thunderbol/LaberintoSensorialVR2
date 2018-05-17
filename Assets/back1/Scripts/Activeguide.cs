using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activeguide : MonoBehaviour {

    public GameObject Guia;
    const string PositionKey = "PlayerPosition";
    public float Tiempo = 5.0f;
    bool Comprobador;

    public void GuiaEnter()
    {
        Comprobador = true;
        StartCoroutine(EsperarPistas());
    }

    public void GuiaExit()
    {
        Comprobador = false;
    }

    IEnumerator EsperarPistas()
    {
        yield return new WaitForSecondsRealtime(2.0f);
        if (Comprobador == true)
        {
            Activeposition();
        }
    }

    private void Activeposition()
    {
        Guia.SetActive(true);
        StartCoroutine(ContarTiempo());
        SavePosition(Guia);
    }

    private void SavePosition(GameObject guia)
    {
        PositionData pd = new PositionData(transform.position, transform.rotation);
        PlayerPrefs.SetString(PositionKey, JsonUtility.ToJson(pd));
    }

    //private void SavePosition()
    //{
    //    PositionData pd = new PositionData(transform.position, transform.rotation);
    //    PlayerPrefs.SetString(PositionKey, JsonUtility.ToJson(pd));
    //}

    IEnumerator ContarTiempo()
    {
        yield return new WaitForSecondsRealtime(Tiempo);
        print(Tiempo);
        Guia.SetActive(false);
        LoadPosition(Guia);


        //StartCoroutine(ContarTiempo());
    }

    //private void LoadPosition()
    //{
    //    throw new NotImplementedException();
    //}

    private void LoadPosition(GameObject guia)
    {
        PositionData pd = JsonUtility.FromJson<PositionData>(PlayerPrefs.GetString(PositionKey));
        if (pd != null)
        {
            transform.position = pd.Position;
            transform.rotation = pd.Rotation;
        }
    }
}

