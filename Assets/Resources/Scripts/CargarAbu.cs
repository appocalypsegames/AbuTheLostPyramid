using UnityEngine;

public class CargarAbu : MonoBehaviour {
    
	void Update () {
        switch (PlayerPrefs.GetInt("PiedrasObtenidas"))
        {
            case 0:
                GetComponent<Renderer>().material= Resources.Load("Materials/AbuPiedras0", typeof(Material)) as Material;
                break;
            case 1:
                GetComponent<Renderer>().material = Resources.Load("Materials/AbuPiedras1", typeof(Material)) as Material;
                break;
            case 2:
                GetComponent<Renderer>().material = Resources.Load("Materials/AbuPiedras2", typeof(Material)) as Material;
                break;
            case 3:
            default:
                GetComponent<Renderer>().material = Resources.Load("Materials/AbuPiedras3", typeof(Material)) as Material;
                break;
        }
    }
}
