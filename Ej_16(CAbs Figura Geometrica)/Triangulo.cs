using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_16_CAbs_Figura_Geometrica_
{
    class Triangulo : FiguraGeometrica
    {
        double lado3;
        double altura;

        public double Lado3 { get => lado3; set => lado3 = value; }
        public double Alura { get => altura; set => altura = value; }

        public Triangulo()
        {
            Inicializar();
            SuperficieTotal += Superficie();
            PerimetroTotal += Perimetro();
        }


        public override double Perimetro()
        {


            return (LadoAltura + LadoBase + this.lado3);
        }

        public override double Superficie()
        {
            return ((LadoBase * this.Alura) / 2);
        }

        public override string ToString()
        {
            return ($"{ base.ToString()} \n Triangulo : \n Base del triangulo: {LadoBase} \t Lado A del Triangulo: {LadoAltura} \t Lado B del Triangulo: {this.lado3} \t Altura: {this.altura} \t Superficie: {Superficie()} \t Perimetro: {Perimetro()}");
        }

        public void Inicializar()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.Write("Ingrese la base del Triangulo:");
            LadoBase = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el lado A del Triangulo:");
            LadoAltura = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el lado B  del Triangulo:");
            this.lado3 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la Altura del triangulo: ");
            this.Alura = double.Parse(Console.ReadLine());

            Console.WriteLine("\n");
        }
    }
}

