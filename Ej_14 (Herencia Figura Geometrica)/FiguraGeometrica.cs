using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_14__Herencia_Figura_Geometrica_
{
    class FiguraGeometrica // clase madre
    {
        private double lado1;
        private double lado2;
        private double lado3;
        private double lado4;
        private static double perimetro;
        private static double superficie;

        private static double superficietotal;
        private static double radiototal;

        public double Lado1 { get => lado1; set => lado1 = value; }
        public double Lado2 { get => lado2; set => lado2 = value; }
        public double Lado3 { get => lado3; set => lado3 = value; }
        public double Lado4 { get => lado4; set => lado4 = value; }
        public static double Perimetro { get => perimetro; set => perimetro = value; }
        public static double Superficie { get => superficie; set => superficie = value; }

        public static double Superficietotal { get => superficietotal; set => superficietotal = value; }
        public static double Radiototal { get => radiototal; set => radiototal = value; }
    }
}
