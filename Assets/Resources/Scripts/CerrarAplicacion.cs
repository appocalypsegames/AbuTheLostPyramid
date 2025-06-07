using UnityEngine;
using UnityEngine.SceneManagement;

public class CerrarAplicacion : MonoBehaviour {

	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.Escape) )
         	SceneManager.LoadScene("Menu");
	}
}
