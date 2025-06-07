using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AcertijoFallado : MonoBehaviour, IPointerClickHandler
{

    public void Update()
    {
        if (PlayerPrefs.GetInt("SaltadoEnunciado") == 1)
        {
            if (Input.GetKeyDown(KeyCode.JoystickButton1) && this.gameObject.name == "Dinamarca")
                PonerEnRojo();
            if (Input.GetKeyDown(KeyCode.JoystickButton2) && this.gameObject.name == "Inglaterra")
                PonerEnRojo();
            if (Input.GetKeyDown(KeyCode.JoystickButton3) && this.gameObject.name == "Noruega")
                PonerEnRojo();
            if (Input.GetKeyDown(KeyCode.JoystickButton7) && this.gameObject.name == "Suecia")
                PonerEnRojo();
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (PlayerPrefs.GetInt("SaltadoEnunciado") == 1)
            PonerEnRojo();
    }

    private void PonerEnRojo()
    {
        Image image = GetComponent<Image>();
        var tempColor = image.color;
        tempColor.g = 0;
        tempColor.b = 0;
        image.color = tempColor;
    }

}
