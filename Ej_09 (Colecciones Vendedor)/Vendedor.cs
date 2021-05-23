using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_09__Colecciones_Vendedor_
{
    class Vendedor
    {

        private string nombre;
        private int numero_dni;
        private double venta_primersemestre;
        private double venta_segundosemestre;
        private double acu_ventas;

        private static double acu_ventas_comercio = 0;



        public string Nombre { get => nombre; set => nombre = value; }
        public int Numero_dni { get => numero_dni; set => numero_dni = value; }
        public double Venta_primersemestre { get => venta_primersemestre; set => venta_primersemestre = value; }
        public double Venta_segundosemestre { get => venta_segundosemestre; set => venta_segundosemestre = value; }

        public double Acu_ventas { get => acu_ventas; set => acu_ventas = value; }
        public static double Acu_ventas_comercio { get => acu_ventas_comercio; set => acu_ventas_comercio = value; }


        public Vendedor()
        {

            IngresoDatos();


        }


        public override string ToString()
        {
            Comparar();
            return ($"Nombre: {this.nombre}.\t Número DNI: {this.numero_dni} . \t VENTAS ACUMULADAS: $ {acu_ventas}.");
        }


        public void IngresoDatos()
        {

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.Write("Ingrese nombre del vendedor: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese NUMERO DE DNI:  ");
            numero_dni = int.Parse(Console.ReadLine());
            Console.Write("Ingrese las ventas primer semestre: $ ");
            venta_primersemestre = double.Parse(Console.ReadLine());
            Console.Write("Ingrese las ventas del segundo semestre: $ ");
            venta_segundosemestre = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");


            acu_ventas = venta_primersemestre + venta_segundosemestre;

            acu_ventas_comercio += acu_ventas;
        }


        public void Comparar()
        {
            if (venta_primersemestre > venta_segundosemestre)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"Semestre 1. > Venta: ${venta_primersemestre} \t");
            }
            else
            {
                if (venta_segundosemestre > venta_primersemestre)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"Semestre 2. > Venta: ${venta_segundosemestre} \t");
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Ventas == -Ambos semestres - \t");
                }
            }
        }
    }
}
