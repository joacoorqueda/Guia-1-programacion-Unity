using System.Collections;
using System.Collections.Generic;
using UnityEngine;
////Realizá un programa que resuelva el siguiente problema:  
////Tres personas aportan diferente capital a una sociedad.
//Se desea saber qué porcentaje del total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado  por las tres.
////Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego  mostrar lo pedido en el siguiente formato:  
////Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ ….

public class Ej9 : MonoBehaviour
{
    public int p1;
    public int p2;
    public int p3;
    
    // Start is called before the first frame update
    void Start()
    {


        int total = p1 + p2 + p3;

        Debug.Log("Persona 1: Capital aportado: $" + p1 + ", Porcentaje del capital: %" + ((p1 * 100) / total) + ", Monto total aportado: $" + total);


        Debug.Log("Persona 2: Capital aportado: $" + p2 + ", Porcentaje del capital: %" + ((p2 * 100) / total) + ", Monto total aportado: $" + total);


        Debug.Log("Persona 3: Capital aportado: $" + p3 + ", Porcentaje del capital: %" + ((p3 * 100) / total) + ", Monto total aportado: $" + total);




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
