using UnityEngine;

public class CogerLlave : MonoBehaviour {

    public int numeroLlave;

	void Start () {
        if (PlayerPrefs.GetInt("Llave"+numeroLlave) != 0 || (numeroLlave == 2 && PlayerPrefs.GetInt("Acertijo") == 0))
        {
            gameObject.SetActive(false);
        }
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Abu")
        {
            PlayerPrefs.SetInt("LlavesObtenidas", PlayerPrefs.GetInt("LlavesObtenidas") + 1);
            PlayerPrefs.SetInt("Llave"+numeroLlave, 1);
            gameObject.SetActive(false);
        }
    }

}
