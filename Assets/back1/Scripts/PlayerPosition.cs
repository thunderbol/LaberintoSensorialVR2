using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.SceneManagement;

public class PlayerPosition : MonoBehaviour {
    const string PositionKey = "PlayerPosition";

    private string playerget = "Player";

    void OnGUI ()
    {   

        //Por si vamos a usar botones en la pantalla del jugador.
        //GUILayout.Label("Ejemplo de Serializacion");
        //GUILayout.Space(20);
        //if (GUILayout.Button("Guardar",GUILayout.Width(120)))
      //  {
      //      SavePosition();
       // }
      //  if (GUILayout.Button("Cargar", GUILayout.Width(120)))
       //{
     //       LoadPosition();
       // }
     //   if (GUILayout.Button("Recargar Escena", GUILayout.Width(120)))
       // {
         //   Reset();
      //  }
    }
    void Update() {
        //if (Input.GetKeyDown (KeyCode.G)) {
        //	SavePosition ();
        //}
       if (Input.GetKeyDown (KeyCode.C)) {
			LoadPosition ();
		}
		if (Input.GetKeyDown (KeyCode.R)) {
			Reset ();
		}

	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == playerget)
        {

                    SavePosition();

        }
    }


    public void SavePosition()
    {
        PositionData pd = new PositionData(transform.position, transform.rotation);
        PlayerPrefs.SetString(PositionKey, JsonUtility.ToJson(pd));
    }

    public void LoadPosition ()
    {
        PositionData pd = JsonUtility.FromJson<PositionData>(PlayerPrefs.GetString(PositionKey));
        if(pd!=null)
        {
            transform.position = pd.Position;
            transform.rotation = pd.Rotation;
        }
    }

    public void Reset ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

[System.Serializable]
public class PositionData
{
    public Vector3 Position;
    public Quaternion Rotation;

    public PositionData (){}
    public PositionData (Vector3 pos, Quaternion rot)
    {
        Position = pos;
        Rotation = rot;
    }
}
