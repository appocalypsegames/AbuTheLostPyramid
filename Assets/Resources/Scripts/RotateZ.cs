using UnityEngine;

public class RotateZ : MonoBehaviour {

    public int velocidad;
    void Update()
    {
        if (velocidad > 0)
        {
            transform.Rotate(0, velocidad, 0);
        }
        else
        {
            transform.Rotate(0, -0.5f, 0);
        }
    }

}
