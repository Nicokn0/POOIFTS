using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_14__Herencia_Figura_Geometrica_
{
    class Cuadrado : FiguraGeometrica
    {

        public Cuadrado()
        {
            Console.WriteLine("Ingrese el lado del cuadrado ");
            Lado1 = double.Parse(Console.ReadLine());

            Superficietotal += SuperficieCuadrado();
            Radiototal += PerimetroCuadrado();
        }

        public override string ToString()
        {
            return ($"Cuadrado: \n El lado del cuadrado mide: {Lado1} .\n La superficie del cuadrado es: {SuperficieCuadrado()} .\n Perimetro: {PerimetroCuadrado()}");
        }

        public double SuperficieCuadrado()
        {


            Superficie = Lado1 * Lado1;

            return Superficie;
        }

        public double PerimetroCuadrado()
        {
            Perimetro = Lado1 * 4;
            return Perimetro;
        }
    }
}
