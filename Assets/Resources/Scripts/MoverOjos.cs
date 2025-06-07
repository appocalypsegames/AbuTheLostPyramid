using UnityEngine;

public class MoverOjos : MonoBehaviour {

    public int movimientosLaterales;
    public float desplazamiento;
	
	void Update () {
        var x = Input.GetAxis("Horizontal");

        if ((Input.GetKeyDown(KeyCode.A)||x<0)&&movimientosLaterales>-1)
        {
            movimientosLaterales--;
            transform.Translate(-desplazamiento, 0, 0);
        }
        else if ((Input.GetKeyDown(KeyCode.D)||x>0) && movimientosLaterales < 1)
        {
            movimientosLaterales++;
            transform.Translate(desplazamiento, 0, 0);
        }
    }

}
