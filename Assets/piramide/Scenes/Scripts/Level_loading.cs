using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Level_loading : MonoBehaviour {


	void Start () {

	}

	void OnTriggerEnter(Collider other){
        SceneManager.LoadScene("Tomb");
        
	}

}
