using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class ControladorJogador : MonoBehaviour
{
    public float taxaMovimentacao;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float altX, altY;

        // Para cima e para baixo
        if (Input.GetKey(KeyCode.UpArrow)  && transform.position.y <465)
            altY = 60 * Time.deltaTime * taxaMovimentacao;
        else if (Input.GetKey(KeyCode.DownArrow)  && transform.position.y >41)
            altY = -60 * Time.deltaTime * taxaMovimentacao;
        else
            altY = 0;

        // Para os lados
        if (Input.GetKey(KeyCode.LeftArrow)  && transform.position.x >34)
            altX = -60 * Time.deltaTime * taxaMovimentacao;
        else if (Input.GetKey(KeyCode.RightArrow)  && transform.position.x <925)
            altX = 60 * Time.deltaTime * taxaMovimentacao;
        else
            altX = 0;

        // Modificar posição:

        Vector3 novaPos = new Vector3(altX, altY, 0);
        transform.position += novaPos;

        
    }

}  


