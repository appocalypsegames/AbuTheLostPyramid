using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Creditos : MonoBehaviour, IPointerClickHandler
{
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton1))
        {
            CrearPrefs();
            Inicializar();
            SceneManager.LoadScene("Creditos");
        }
	}

    public void OnPointerClick(PointerEventData eventData)
    {
        CrearPrefs();
        Inicializar();
        SceneManager.LoadScene("Creditos");
    }

    public void CrearPrefs()
    {
        if (!PlayerPrefs.HasKey("MonedasObtenidas"))
            PlayerPrefs.SetInt("MonedasObtenidas", 0);
        if (!PlayerPrefs.HasKey("LlavesObtenidas"))
            PlayerPrefs.SetInt("LlavesObtenidas", 0);
        if (!PlayerPrefs.HasKey("piedraPiramideEscalonada"))
            PlayerPrefs.SetInt("piedraPiramideEscalonada", 0);
        if (!PlayerPrefs.HasKey("PiedrasObtenidas"))
            PlayerPrefs.SetInt("PiedrasObtenidas", 0);
        if (!PlayerPrefs.HasKey("PiedraThot"))
            PlayerPrefs.SetInt("PiedraThot", 0);
        if (!PlayerPrefs.HasKey("Pausado"))
            PlayerPrefs.SetInt("Pausado", 0);
        if (!PlayerPrefs.HasKey("Acertijo"))
            PlayerPrefs.SetInt("Acertijo", 0);
        if (!PlayerPrefs.HasKey("PuedeGuardar"))
            PlayerPrefs.SetInt("PuedeGuardar", 1);
        if (!PlayerPrefs.HasKey("posx"))
            PlayerPrefs.SetFloat("posx", 0);
        if (!PlayerPrefs.HasKey("posy"))
            PlayerPrefs.SetFloat("posy", 0);
        if (!PlayerPrefs.HasKey("posz"))
            PlayerPrefs.SetFloat("posz", 0);
        if (!PlayerPrefs.HasKey("ResetearPosicion"))
            PlayerPrefs.SetInt("ResetearPosicion", 1);
        if (!PlayerPrefs.HasKey("SaltadoEnunciado"))
            PlayerPrefs.SetInt("SaltadoEnunciado", 0);
        if (!PlayerPrefs.HasKey("Fin"))
            PlayerPrefs.SetInt("Fin", 0);
        if (!PlayerPrefs.HasKey("Llave1"))
            PlayerPrefs.SetInt("Llave1", 0);
        for (int i = 1; i <= 5; i++)
            if (!PlayerPrefs.HasKey("Moneda" + i))
                PlayerPrefs.SetInt("Moneda" + i, 0);
        for (int i = 1; i <= 3; i++)
            if (!PlayerPrefs.HasKey("Piedra" + i))
                PlayerPrefs.SetInt("Piedra" + i, 0);

    }

    public void Inicializar()
    {
        PlayerPrefs.SetInt("MonedasObtenidas", 0);
        PlayerPrefs.SetInt("LlavesObtenidas", 0);
        PlayerPrefs.SetInt("piedraPiramideEscalonada", 0);
        PlayerPrefs.SetInt("PiedrasObtenidas", 0);
        PlayerPrefs.SetInt("PiedraThot", 0);
        PlayerPrefs.SetInt("Pausado", 0);
        PlayerPrefs.SetInt("Acertijo", 0);
        PlayerPrefs.SetInt("PuedeGuardar", 1);
        PlayerPrefs.SetFloat("posx", 0);
        PlayerPrefs.SetFloat("posy", 0);
        PlayerPrefs.SetFloat("posz", 0);
        PlayerPrefs.SetInt("ResetearPosicion", 1);
        PlayerPrefs.SetInt("Llave1", 0);
        PlayerPrefs.SetInt("SaltadoEnunciado", 0);
        PlayerPrefs.SetInt("Fin", 0);
        for (int i = 1; i <= 5; i++)
            PlayerPrefs.SetInt("Moneda" + i, 0);
        for (int i = 1; i <= 3; i++)
            PlayerPrefs.SetInt("Piedra" + i, 0);
    }

}
