using UnityEngine;

public class NoGuardar : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        PlayerPrefs.SetInt("PuedeGuardar", 0);
    }

    void OnTriggerExit(Collider other)
    {
        PlayerPrefs.SetInt("PuedeGuardar", 1);
    }

}
