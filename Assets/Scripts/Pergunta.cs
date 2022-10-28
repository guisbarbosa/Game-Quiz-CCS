using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Pergunta", menuName = "Pergunta")]
public class Pergunta : ScriptableObject
{
    public string titulo;
    public string[] respostas;
    public int respostaCorreta;
    public int dificuldade; // 0 = fácil, 1 = médio, 2 = difícil
    public Sprite imagem;
}
