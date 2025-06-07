using UnityEngine;

public class SaltarEnunciado : MonoBehaviour {
    
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.JoystickButton5))
        {
            PlayerPrefs.SetInt("SaltadoEnunciado", 1);
            gameObject.SetActive(false);
        }
    }

}
