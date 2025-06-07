using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminarEnFin : MonoBehaviour {
    
	void Update () {
        if (PlayerPrefs.GetInt("Fin") == 1)
            gameObject.SetActive(false);
    }
}
