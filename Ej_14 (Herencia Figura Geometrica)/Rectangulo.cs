using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_14__Herencia_Figura_Geometrica_
{
    class Rectangulo : FiguraGeometrica
    {


        public Rectangulo()
        {
            Console.WriteLine("Ingrese la base del rectangulo");
            Lado1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del rectangulo");
            Lado2 = double.Parse(Console.ReadLine());

            Superficietotal += SuperficieRectangulo();
            Radiototal += PerimetroRectangulo();

        }

        public override string ToString()
        {
            return ($" Rectangulo: \n Base del rectangulo: {Lado1} \n Altura del rectangulo: {Lado2} \n Superficie: {SuperficieRectangulo()} \n Perimetro: {PerimetroRectangulo()} \n");
        }
        public double SuperficieRectangulo()
        {
            Superficie = Lado1 * Lado2;
            return Superficie;
        }
        public double PerimetroRectangulo()
        {
            Perimetro = (Lado1 * 2) + (Lado1 * 2);

            return Perimetro;
        }
    }
}

