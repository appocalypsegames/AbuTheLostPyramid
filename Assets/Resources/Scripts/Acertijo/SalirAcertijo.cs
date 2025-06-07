using UnityEngine;
using UnityEngine.SceneManagement;
public class SalirAcertijo : MonoBehaviour {
	
	void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.JoystickButton6))
            SceneManager.LoadScene("Guiza");
    }

}
