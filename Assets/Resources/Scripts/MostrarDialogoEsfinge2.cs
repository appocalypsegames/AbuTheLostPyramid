using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarDialogoEsfinge2 : MonoBehaviour {

	void Update ()
    {
        if (PlayerPrefs.GetInt("Piedra1") > 0)
            gameObject.SetActive(false);
	}
}
