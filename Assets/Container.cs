using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{

    public GameObject prefabTorre;

    public bool Clicou (){

        return Input.GetMouseButtonDown(0);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Clicou()){

            Vector3 pontoClique = Input.mousePosition;
            Ray raioDaCamera = Camera.main.ScreenPointToRay(pontoClique);
            RaycastHit infoDoRaio;
            float comprimentoMaximo = 100.0f;

            Physics.Raycast (raioDaCamera, out infoDoRaio, comprimentoMaximo);

            if(infoDoRaio.collider != null) {

                Vector3 posicaoDoElemento = infoDoRaio.point;
                Instantiate(prefabTorre, posicaoDoElemento, Quaternion.identity);
            }
        }

    }
}
