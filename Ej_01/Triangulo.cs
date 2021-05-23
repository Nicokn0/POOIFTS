using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_01
{
    class Triangulo
    {
        private double base_triangulo;

        private double lado1;

        private double lado2;

        private double altura;

        public double Base_triangulo { get => base_triangulo; set => base_triangulo = value; }
        public double Lado1 { get => lado1; set => lado1 = value; }
        public double Lado2 { get => lado2; set => lado2 = value; }
        public double Altura { get => altura; set => altura = value; }

        public Triangulo()
        {
            Inicializar();


        }

        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            return ($"La superficie del Triangulo es: {Super(base_triangulo, Altura)} y el perimetro: {Perimetro(lado1, lado2, base_triangulo)}");
        }
        public void Inicializar()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.Write("Ingrese la base del Triangulo:");
            base_triangulo = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el lado 1 del Triangulo:");
            lado1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el lado 2  del Triangulo:");
            lado2 = double.Parse(Console.ReadLine());

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
