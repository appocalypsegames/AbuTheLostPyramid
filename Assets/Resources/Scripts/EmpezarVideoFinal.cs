using UnityEngine;

public class EmpezarVideoFinal : MonoBehaviour {

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Abu" && PlayerPrefs.GetInt("PiedrasObtenidas") == 3)
            PlayerPrefs.SetInt("Fin", 1);
    }

}
