using UnityEngine;

public class RotarY : MonoBehaviour {
    
	void Update ()
    {
		transform.Rotate(0,0,100*Time.deltaTime);
	}

}
