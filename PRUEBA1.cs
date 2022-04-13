using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PRUEBA1 : MonoBehaviour
{
    public int dias;
    public int flotataxis;
    public int diaslluvia; 

    void Start()
    {
        int combustible;
        combustible = 130
        int lluvia;
        int diasgral;
        diasgral = dias - diaslluvia;
        lluvia= 120/15
        total = taxis * ((lluvia * (combustible * lluvia))*(diasgral * (combustible * 6))));

        if (dias < 5)
        {
            Debug.Log("Error, la cantidad de dias debe ser mayor a 6");
        }
        else if (lluvia < 0)
        {
            Debug.Log("Error.");
        }
        else if (lluvia > dias)
        {
            Debug.Log("Error.");
        }
        else
        {
            Debug.Log("Una flota de " + taxis + "unidades trabajando durante" + dias + "implicara un gasto de" + total + "pesos en combustible");
        }
    }

    
    void Update()
    {
        
    }
}
