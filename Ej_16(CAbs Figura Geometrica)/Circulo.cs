using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_16_CAbs_Figura_Geometrica_
{
    class Circulo : FiguraGeometrica
    {
        double radio;

        public double Radio { get => radio; set => radio = value; }

        public Circulo()
        {
            Console.WriteLine("Ingrese RADIO del circulo");
            this.radio = double.Parse(Console.ReadLine());

            PerimetroTotal += Perimetro();
            SuperficieTotal += Superficie();
        }

        public override double Perimetro()
        {

            return (2 * 3.14 * radio);
        }

        public override double Superficie()
        {

            return (3.14 * (radio * radio));
        }

        public override string ToString()
        {
            return ($" { base.ToString()} \n Circulo: \t Radio del circulo: {this.radio}. \t Superficie: { Superficie()} \t Perimetro: { Perimetro()} ");
        }
    }
}
