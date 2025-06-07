using UnityEngine;
using UnityEngine.EventSystems;

public class OnClickQuitButton : MonoBehaviour, IPointerClickHandler {

	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton6))
            Application.Quit();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Application.Quit();
    }

}

