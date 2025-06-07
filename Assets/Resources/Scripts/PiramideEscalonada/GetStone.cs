using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetStone : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
        	PlayerPrefs.SetInt("piedraPiramideEscalonada",1);
            PlayerPrefs.SetInt("PiedrasObtenidas", PlayerPrefs.GetInt("PiedrasObtenidas") + 1);
            gameObject.SetActive(false);
        }
    }
}
