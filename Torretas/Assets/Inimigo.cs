using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{

    [SerializeField] private int vida = 100;

    public void RecebeDano(int Dano) {

        vida -= Dano;

        if (vida <= 0) {

            Destroy(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
