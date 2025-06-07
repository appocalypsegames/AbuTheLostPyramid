using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetOnTouch : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (PlayerPrefs.GetInt("piedraPiramideEscalonada") == 1)
            {
                PlayerPrefs.SetInt("piedraPiramideEscalonada", 0);
                PlayerPrefs.SetInt("PiedrasObtenidas", PlayerPrefs.GetInt("PiedrasObtenidas") - 1);
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
       
    }
}
