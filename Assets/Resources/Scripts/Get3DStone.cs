using UnityEngine;
using UnityEngine.SceneManagement;

public class Get3DStone : MonoBehaviour {

    public int numeroPiedra;
    
    void Start ()
    {
		if(PlayerPrefs.GetInt("Acertijo") == 0 && SceneManager.GetActiveScene().name == "Guiza")
            gameObject.SetActive(false);

        if(PlayerPrefs.GetInt("Piedra" + numeroPiedra) == 1)
            gameObject.SetActive(false);
	}

	void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Abu")
        {
            PlayerPrefs.SetInt("PiedrasObtenidas", PlayerPrefs.GetInt("PiedrasObtenidas") + 1);
            PlayerPrefs.SetInt("Piedra" + numeroPiedra, 1);
            gameObject.SetActive(false);
        }
    }
}
