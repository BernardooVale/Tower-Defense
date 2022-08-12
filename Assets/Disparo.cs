using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    
    [SerializeField] private float raioDeAlcance;
    [SerializeField] public GameObject prefabTiro;
    private float momentoDoUltimoDisparo = 0;
    public float tempoDeRecarga = 1f;
    [SerializeField] public GameObject PontoDisparo;

    void atirar(Inimigo inimigo){

        float tempoAtual = Time.time;

        if (tempoAtual > momentoDoUltimoDisparo + tempoDeRecarga) {

        momentoDoUltimoDisparo = tempoAtual;
        GameObject pontoDisparo = this.transform.gameObject;
        Vector3 posicaoPontoDisparo = pontoDisparo.transform.position;
        GameObject projetilObject = (GameObject) Instantiate (prefabTiro, posicaoPontoDisparo, Quaternion.identity);
        MovimentoDisparo bala = projetilObject.GetComponent<MovimentoDisparo>();
        bala.DefineAlvo(inimigo);
        }

    }

    private Inimigo EscolheAlvo(){

        GameObject[] inimigos =
        GameObject.FindGameObjectsWithTag("Inimigo");

        foreach (GameObject inimigo in inimigos) {
        
            if (RaioDeAlcance(inimigo)){

                return inimigo.GetComponent<Inimigo>();
            }

        }

        return null;
    }

    private bool RaioDeAlcance(GameObject inimigo){

        Vector3 posicaoInimigo = Vector3.ProjectOnPlane(inimigo.transform.position,Vector3.up);
        Vector3 posicaoTorre = Vector3.ProjectOnPlane(this.transform.position,Vector3.up);
        float distanciaInimigo = Vector3.Distance(posicaoTorre,posicaoInimigo);

        return distanciaInimigo <= raioDeAlcance;

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Inimigo alvo = EscolheAlvo();

        if (alvo) {
            atirar(alvo);
        }

    }
}
