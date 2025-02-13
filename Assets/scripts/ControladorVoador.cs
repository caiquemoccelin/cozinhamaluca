
using UnityEngine;
using UnityEngine.UI;

public class ControladorVoador : MonoBehaviour
{
    public float deslocamentoObjeto; // Determinar a velocidade inicial do obj
    public float incrementoVelocidade; // Determinar o aumento da velocidade por segundo
    public Sprite[] imagensObjetos;


    internal int sentidoV; // Para qual "lado" o objeto vai na vertical.
    internal Vector3 posicaoOBJ; // A variavel em que indicamos a nova posição 
    internal float deslocamentoABS; // O deslocamento aplicado ao objeto por quadro (update)
    internal int numImagemAtual = 0;


    public float posInicialX;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sentidoV = 1;
        posicaoOBJ = transform.position;
        posInicialX = transform.position.x;

        deslocamentoABS = deslocamentoObjeto;
    }

    // Update is called once per frame
    void Update()
    {
        // Movimentação: Velocidade do deslocamento do objeto, vezes
        //sentido(vertical), vezes "Time.deltaTime", vezes velocidade dinamica

        posicaoOBJ.y += (deslocamentoABS * sentidoV * Time.deltaTime);
        posicaoOBJ.x += deslocamentoABS * Time.deltaTime;

        deslocamentoABS += incrementoVelocidade * Time.deltaTime;
        
        transform.position = posicaoOBJ;

        //limitadores verticais
        if (transform.position.y > 465)
            sentidoV = -1;
        else if (transform.position.y < 41)
            sentidoV = 1;
    }

    public void MudarImagem()
    {
        numImagemAtual += 1;

        if (numImagemAtual == imagensObjetos.Length)
            numImagemAtual = 0;

        GetComponent<Image>().sprite = imagensObjetos[numImagemAtual];




    }








}
