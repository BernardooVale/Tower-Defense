using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorInimigos : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject inimigo;
    private float UltimaGeracao;
    [Range(0,3)]
    [SerializeField] private float tempoCriacao = 2f;
    
    void Update () {

        GeraInimigo ();
    }

    private void GeraInimigo () {

        float tempoAtual = Time.time;

            if (tempoAtual > UltimaGeracao + tempoCriacao){

            UltimaGeracao = tempoAtual;
            Vector3 posicaoGerador = this.transform.position;
            Instantiate (inimigo, posicaoGerador,
            Quaternion.identity);
            
        }
    }
}
