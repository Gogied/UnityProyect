using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaObjeto : MonoBehaviour
{

    public bool destruirAutomatico;
    public LogicaPersonaje1 LogicaPersonaje1

    public int tipo;


    //1 = crece
    //2 = aumenta velocidad

    // Start is called before the first frame update
    void Start()
    {
        logicaPersonaje1 = GameObject.FindGameObjectWithTag("Player").GetComponent<LogicaPersonaje1>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Efecto()
    {
        switch (tipo)
        {
            case 1:
                LogicaPersonaje1.GameObject.transform.localScale = new Vector3(3,3,3);
                break;
            case 2:
                LogicaPersonaje1.velocidadInicial +=5;
                break;    
            default:
                DEbug.Log("sin efecto");
                break;
        }
    }

}
