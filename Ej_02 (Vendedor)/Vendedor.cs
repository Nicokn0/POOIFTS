using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_02__Vendedor_
{
    class Vendedor
    {
       
        private string nombre;
        private double importe_1Seme;
        private double importe_2Seme;

        public Vendedor()
        {
            Importe();
        }


        public override string ToString()
        {
            Compara(importe_1Seme, importe_2Seme);

            double sumasemetre = SumarSemetres(importe_1Seme, importe_2Seme);

            Console.ForegroundColor = ConsoleColor.Blue;
            return ($"La suma anual del vendedor {nombre} fue de $ { sumasemetre}");
        }

        // METODOS Y FUNCIONES

        public void Importe()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Ingrese el nombre del Vendedor: ");
            nombre = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Ingrese el importe vendido en el primer semetre: $ ");
            importe_1Seme = double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" Ingrese el importe vendido en el segundo semetre: $");
            importe_2Seme = double.Parse(Console.ReadLine());

            Console.WriteLine("\n\n");


        }

        static void Compara(double importe1, double importe2)
        {
            if (importe1 > importe2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"El semestre que mas vendio fue 1 er semestre: ${importe1} \n");
            }
            else
            {
                if (importe2 > importe1)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"El semestre 2 fue el que mas vendio con un importe de : ${importe2} \n");
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Se vendio el mismo importe!!!\n");
                }
            }
        }

        public double SumarSemetres(double importe, double importe2)
        {
            double resu;
            resu = importe + importe2;
            return resu;
        }
    }
}
}
