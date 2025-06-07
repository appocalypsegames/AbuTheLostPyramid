using UnityEngine;
using UnityEngine.SceneManagement;

public class SalirCogerPiedra : MonoBehaviour {

    int contadorSalir = 0;
	
	void Update ()
    {
        if (PlayerPrefs.GetInt("Piedra3") == 1)
        {
            contadorSalir++;
            if (contadorSalir > 100)
                SceneManager.LoadScene("Guiza");
        }
	}

}
