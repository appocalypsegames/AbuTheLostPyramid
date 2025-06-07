using UnityEngine;
using UnityEngine.UI;
using System;

public class Desaparecer : MonoBehaviour {
public Image image;
public String foto;
public float velocidad;

	void Start ()
    {
		image = GetComponent<Image>();
		foto=this.gameObject.name;
	}
	
	void Update ()
    {
		var tempColor = image.color;
		tempColor.a -= velocidad;
		image.color = tempColor;

        if (tempColor.a < 0)
            gameObject.SetActive(false);
	}
}

