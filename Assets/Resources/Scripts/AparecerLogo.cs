using System;
using UnityEngine;
using UnityEngine.UI;

public class AparecerLogo : MonoBehaviour {
    public Image image;
    public String foto;

    void Start()
    {
        image = GetComponent<Image>();
        foto = this.gameObject.name;
    }
    
    void Update()
    {
        if (PlayerPrefs.GetInt("Fin") == 1)
        { 
            var tempColor = image.color;
            tempColor.a += 0.002f;
            image.color = tempColor;
        }
    }
}
