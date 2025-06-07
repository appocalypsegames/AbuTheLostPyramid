using UnityEngine;
using UnityEngine.UI;

public class ActivarAlPausar : MonoBehaviour
{
    public Text texto;

    void Start()
    {
        texto = GetComponent<Text>();
    }
    
    void Update()
    {
        if (PlayerPrefs.GetInt("Pausado") == 0)
        {
            var tempColor = texto.color;
            tempColor.a=0f;
            texto.color = tempColor;
        }
        else
        {
            var tempColor = texto.color;
            tempColor.a = 1f;
            texto.color = tempColor;
        }
    }

}
