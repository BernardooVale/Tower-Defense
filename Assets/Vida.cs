using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{

	[SerializeField] private Jogo jogo;
    [SerializeField] private int vida = 10; 
	private Text Texto;

	public void PerdeVida(){

		vida --;

		if (vida <= 0){

			jogo.morreu();

		}

	}

	void Start () {

		Texto = GetComponent<Text> ();
	}

	void Update () {

		Texto.text = "Vida: " + vida;
    }
}
