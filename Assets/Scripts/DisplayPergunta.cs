using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayPergunta : MonoBehaviour
{
    public Pergunta pergunta;

    public TMP_Text titulo;
    public TMP_Text[] respostas;
    // Start is called before the first frame update
    void Start()
    {
        SetTexto();
    }

    private void SetTexto(){
        titulo.text = pergunta.titulo;
        for (int i = 0; i < pergunta.respostas.Length; i++)
        {
            if (i < respostas.Length){
                respostas[i].text = Letra(i)+") " + pergunta.respostas[i];
            }
            else {
                Debug.Log("Display de opção " + Letra(i) + " não encontrada");
            }
        }
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
