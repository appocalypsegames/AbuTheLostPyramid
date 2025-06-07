using UnityEngine;

public class MoverCamara : MonoBehaviour
{
    public Camera main;
    public Camera fin;

    float minY = -45.0f;
    float maxY = 45.0f;
    float sensX = 100.0f;
    float sensY = 100.0f;
    float rotationY = 0.0f;
    float rotationX = 0.0f;

    int contadorGiro = 0;
    bool girar = true;

    void Start()
    {
        main.enabled = true;
        fin.enabled = false;
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("Pausado") == 1 && PlayerPrefs.GetInt("Fin") == 0)
        {
            rotationX += Input.GetAxis("Mouse X") * sensX * Time.deltaTime+ Input.GetAxis("JoystickX") * sensX *Time.deltaTime;
            rotationY += Input.GetAxis("Mouse Y") * sensY * Time.deltaTime + Input.GetAxis("JoystickY") * sensY * Time.deltaTime;
            rotationY = Mathf.Clamp(rotationY, minY, maxY);
            transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
        }

        if (girar)
        {
            contadorGiro++;
            if (contadorGiro > 125)
                girar = false;
            transform.Rotate(0.2f, 0, 0);
        }
    }
}
