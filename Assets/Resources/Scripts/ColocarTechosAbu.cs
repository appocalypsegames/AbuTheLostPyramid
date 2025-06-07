using UnityEngine;

public class ColocarTechosAbu : MonoBehaviour {
    
	void Update ()
    {
        switch (PlayerPrefs.GetInt("PiedrasObtenidas"))
        {
            case 0:
                GameObject.Find("Techo").GetComponent<MeshRenderer>().enabled = false;
                GameObject.Find("Techo (1)").GetComponent<MeshRenderer>().enabled = false;
                break;
            case 1:
                GameObject.Find("Techo").GetComponent<MeshRenderer>().enabled = true;
                GameObject.Find("Techo (1)").GetComponent<MeshRenderer>().enabled = false;
                break;
            case 2:
                GameObject.Find("Techo").GetComponent<MeshRenderer>().enabled = false;
                GameObject.Find("Techo (1)").GetComponent<MeshRenderer>().enabled = true;
                break;
            case 3:
                GameObject.Find("Techo").GetComponent<MeshRenderer>().enabled = false;
                GameObject.Find("Techo (1)").GetComponent<MeshRenderer>().enabled = false;
                break;
        }
    }
}
