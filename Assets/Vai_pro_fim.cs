using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vai_pro_fim : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        UnityEngine.AI.NavMeshAgent navegador = GetComponent<UnityEngine.AI.NavMeshAgent>();
        GameObject fim = GameObject.Find("Fim");
        Vector3 coordenada_fim = fim.transform.position;

        navegador.SetDestination(coordenada_fim);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
