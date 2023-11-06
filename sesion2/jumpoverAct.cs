using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpoverAct : MonoBehaviour
{

    overspider notificador;

    int puntos = 0;

    void Start()
    {   
        notificador = GameObject.Find("Room").GetComponent<overspider>();
        notificador.onEventCollection += SumarPuntos;
    }

    void SumarPuntos(int puntos)
    {
        this.puntos += puntos;
        Debug.Log("Puntos: " + this.puntos);
    }

}
