using UnityEngine;

public class PuedeSaltar : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        PlayerPrefs.SetInt("PuedeSaltar", 1);
    }

    private void OnCollisionExit(Collision collision)
    {
        PlayerPrefs.SetInt("PuedeSaltar", 0);
    }

}
