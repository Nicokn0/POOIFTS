using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_08__Colecciones_Curso_
{
    class Alumno
    {

        private string nombre;
        private double nota;
        private bool indice_aprobacion = false;
        private double acu_nota;
        private static int contdesaprobados;
        private static double mejorPromedio;
        private static string nombre_mejor_promedio;
        private double resupromedio;

        public string Nombre { get => nombre; set => nombre = value; }
        public double Nota { get => nota; set => nota = value; }
        public bool Indice_aprobacion { get => indice_aprobacion; set => indice_aprobacion = value; }
        public double Acu_nota { get => acu_nota; set => acu_nota = value; }
        public static int Contdesaprobados { get => contdesaprobados; set => contdesaprobados = value; }
        public static string Nombre_mejor_promedio { get => nombre_mejor_promedio; set => nombre_mejor_promedio = value; }
        public static double MejorPromedio { get => mejorPromedio; set => mejorPromedio = value; }
        public double Resupromedio { get => resupromedio; set => resupromedio = value; }

        public Alumno()
        {


            Ingreso_Notas();

            if (mejorPromedio < resupromedio)
            {
                mejorPromedio = resupromedio;
                nombre_mejor_promedio = nombre;

            }


        }


        public override string ToString()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            return ($"ALUMNO: {Nombre}. \t Promedio:  {resupromedio} \n");

        }



        public void Ingreso_Notas()
        {



            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Ingrese el nombre del alumno");
            nombre = Console.ReadLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"Ingrese las 10 notas, NOTA N° {i}  ");
                nota = double.Parse(Console.ReadLine());



                if (i == 9)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("INGRESO 9 NOTAS. DEBE INGRESAR UNA ULTIMA NOTA PARA FINALIZAR LA CARGA DE LA MISMA  \n");
                    Console.Beep();
                }
                acu_nota += nota;

                if (nota < 4)
                {
                    indice_aprobacion = true;

                }

            }

            resupromedio = (Promedio(acu_nota));

            if (resupromedio < 4 || indice_aprobacion == true)
            {
                contdesaprobados++;

            }

            acu_nota = 0;

        }



        static double Promedio(double nota)
        {

            return nota / 10;
        }
    }
}
