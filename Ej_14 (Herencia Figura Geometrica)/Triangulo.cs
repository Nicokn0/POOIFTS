using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_14__Herencia_Figura_Geometrica_
{
    class Triangulo : FiguraGeometrica
    {
        public Triangulo()
        {
            Inicializar();
            Superficietotal += Super();
            Radiototal += PerimetroTriangulo();
        }

        public override string ToString()
        {
            return ($" Triangulo: Base del triangulo: {Lado1} \n Lado A del Triangulo: {Lado2} \n Lado B del Triangulo: {Lado3} \n Altura: {Lado4} \n Superficie: {Superficie} \n Perimetro: {Perimetro}");
        }

        public void Inicializar()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.Write("Ingrese la base del Triangulo:");
            Lado1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el lado 1 del Triangulo:");
            Lado2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el lado 2  del Triangulo:");
            Lado3 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la Altura del triangulo: ");
            Lado4 = double.Parse(Console.ReadLine());

            Console.WriteLine("\n");
        }


        public double PerimetroTriangulo()
        {

            Perimetro = Lado1 + Lado2 + Lado3;

            return Perimetro;
        }

        public double Super()
        {


            Perimetro = (Lado1 * Lado4) / 2;

            return Perimetro;
        }
    }
}
