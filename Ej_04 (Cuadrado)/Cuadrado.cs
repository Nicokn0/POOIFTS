using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_04__Cuadrado_
{
    class Cuadrado
    {
        private double lado;

        public double Lado { get => lado; set => lado = value; }

        public Cuadrado()
        {
            Inicializar();
        }

        public override string ToString()
        {
            return ($"El perimetro del cuadrado es: {ImprimirPerimetro(lado)}. \n La superficie del cuadrado: {Super(lado)}");
        }


        //Método ImprimirPerimetro()

        public void Inicializar()
        {
            Console.Write("Ingrese valor del lado del CUADRADO: \n");
            lado = double.Parse(Console.ReadLine());

        }

        static double ImprimirPerimetro(double lado)
        {
            double perimetro = 0;
            perimetro = lado * 4;
            return perimetro;
        }


        // Funcin superficie 
        static double Super(double lado1)
        {
            double resu = lado1 * lado1;

            return resu;
        }
    }

}
