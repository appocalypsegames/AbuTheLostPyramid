using UnityEngine;
using UnityEngine.SceneManagement;
public class RotateAbu : MonoBehaviour {
    
    float velocidad = 10;
    
	void Update ()
    {
        if (PlayerPrefs.GetInt("Fin") == 1 && velocidad > 0)
        {
            transform.Rotate(0, velocidad, 0);
            velocidad -= 0.03f;
        }

        if(velocidad<=0)
            velocidad -= 0.03f;

        if (velocidad < -4)
        {
            PlayerPrefs.SetInt("Fin", 0);
            SceneManager.LoadScene("Creditos");
        }
    }

}
