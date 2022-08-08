using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public int vida;
    private Text campoTexto;

    public void perdeVida () {
    
        vida--;
    }

    void Start () {

        campoTexto = GetComponent<Text> ();
    }
    void Update () {

        campoTexto.text = "Vida:" + vida;
    }
}
