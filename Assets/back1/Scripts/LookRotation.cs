using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookRotation : MonoBehaviour {

    public Transform MirarTransform;

	void Update ()
    {
        transform.LookAt(MirarTransform); // target es el objeto que se quiere seguir...transform colocar el gameobject.tranform
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
    }
}
