using UnityEngine;

public class RandomRotation : MonoBehaviour {
    
	void Update ()
    {
	  transform.Rotate(0.5f,0.5f,20*Time.deltaTime);
	}

}
