using UnityEngine;

public class PuertaPiramideEcalonada : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Abu" && PlayerPrefs.GetInt("LlavesObtenidas")>0 && PlayerPrefs.GetInt("piedraPiramideEscalonada")==0)
            this.GetComponent<Collider>().isTrigger = true;
    }

}
