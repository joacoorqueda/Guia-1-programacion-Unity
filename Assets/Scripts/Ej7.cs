using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Realizá un programa que al ingresar por Inspector tres números enteros num1, num2 y num3, muestre el valor del mayor de todos.
//En caso de igualdad entre los tres imprimir "Los números son iguales".

public class Ej7 : MonoBehaviour
{
    public int num1;
    public int num2;
    public int num3;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 > num2 && num1 > num3)

            Debug.Log("El primer numero ingresado es el mas grande");

        else if (num2 > num1 && num2 > num3)

            Debug.Log("El segundo numero ingresado es el mas grande");

        else if (num3 > num1 && num3 > num2)

            Debug.Log("El tercer numero ingresado es el mas grande");

        else if (num1 == num2 && num1 == num3)
            Debug.Log("Los numeros son iguales");

        else if (num2 == num1 && num2 == num3)
            Debug.Log("Los numeros son iguales");

        else if (num3 == num2 && num3 == num1)
            Debug.Log("Los numeros son iguales");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
