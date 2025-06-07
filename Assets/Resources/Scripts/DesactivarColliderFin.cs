using UnityEngine;

public class DesactivarColliderFin : MonoBehaviour {

    bool colliderDestruidos = false;
	
	void Update ()
    {
        if (PlayerPrefs.GetInt("Fin") == 1)
        {
            if (!colliderDestruidos)
            {
                Collider[] Colliders = GetComponents<Collider>();
                for (int i = 0; i < Colliders.Length; i++)
                    DestroyImmediate(Colliders[i]);
            }
            colliderDestruidos = true;
        }
    }
}

