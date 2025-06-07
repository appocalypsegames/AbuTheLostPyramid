using UnityEngine;

public class TrailEsfinge : MonoBehaviour {

    bool lado = true;
    int contadorCambio = 0;

    void Update()
    {
        if (PlayerPrefs.GetInt("Acertijo") == 1)
            gameObject.SetActive(false);

        contadorCambio++;
        if (contadorCambio > 50)
        {
            contadorCambio = 0;
            lado = !lado;
        }

        if (lado)
            transform.Translate(0, 0.5f, 0);
        else
            transform.Translate(0, -0.5f, 0);
    }

}
