using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoDisparo : MonoBehaviour
{
    private float velocidade = 70;
    [SerializeField] private int Dano = 1;
    public Inimigo alvo;

    public void DefineAlvo(Inimigo inimigo){

        alvo = inimigo;

    }

    void movimento(){

        Vector3 posicaoAtual = transform.position;
        Vector3 frente = transform.forward;
        Vector3 deslocamento = frente * velocidade * Time.deltaTime;
        transform.position = posicaoAtual + deslocamento;

    }

    void OnTriggerEnter (Collider elementoColidido) {

        if (elementoColidido.CompareTag("Inimigo")) {
            
            Destroy (this.gameObject);
            Inimigo inimigo = elementoColidido.GetComponent<Inimigo>();
            inimigo.RecebeDano(Dano);

        }

    }

    void sentido(){

        Vector3 direcao = transform.position;
        Vector3 direcaoInimigo = alvo.transform.position;
        Vector3 novaDirecao = direcaoInimigo - direcao;
        transform.rotation = Quaternion.LookRotation (novaDirecao);

    }

    void AutoDestruir(float segundos) {

        Destroy (this.gameObject, segundos);
    }

    void Start()
    {
        
        AutoDestruir(10);

    }

    // Update is called once per frame
    void Update()
    {
        
        movimento();
        sentido();

    }
}
