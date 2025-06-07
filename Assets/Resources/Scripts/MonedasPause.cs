using UnityEngine;
using UnityEngine.UI;

public class MonedasPause : MonoBehaviour
{

    Image imagen;

    void Start()
    {
        imagen = GetComponent<Image>();
    }
    
    void Update()
    {
        if (PlayerPrefs.GetInt("Pausado") == 1)
        {
            var color = imagen.color;
            switch (PlayerPrefs.GetInt("MonedasObtenidas"))
            {
                case 1:
                    color.a = 1f;
                    imagen.color = color;
                    imagen.sprite = Resources.Load("GameSprites/Environment/Moneda1", typeof(Sprite)) as Sprite;
                    break;
                case 2:
                    color.a = 1f;
                    imagen.color = color;
                    imagen.sprite = Resources.Load("GameSprites/Environment/Moneda2", typeof(Sprite)) as Sprite;
                    break;
                case 3:
                    color.a = 1f;
                    imagen.color = color;
                    imagen.sprite = Resources.Load("GameSprites/Environment/Moneda3", typeof(Sprite)) as Sprite;
                    break;
                case 4:
                    color.a = 1f;
                    imagen.color = color;
                    imagen.sprite = Resources.Load("GameSprites/Environment/Moneda4", typeof(Sprite)) as Sprite;
                    break;
                case 5:
                    color.a = 1f;
                    imagen.color = color;
                    imagen.sprite = Resources.Load("GameSprites/Environment/Moneda5", typeof(Sprite)) as Sprite;
                    break;
            }

        }
        else
        {
            var color = imagen.color;
            color.a = 0f;
            imagen.color = color;
        }
    }
}
