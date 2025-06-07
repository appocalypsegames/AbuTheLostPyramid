using UnityEngine;
using UnityEngine.SceneManagement;

public class MoverAbu : MonoBehaviour {
    
    private Rigidbody rb;
   	public int contadorGuardarPosicion = 0, contadorCrecer = 0;

    public float velocidadSalto;

    bool colliderDestruidos = false;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        if (PlayerPrefs.GetInt("ResetearPosicion") > 0)
            CrearPosicionInicial();
        if(SceneManager.GetActiveScene().name == "Guiza")
            gameObject.transform.position=new Vector3(PlayerPrefs.GetFloat("posx"), PlayerPrefs.GetFloat("posy"), PlayerPrefs.GetFloat("posz"));
        PlayerPrefs.SetInt("PuedeSaltar", 1);
    }

    private void CrearPosicionInicial()
    {
        if (SceneManager.GetActiveScene().name == "Guiza")
        {
            PlayerPrefs.SetFloat("posx", this.transform.position.x);
            PlayerPrefs.SetFloat("posy", this.transform.position.y);
            PlayerPrefs.SetFloat("posz", this.transform.position.z);
            PlayerPrefs.SetInt("ResetearPosicion", 0);
        }
    }

    void Update()
    {

        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.JoystickButton0)) && PlayerPrefs.GetInt("Fin") == 0 && PlayerPrefs.GetInt("PuedeSaltar") == 1)
            rb.velocity += velocidadSalto * Vector3.up;

        if (PlayerPrefs.GetInt("Fin") == 1 && contadorCrecer < 200)
        {
            contadorCrecer++;
            if (!colliderDestruidos)
            {
                Destroy(transform.GetComponent<Rigidbody>());
                foreach (Transform child in transform)
                {
                    Collider[] childCollider = child.GetComponentsInChildren<Collider>();
                    for (int i = 0; i < childCollider.Length; i++)
                        DestroyImmediate(childCollider[i]);
                }
                colliderDestruidos = true;
            }
            transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
            transform.Translate(0, 0.1f, 0);
        }
        
    }

    void FixedUpdate ()
    {
        
        if (PlayerPrefs.GetInt("Pausado") == 0 && PlayerPrefs.GetInt("Fin") == 0)
        {
            var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
            var z = Input.GetAxis("Vertical") * Time.deltaTime * 20.0f;

            transform.Rotate(0, x, 0);
            transform.Translate(0, 0, z);

        }

        if (SceneManager.GetActiveScene().name == "Guiza")
        {
            contadorGuardarPosicion++;
            if (contadorGuardarPosicion > 50 && PlayerPrefs.GetInt("PuedeGuardar") == 1)
            {
                GuardarCoordenadas();
                contadorGuardarPosicion = 0;
            }
        }

    }

    void GuardarCoordenadas()
    {
    	PlayerPrefs.SetFloat("posx", this.transform.position.x);
    	PlayerPrefs.SetFloat("posy", this.transform.position.y);
    	PlayerPrefs.SetFloat("posz", this.transform.position.z);
    }

}
