using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirarACamara : MonoBehaviour {

    public new Camera camera;

	void Update ()
    {
		transform.LookAt(camera.transform.position, Vector3.up);
	}

}
