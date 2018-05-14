using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndLineMapController : MonoBehaviour {
    public GameObject panelWarning;

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            panelWarning.SetActive(true);
        }
    }
}
