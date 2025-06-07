using UnityEngine;

public class MoverPlataforma : MonoBehaviour {
    
    public int contadorMax;
    public int direccion;//1-z 2-y
    bool lado = true;
    int contador = 0;
    float velocidad = 5f;
	
	void Update ()
    {
        if (lado)
        {
            if(direccion==1)
                transform.Translate(0, 0, velocidad * Time.deltaTime);
            else
                transform.Translate(0, velocidad * Time.deltaTime, 0);
            contador++;

            if (contador == contadorMax)
                lado = false;
        }
        else
        {
            if (direccion == 1)
                transform.Translate(0, 0, -velocidad * Time.deltaTime);
            else
                transform.Translate(0, -velocidad * Time.deltaTime, 0);
            contador--;

            if (contador == 0)
                lado = true;
        }
	}

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "Abu")
           GameObject.Find("Abu").transform.Translate(0, 0, lado ? velocidad * Time.deltaTime : -velocidad * Time.deltaTime);
    }

}
