using UnityEngine;
using UnityEngine.UI;

public class LlavesPause : MonoBehaviour {

    Image imagen;

	void Start () {
        imagen = GetComponent<Image>();
    }
	
	void Update () {
        
        if (PlayerPrefs.GetInt("Pausado") == 1)
        {
            var color = imagen.color;
            switch (PlayerPrefs.GetInt("LlavesObtenidas"))
            {
                case 1:
                    color.a = 1f;
                    imagen.color = color;
                    imagen.sprite = Resources.Load("GameSprites/Environment/Llave1", typeof(Sprite)) as Sprite;
                    break;
                case 2:
                    color.a = 1f;
                    imagen.color = color;
                    imagen.sprite = Resources.Load("GameSprites/Environment/Llave2", typeof(Sprite)) as Sprite;
                    break;
                case 3:
                    color.a = 1f;
                    imagen.color = color;
                    imagen.sprite = Resources.Load("GameSprites/Environment/Llave3", typeof(Sprite)) as Sprite;
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
