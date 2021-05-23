using System;

namespace Ej_02__Vendedor_
{
    /*Crear una clase Vendedor que tendrá atributos nombre, importe total vendido en el primer semestre e importe total vendidos en el segundo semestre. 
     Debe ofrecer métodos para poder informar el importe anual vendido e informar cual fue el semestre de mayor venta.*/

    class EjecutoraVendedor
    {
        static void Main(string[] args)
        {
            string mensaje1 = ("Crear una clase Vendedor que tendrá atributos nombre, importe total vendido en el primer semestre e importe total vendidos en el segundo semestre. Debe ofrecer métodos para poder informar el importe anual vendido e informar cual fue el semestre de mayor venta \n");

            Console.WriteLine(mensaje1);

            Vendedor cliente1 = new Vendedor();

            Console.WriteLine(cliente1);
        }
    }
}
