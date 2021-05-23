using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_07__Colecciones_Triangulo_
{
    class Triangulo
    {

        private double longitudLado1;

        private double longitudLado2;

        private double longitudLado3;

        private double altura;

        public double LongitudLado1 { get => longitudLado1; set => longitudLado1 = value; }
        public double LongitudLado2 { get => longitudLado2; set => longitudLado2 = value; }
        public double LongitudLado3 { get => longitudLado3; set => longitudLado3 = value; }
        public double Altura { get => altura; set => altura = value; }

        public Triangulo()
        {
            Inicializar();


        }

        public override string ToString()
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            return ($" Lado 1: {longitudLado1} \n Lado 2: {longitudLado2} \n Lado 3:{longitudLado3} \n Altura: {altura} \n\n  Superficie: {Super(longitudLado1, Altura)}. Perimetro: {Perimetro(longitudLado2, longitudLado3, longitudLado1)}\n");
        }
        public void Inicializar()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.Write("Ingrese la longitud 1 del TRIANGULO:");
            longitudLado1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la longitud 2 del Triangulo:");
            longitudLado2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la longitud 3 del Triangulo:");
            longitudLado3 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la Altura del triangulo: ");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("\n");
        }



        //FUNCIONES

        static double Perimetro(double lado1, double lado2, double base_t)
        {
            double resu = 0;

            resu = lado2 + lado1 + base_t;
            return resu;
        }

        static double Super(double bas_t, double alto)
        {
            double resu = 0;

            resu = (bas_t * alto) / 2;

            return resu;
        }
    }

}
