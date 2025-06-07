using UnityEngine;

public class TrailFinal : MonoBehaviour
{
    bool lado = true;
    int contadorCambio = 0;

    void Update()
    {
        if(PlayerPrefs.GetInt("Fin") == 1)
            gameObject.SetActive(false);

        if (PlayerPrefs.GetInt("PiedrasObtenidas") == 3)
        {
            contadorCambio++;
            if (contadorCambio > 50)
            {
                contadorCambio = 0;
                lado = !lado;
            }

            if (lado)
                transform.Translate(0, 1f, 0);
            else
                transform.Translate(0, -1f, 0);
        }
    }

}
