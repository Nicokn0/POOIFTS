using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_03__Alumno_
{
    class Alumno
    {
        private string nombre;
        private double nota;
        private bool indice_aprobacion = false;
        private static double acu_nota;


        public string Nombre { get => nombre; set => nombre = value; }
        public double Nota { get => nota; set => nota = value; }
        public bool Indice_aprobacion { get => indice_aprobacion; set => indice_aprobacion = value; }
        public static double Acu_nota { get => acu_nota; set => acu_nota = value; }

        public Alumno()
        {
            Ingreso_Notas();

        }

        public void Ingreso_Notas()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Ingrese el nombre del alumno");
            nombre = Console.ReadLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"Ingrese las 10 notas, NOTA N° {i}  ");
                nota = double.Parse(Console.ReadLine());
                acu_nota += nota;

                if (nota < 4)
                {
                    indice_aprobacion = true;
                }


            }

        }

        public override string ToString()
        {
            if (indice_aprobacion)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("El alumno esta DESAPROBADO");

                return ($"El promedio del alumno fue de : {Promedio(acu_nota)}");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("El alumno esta APROBADO");

                return ($"El promedio del alumno fue de : {Promedio(acu_nota)}");
            }

        }

        static double Promedio(double nota)
        {

            return nota / 10;
        }
    }
}
