using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portales : MonoBehaviour {
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (SceneManager.GetActiveScene().name == "Pyramid")
            {
                SceneManager.LoadScene("Tomb");
            }
            else if (SceneManager.GetActiveScene().name == "Tomb")
            {
                return;
            }
        }
        
    }
}
