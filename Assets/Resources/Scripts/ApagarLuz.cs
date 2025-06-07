using UnityEngine;

public class ApagarLuz : MonoBehaviour {

    private Light luz;
    public int piramide;

    void Start()
    {
        luz = GetComponent<Light>();
        luz.enabled = false;
    }
    
    void Update()
    {
        switch (piramide)
        {
            case 1:
                if (PlayerPrefs.GetInt("LlavesObtenidas") > 0)
                    luz.enabled = true;
                break;
            case 2:
                if (PlayerPrefs.GetInt("LlavesObtenidas") > 1)
                    luz.enabled = true;
                break;
            default:
                break;
        }
    }

}
