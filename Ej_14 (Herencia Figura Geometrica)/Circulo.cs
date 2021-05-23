using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_14__Herencia_Figura_Geometrica_
{
    class Circulo : FiguraGeometrica
    {

        private double radio;

        public double Radio { get => radio; set => radio = value; }


        public Circulo()
        {
            Console.WriteLine("Ingrese RADIO del circulo");
            this.radio = double.Parse(Console.ReadLine());
            Superficietotal += SuperficieCirculo();
            Radiototal += SuperficieRadio();
        }

        public override string ToString()
        {
            return ($"Circulo: \n Radio del circulo: {radio}. \n Superficie: {SuperficieCirculo()} \n Perimetro: {SuperficieRadio()} ");
        }

        public double SuperficieCirculo()
        {
            Superficie = 3.14 * (radio * radio);
            return Superficie;
        }

        public double SuperficieRadio() //PERIMETRO
        {
            Perimetro = 2 * 3.14 * radio;

            return Perimetro;
        }
    }
}
