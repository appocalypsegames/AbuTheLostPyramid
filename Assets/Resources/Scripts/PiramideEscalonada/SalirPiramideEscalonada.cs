using UnityEngine;
using UnityEngine.SceneManagement;

public class SalirPiramideEscalonada : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col){
		SceneManager.LoadScene("Guiza");
	}

}
