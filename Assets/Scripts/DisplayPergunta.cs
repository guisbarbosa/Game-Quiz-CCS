using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayPergunta : MonoBehaviour
{
    public Pergunta pergunta;

    public TMP_Text prefabTitulo;
    public TMP_Text prefabOpcao;
    private List<TMP_Text> respostas;

    private float tituloPosY = 250f;
    private float tituloPosX = 0f;

    private float respostasPosXInicial = -200f;
    private float respostasPosY;
    private float respostasPosYInicial = 100f;
    private float respostasPosYIncremento = -50f;
    // Start is called before the first frame update
    void Start()
    {
        respostas = new List<TMP_Text>();
        SetTexto();
    }

    private void SetTexto(){

        SetTitulo();
        respostasPosY = respostasPosYInicial;
        for (int i = 0; i < pergunta.respostas.Length; i++)
        {
            TMP_Text opcao = Instantiate(prefabOpcao, transform);
            opcao.text = Letra(i)+ ") " + pergunta.respostas[i];
            opcao.transform.localPosition = new Vector3(respostasPosXInicial, respostasPosY, 0f);
            respostas.Add(opcao);
            respostasPosY += respostasPosYIncremento;
        }
    }

    private void SetTitulo(){
        TMP_Text titulo = Instantiate(prefabTitulo, transform);
        titulo.text = pergunta.titulo;
        titulo.transform.localPosition = new Vector3(tituloPosX, tituloPosY, 0f);
    }

    private string Letra(int i){
        switch (i)
        {
            case 0:
                return "A";
            case 1:
                return "B";
            case 2:
                return "C";
            case 3:
                return "D";
            case 4:
                return "E";
            case 5:
                return "F";
            default:
                return "A";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
