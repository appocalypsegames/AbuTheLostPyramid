using UnityEngine;

public class Radiales : MonoBehaviour {

    public int lado;
	
	void Update () {
        transform.Rotate(Vector3.forward * lado);
    }
}
