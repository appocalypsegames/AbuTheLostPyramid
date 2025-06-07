using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EntrarAcertijo : MonoBehaviour {

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Abu" && PlayerPrefs.GetInt("Acertijo") == 0)
            SceneManager.LoadScene("AcertijoEsfinge");
    }

}
