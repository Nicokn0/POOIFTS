using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_16_CAbs_Figura_Geometrica_
{
    public abstract class FiguraGeometrica
    {
        double ladoAltura;
        double ladoBase;

        static double superficieTotal;
        static double perimetroTotal;

        public double LadoAltura { get => ladoAltura; set => ladoAltura = value; }
        public double LadoBase { get => ladoBase; set => ladoBase = value; }
        public static double SuperficieTotal { get => superficieTotal; set => superficieTotal = value; }
        public static double PerimetroTotal { get => perimetroTotal; set => perimetroTotal = value; }

        public FiguraGeometrica() { }

        public abstract double Superficie();

        public abstract double Perimetro();

        public override string ToString()
        {
            return ("FIGURA GEOMETRICA:\n ");
        }


    }
}
