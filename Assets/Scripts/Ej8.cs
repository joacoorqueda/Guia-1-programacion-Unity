﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Crear una variable entera que pueda ser modificada desde el Inspector.Suponiendo que el primer día de la semana es el Domingo
//mostrar el nombre del día correspondiente al valor de la variable “dia”. Si el día no está en el rango  
//permitido debe emitir por pantalla el mensaje de error "El día ingresado no es válido". 

public class Ej8 : MonoBehaviour
{
    public int dia;
    // Start is called before the first frame update
    void Start()
    {

        if (dia == 1)
            Debug.Log("Domingo");

        else if (dia == 2)
            Debug.Log("Lunes");

        else if (dia == 3)
            Debug.Log("Martes");

        else if (dia == 4)
            Debug.Log("Miercoles");

        else if (dia == 5)
            Debug.Log("Jueves");

        else if (dia == 6)
            Debug.Log("Viernes");

        else if (dia == 7)
            Debug.Log("Sabado");

        else
            Debug.Log("El dia ingresado no es valido");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
