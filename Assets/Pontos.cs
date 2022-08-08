using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontos : MonoBehaviour
{

    [SerializeField] public int pontos;
    private Text campoTexto;

    void Start () {

        campoTexto = GetComponent<Text> ();
    }
    void Update () {

        campoTexto.text = "Pontos:" + pontos;
    }

}
