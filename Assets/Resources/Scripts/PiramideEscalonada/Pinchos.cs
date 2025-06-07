using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinchos : MonoBehaviour {

    bool caer;

	void Start ()
    {
        caer = false;
	}

	void Update ()
    {
        if (caer)
			transform.Translate(Vector3.down * 0.02f);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(PlayerPrefs.GetInt("piedraPiramideEscalonada")==1 && collision.gameObject.tag == "Player")
                caer = true;
    }

}
