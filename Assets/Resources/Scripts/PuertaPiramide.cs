using UnityEngine;

public class PuertaPiramide : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Abu" && PlayerPrefs.GetInt("LlavesObtenidas") > 1 && PlayerPrefs.GetInt("Piedra3") == 0)
            this.GetComponent<Collider>().isTrigger = true;
    }

}
