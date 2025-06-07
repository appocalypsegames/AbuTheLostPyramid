using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OnHoverImageOpacity : MonoBehaviour,IPointerEnterHandler, IPointerExitHandler {

	public Image image;
    
	public void OnPointerEnter(PointerEventData eventData)
    {
        image = GetComponent<Image>();
        var tempColor = image.color;
        if(tempColor.g!=0)
            tempColor.a = 1;
        image.color = tempColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
       	image = GetComponent<Image>();
        var tempColor = image.color;
        if (tempColor.g != 0)
            tempColor.a = 0.6f;
        image.color = tempColor;
    }

}
