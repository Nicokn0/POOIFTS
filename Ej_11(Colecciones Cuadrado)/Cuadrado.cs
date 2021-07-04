using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_11_Colecciones_Cuadrado_
{
    class Cuadrado
    {
        private double lado;

        public double Lado { get => lado; set => lado = value; }

        public Cuadrado() // contructor cuadrado 
        {
            Inicializar();
        }

        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            return ($"El perimetro del cuadrado es: {ImprimirPerimetro(lado)}. \t La superficie del cuadrado: {Super(lado)}");
        }


        //Método ImprimirPerimetro()

        public void Inicializar()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Ingrese valor del lado del CUADRADO:  ");
            lado = double.Parse(Console.ReadLine());

        }

        public double ImprimirPerimetro(double lado)
        {
            double perimetro = 0;
            perimetro = lado * 4;
            return perimetro;
        }


        // Funcin superficie 
        public double Super(double lado1)
        {
            double resu = lado1 * lado1;

            return resu;
        }
    }
}
