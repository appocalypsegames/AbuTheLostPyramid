using UnityEngine;

public class MostrarDialogoEsfinge1 : MonoBehaviour {
    
	void Update ()
    {
        if (PlayerPrefs.GetInt("Acertijo") > 0)
            gameObject.SetActive(false);
	}

}
