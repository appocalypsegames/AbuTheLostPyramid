using UnityEngine;
using UnityEngine.SceneManagement;

public class EntrarPiramideEscalonada : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("PiramideEscalonada");
    }

}
