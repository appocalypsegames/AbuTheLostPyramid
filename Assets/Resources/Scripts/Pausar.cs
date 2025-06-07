using UnityEngine;
using UnityEngine.SceneManagement;
 
public class Pausar : MonoBehaviour {
    
	void Start ()
    {
        PlayerPrefs.SetInt("Pausado", 0);
	}

	void Update ()
    {

        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.JoystickButton7) && PlayerPrefs.GetInt("Fin") == 0)
            PlayerPrefs.SetInt("Pausado", PlayerPrefs.GetInt("Pausado") > 0 ? 0 : 1);

        if ((Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.JoystickButton6)) && PlayerPrefs.GetInt("Fin") == 0)
            SceneManager.LoadScene("Menu");

    }

}
