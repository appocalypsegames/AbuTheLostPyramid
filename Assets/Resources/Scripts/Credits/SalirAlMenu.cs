using UnityEngine;
using UnityEngine.SceneManagement;

public class SalirAlMenu : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) ||  Input.GetKeyDown(KeyCode.JoystickButton6))
            SceneManager.LoadScene("Menu");
    }

}
