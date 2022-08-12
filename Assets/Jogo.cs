using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogo : MonoBehaviour
{
    [SerializeField] private GameObject torrePrefab;
    [SerializeField] private GameObject fimJogo;

    public void morreu(){

        fimJogo.SetActive(true);

    }

    private bool Clicou(){

		return Input.GetMouseButtonDown(0); 
	}

    private void construirTorre(){

        Vector3 pontoClique = Input.mousePosition;
        pontoClique.x -= 110;
        pontoClique.y -= 40;
        pontoClique.z += 200;

		Ray raioCamera = Camera.main.ScreenPointToRay (pontoClique);
		RaycastHit infoRaio;
		float comprimentoMaximo = 1000f;
		Physics.Raycast (raioCamera, out infoRaio, comprimentoMaximo);

		if (infoRaio.collider) {
			Vector3 posicao = infoRaio.point;
			Instantiate (torrePrefab, posicao, Quaternion.identity);
        }

    }

    public void RecomecaJogo(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void Start (){

        fimJogo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Clicou()){

            construirTorre();

        }

    }
}
