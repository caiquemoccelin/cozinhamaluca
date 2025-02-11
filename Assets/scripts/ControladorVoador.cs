using UnityEngine;

public class ControladorVoador : MonoBehaviour
{
    public float deslocamentoObjeto;
    internal int sentidoV;
    internal Vector3 posicaoOBJ;

    public float posInicialX;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sentidoV = 1;
        posicaoOBJ = transform.position;
        posInicialX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        posicaoOBJ.y += (deslocamentoObjeto * sentidoV * Time.deltaTime);
        posicaoOBJ.x += deslocamentoObjeto * Time.deltaTime;
        
        
        transform.position = posicaoOBJ;

        //limitadores verticais
        if (transform.position.y > 465)
            sentidoV = -1;
        else if (transform.position.y < 41)
            sentidoV = 1;
    }



}
