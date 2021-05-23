using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_12__Coleccciones_Rectangulo_
{
    class Rectangulo
    {
        private double lado1;
        private double lado2;

        public double Lado1 { get => lado1; set => lado1 = value; }
        public double Lado2 { get => lado2; set => lado2 = value; }

        public Rectangulo()
        {
            Console.WriteLine("Ingrese la base del rectangulo");
            lado1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del rectangulo");
            lado2 = double.Parse(Console.ReadLine());



        }

        public override string ToString()
        {
            return ($"Rectangulo: \n Base del rectangulo: {lado1} \n Altura del rectangulo: {lado2} \n Superficie: {SuperficieRectangulo()} \n Perimetro: {PerimetroRectangulo()} \n");
        }
        public double SuperficieRectangulo()
        {
            return lado1 * lado2;
        }
        public double PerimetroRectangulo()
        {
            return (lado2 * 2) + (lado1 + lado1);
        }
    }
}
