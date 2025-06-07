using UnityEngine;

public class PonerCamara : MonoBehaviour {

    public Camera main;
    public Camera fin;
    bool cambioCamara = false;
	
	void Update ()
    {
		if(PlayerPrefs.GetInt("Fin") == 1 && !cambioCamara)
        {
            main.enabled = false;
            fin.enabled = true;
            cambioCamara = true;
        }

        if(cambioCamara)
            transform.Rotate(-0.2f, 0, 0);
    }

}
