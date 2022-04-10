using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//// Realizá un programa donde se cree una variable entera llamada num1, que inicialmente  valdrá 0. 
//Luego incrementá su valor en 2 y mostralo por pantalla. Después mostrá el  resultado de multiplicarlo por sí mismo. 
public class Ej1 : MonoBehaviour
{
    public int num1 = 0;
    // Start is called before the first frame update
    void Start()
    {
        int num2 = num1 + 2;
        int num3 = num2 * num2;

        Debug.Log("variable llamada num1 + 2 es igual a:" + num2);
        Debug.Log("num1 x num1=" + num3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
