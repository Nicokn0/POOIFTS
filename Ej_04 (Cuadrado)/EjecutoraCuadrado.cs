using System;

namespace Ej_04__Cuadrado_
{

    /* Hacer una clase cuadrado y a su vez poder encontrar la superficie y perimetro de la misma.*/

    class EjecutoraCuadrado
    {
        static void Main(string[] args)
        {
            string mensaje1 = ("Crear una clase CUADRADO que tendrá atributo de un lado. Sus responsabilidades serán calcular el perímetro y calcular la superficie \n \n");

            Console.WriteLine(mensaje1);

            Cuadrado Cuadrado1 = new Cuadrado();

            Console.WriteLine(Cuadrado1);
        }
    }
}
