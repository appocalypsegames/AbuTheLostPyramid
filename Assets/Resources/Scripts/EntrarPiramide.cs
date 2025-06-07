using UnityEngine;
using UnityEngine.SceneManagement;

public class EntrarPiramide : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Abu")
            SceneManager.LoadScene("Laberinto");
    }
}
