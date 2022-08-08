using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chegouFim : MonoBehaviour
{
    
    [SerializeField] private Vida vida;

    void OnTriggerEnter (Collider collider) {

        if (collider.CompareTag ("Inimigo")) {

            Destroy(collider.gameObject);
            vida.perdeVida();
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
