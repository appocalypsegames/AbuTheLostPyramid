using UnityEngine;

public class MostrarThotDialogo1 : MonoBehaviour {
    
	void Update () {
        if (PlayerPrefs.GetInt("MonedasObtenidas") >= 5 || PlayerPrefs.GetInt("PiedraThot") != 0)
            gameObject.SetActive(false);
	}
}
