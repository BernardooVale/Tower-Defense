using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    
    public GameObject prefabTiro;
    private float momentoDoUltimoDisparo = 0;
    public float tempoDeRecarga = 1f;
    public GameObject PontoDisparo;

    private void recarregar () {

        float tempoAtual = Time.time;

        if (tempoAtual > momentoDoUltimoDisparo + tempoDeRecarga) {

            momentoDoUltimoDisparo = tempoAtual;

            atirar();

        }
    }

    void atirar(){

        Vector3 PosicaoDisparo = PontoDisparo.transform.position;
        Instantiate (prefabTiro, PosicaoDisparo, transform.rotation);

    }
    void Start()
    {
        atirar();
    }

    // Update is called once per frame
    void Update()
    {
        
        recarregar();

    }
}
