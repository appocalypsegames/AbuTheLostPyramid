using UnityEngine;

public class MoverAbu2D : MonoBehaviour {

    bool canJump;
    bool trepar;
    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;
    public Sprite abu0a, abu0b, abu0c, abu1a, abu1b, abu1c, abu2a, abu2b, abu2c, abu3a, abu3b, abu3c;

    void Start () {

        PlayerPrefs.SetInt("piedraPiramideEscalonada", 0);

        canJump = true;

        rb = GetComponent<Rigidbody2D>();

        spriteRenderer=GameObject.Find("Abu").GetComponent<SpriteRenderer>();

        switch (PlayerPrefs.GetInt("PiedrasObtenidas"))
        {
            case 0:
                spriteRenderer.sprite = abu0a;
                break;
            case 1:
                spriteRenderer.sprite = abu1a;
                break;
            case 2:
                spriteRenderer.sprite = abu2a;
                break;
            case 3:
                spriteRenderer.sprite = abu3a;
                break;
        }

    }
	
	void Update () {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var y = Input.GetAxis("Vertical") * Time.deltaTime * 20.0f;

        if (Input.GetKey("left") || Input.GetKey(KeyCode.A) || x<0)
        {
            rb.AddForce(new Vector2(-700f * Time.deltaTime, 0));
            switch (PlayerPrefs.GetInt("PiedrasObtenidas"))
            {
                case 0:
                    spriteRenderer.sprite = abu0c;
                    break;
                case 1:
                    spriteRenderer.sprite = abu1c;
                    break;
                case 2:
                    spriteRenderer.sprite = abu2c;
                    break;
                case 3:
                    spriteRenderer.sprite = abu3c;
                    break;
            }
        }

        if(Input.GetKey("right") || Input.GetKey(KeyCode.D) || x > 0)
        {
            rb.AddForce(new Vector2(700f * Time.deltaTime, 0));
            switch (PlayerPrefs.GetInt("PiedrasObtenidas"))
            {
                case 0:
                    spriteRenderer.sprite = abu0b;
                    break;
                case 1:
                    spriteRenderer.sprite = abu1b;
                    break;
                case 2:
                    spriteRenderer.sprite = abu2b;
                    break;
                case 3:
                    spriteRenderer.sprite = abu3b;
                    break;
            }
        }

        if (y > 0 && trepar)
                AccionTrepar(1);

        if (Input.GetKey("up") || Input.GetKey(KeyCode.W) || Input.GetKeyDown(KeyCode.JoystickButton0))
        {
            switch (PlayerPrefs.GetInt("PiedrasObtenidas"))
            {
                case 0:
                    spriteRenderer.sprite = abu0a;
                    break;
                case 1:
                    spriteRenderer.sprite = abu1a;
                    break;
                case 2:
                    spriteRenderer.sprite = abu2a;
                    break;
                case 3:
                    spriteRenderer.sprite = abu3a;
                    break;
            }

            if (trepar) 
                AccionTrepar(1);
            else if(canJump)
                jump();
            
        }

        if (Input.GetKey("down") || Input.GetKey(KeyCode.S) || y < 0)
        {
            switch (PlayerPrefs.GetInt("PiedrasObtenidas"))
            {
                case 0:
                    spriteRenderer.sprite = abu0a;
                    break;
                case 1:
                    spriteRenderer.sprite = abu1a;
                    break;
                case 2:
                    spriteRenderer.sprite = abu2a;
                    break;
                case 3:
                    spriteRenderer.sprite = abu3a;
                    break;
            }
            AccionTrepar(2);
        }
    }

    private void jump()
    {
        canJump = false;
        rb.AddForce(new Vector2(0, 200f));
    }

    private void AccionTrepar(int info)
    {
        if (info == 1)
        {
            rb.gravityScale = 0;
            rb.AddForce(new Vector2(0, 200f * Time.deltaTime));
        }
        else
        {
            rb.gravityScale = 0;
            rb.AddForce(new Vector2(0, -200f * Time.deltaTime));
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Piramide")
            canJump = true;
    }

  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Escalera")
        {
            canJump = false;
            trepar = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        rb.gravityScale = 1;
        trepar = false;
    }

}
