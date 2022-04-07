using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//2. Crear las variables necesarias para ingresar por Inspector el precio de 3 productos
//y un monto de dinero disponible. Comunicar si la suma de los mismos supera o no el monto de dinero disponible. 
//Luego indicar cuánto dinero sobra o falta.

public class Ejercicio2 : MonoBehaviour
{
    public int produ1;
    public int produ2;
    public int produ3;
    public int monto;
    // Start is called before the first frame update
    void Start()
    {
        int total = produ1 + produ2 + produ3;
        int resto = total - monto;
        int falta = resto - monto;

        if (total > monto)
        {
            Debug.Log("El suma supera el monto de dinero. El dinero que le falta es" + falta);
        }
        else if (monto >= total)
        {
            Debug.Log("La suma no supera el monto de dinero. El dinero que le sobra es" + resto);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
