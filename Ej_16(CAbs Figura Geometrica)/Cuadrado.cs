using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_16_CAbs_Figura_Geometrica_
{
    class Cuadrado : FiguraGeometrica
    {

        public Cuadrado()
        {
            Console.WriteLine("Ingrese el lado del CUADRADO");
            LadoBase = double.Parse(Console.ReadLine());

            SuperficieTotal += Superficie();
            PerimetroTotal += Perimetro();

        }

        public override string ToString()
        {
            return ($"{base.ToString()} \n CUADRADO: \n Lado: {LadoBase} \t Superficie: {Superficie()} \t Perimetro: {Perimetro()} ");
        }

        public override double Superficie()
        {
            return LadoBase * LadoBase;
        }
        public override double Perimetro()
        {
            return LadoBase * 4;
        }
    }
}
