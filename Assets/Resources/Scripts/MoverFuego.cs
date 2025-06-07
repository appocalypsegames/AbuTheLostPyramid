using UnityEngine;

public class MoverFuego : MonoBehaviour {

    bool lado = true;
    int contadorCambio = 0;
    public int estado;
	void Update () {

        switch (estado)
        {
            case 1:
                if (PlayerPrefs.GetInt("LlavesObtenidas") > 0)
                    Mover();
                break;
            case 2:
                if (PlayerPrefs.GetInt("LlavesObtenidas") > 1)
                    Mover();
                break;
            default:
                Mover();
                break;
        }

    }

    private void Mover()
    {
        contadorCambio++;
        if (contadorCambio > 10)
        {
            contadorCambio = 0;
            lado = !lado;
        }

        if (lado)
            transform.Translate(0, 0.1f, 0);
        else
            transform.Translate(0, -0.1f, 0);
    }
}
