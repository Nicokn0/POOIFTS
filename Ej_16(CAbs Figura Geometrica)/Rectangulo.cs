using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_16_CAbs_Figura_Geometrica_
{
    class Rectangulo : FiguraGeometrica
    {
        public Rectangulo()
        {
            Console.WriteLine("Ingrese la base del rectangulo");
            LadoBase = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del rectangulo");
            LadoAltura = double.Parse(Console.ReadLine());

            SuperficieTotal += Superficie();
            PerimetroTotal += Perimetro();
        }

        public override double Superficie()
        {
            return LadoBase * LadoAltura;
        }

        public override double Perimetro()
        {
            return ((LadoBase * 2) + (LadoAltura * 2));
        }

        public override string ToString()
        {
            return ($"{base.ToString()} \n  RECTANGULO: \n Base: {LadoBase} \t Altura: {LadoAltura} \t Superficie: {Superficie()} \t Perimetro: {Perimetro()} ");
        }

    }
}
