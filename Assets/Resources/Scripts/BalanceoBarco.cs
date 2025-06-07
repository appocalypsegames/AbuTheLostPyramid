using UnityEngine;

public class BalanceoBarco : MonoBehaviour {
	public bool decrecerVelocidad;
	public bool lado;
	public float velocidad;
	
	void Update ()
    {
		if(velocidad==0)
			lado=!lado;
		
		if(lado)
        {
			if(!decrecerVelocidad)
				velocidad-=0.001f;
			else
				velocidad+=0.001f;

			transform.Rotate( 0,0,velocidad);
		}
		else{

			if(decrecerVelocidad)
				velocidad+=0.001f;
			else
				velocidad-=0.001f;

			transform.Rotate( 0,0,velocidad);
		}

		if(velocidad>0.1f||velocidad<-0.1f)
			decrecerVelocidad=!decrecerVelocidad;

	}
}
