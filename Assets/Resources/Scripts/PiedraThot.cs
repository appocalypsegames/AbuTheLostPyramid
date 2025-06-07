using UnityEngine;

public class PiedraThot : MonoBehaviour {

    bool haSubido = false;

	void Start ()
    {
        if (PlayerPrefs.GetInt("PiedraThot") > 0)
            gameObject.SetActive(false);

        if (PlayerPrefs.GetInt("MonedasObtenidas") == 5)
        {
            transform.Translate(0, 0, -5f);
            haSubido = true;
        }

    }
	
	void Update ()
    {
        if (PlayerPrefs.GetInt("MonedasObtenidas") == 5 && !haSubido && PlayerPrefs.GetInt("PiedraThot") == 0)
        {
            transform.Translate(0, 0, -5f);
            haSubido = true;
        }
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Abu")
        {
            PlayerPrefs.SetInt("PiedraThot", 1);
            PlayerPrefs.SetInt("LlavesObtenidas", PlayerPrefs.GetInt("LlavesObtenidas") + 1);
            gameObject.SetActive(false);
        }
    }

}
