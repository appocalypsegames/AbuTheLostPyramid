using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogerMoneda : MonoBehaviour {
    
    public int numeroMoneda;

	void Start ()
    {
        if (PlayerPrefs.GetInt("Moneda" + numeroMoneda) > 0)
            gameObject.SetActive(false);
	}
	
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Abu")
        {
            PlayerPrefs.SetInt("MonedasObtenidas", PlayerPrefs.GetInt("MonedasObtenidas") + 1);
            PlayerPrefs.SetInt("Moneda" + numeroMoneda, 1);
            gameObject.SetActive(false);
        }
        
    }
}
