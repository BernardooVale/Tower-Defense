using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chegou_fim : MonoBehaviour
{
    [SerializeField] private Vida vida;

	private void OnTriggerEnter(Collider collider){

		if (collider.CompareTag("Inimigo")){

			Destroy(collider.gameObject);
			vida.PerdeVida ();
		}
	}
}
