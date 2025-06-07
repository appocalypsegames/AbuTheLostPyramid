using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AcertijoAcertado : MonoBehaviour, IPointerClickHandler
{
    int contadorSalir = 0;

    void Update()
    {
        if (PlayerPrefs.GetInt("SaltadoEnunciado") == 1)
        {
            if (Input.GetKeyDown(KeyCode.JoystickButton0) && this.gameObject.name == "Alemania")
            {
                PlayerPrefs.SetInt("Acertijo", 1);
                PonerEnVerde();
            }

            if (PlayerPrefs.GetInt("Acertijo") > 0)
            {
                contadorSalir++;
                if (contadorSalir > 100)
                    SceneManager.LoadScene("Guiza");
            }
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (PlayerPrefs.GetInt("SaltadoEnunciado") == 1)
        {
            PlayerPrefs.SetInt("Acertijo", 1);
            PonerEnVerde();
        }
    }

    private void PonerEnVerde()
    {
        Image image = GetComponent<Image>();
        var tempColor = image.color;
        tempColor.r = 0;
        tempColor.b = 100;
        image.color = tempColor;
    }

}