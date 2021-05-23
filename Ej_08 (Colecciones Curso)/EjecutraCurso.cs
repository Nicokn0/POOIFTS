using System;
using System.Collections.Generic;
namespace Ej_08__Colecciones_Curso_
{
    class EjecutoraCurso
    {
        /* Se tiene un curso del que se conoce su nombre y una lista con todos los
          alumnos que asisten al mismo. De cada alumno se conoce el nombre y las 10
         notas obtenidas en el curso. Se pide hacer un programa definiendo las clases necesarias para:
        
         * Agregar un nuevo alumno al curso (con notas)
         * Informar el alumno con mayor promedio
         * informar cuantos alumnos están desaprobados
         
         */
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string menu = ("\n Menu.\n 1. Agregar Alumnos \n 2. Lista del curso con sus respectivos alumnos y promedios \n 3. Mejor promedio \n 4. Cantidad de alumnos DESAPROBADOS \n 5. FIN DEL PROGRAMA \n");
            int opcion;

            List<Alumno> objalumno = new List<Alumno>();
            Curso nombre_curso = new Curso();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(nombre_curso);

            do
            {
                Console.WriteLine(menu);
                opcion = int.Parse(Console.ReadLine());

                Menu(opcion, objalumno);


            }
            while (opcion != 5);

        }



        static void Menu(int opcion, List<Alumno> alumno)
        {
            switch (opcion)
            {
                case 1:

                    AgregarAlumno(alumno);

                    break;

                case 2:

                    ListaAlumnos(alumno);

                    break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"El mejor promedio fue de : {Alumno.MejorPromedio}. Alumno : {Alumno.Nombre_mejor_promedio}");
                    break;
                case 4:

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"CANTIDAD DE ALUMNOS DESAPROBADOS: {Alumno.Contdesaprobados}");
                    break;
                case 5:

                    Console.WriteLine("FIN DEL PROGRAMA");

                    break;
                default:
                    Console.WriteLine("OPCION INCORRECTA, VUELVA A ELEGIR");
                    break;

            }

        }



        static void AgregarAlumno(List<Alumno> objAlumno)
        {
            char sigue = 'S';

            while (sigue.ToString().ToUpper().Equals("S"))
            {
                Console.WriteLine("\t Ingrese información del Alumno \n");
                objAlumno.Add(new Alumno());

                Console.WriteLine("Ingrese S para continuar con la carga de Alumnos. Cualquier otra tecla para finalizar");
                sigue = char.Parse(Console.ReadLine());
            }
        }

        static void ListaAlumnos(List<Alumno> objAlumno)
        {

            if (objAlumno.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"EN LISTA HAY  --- {objAlumno.Count} --- ALUMNOS \n");

                int i = 1;

                foreach (Alumno alu in objAlumno)
                {
                    Console.Write($"N°: {i++}. ");

                    Console.WriteLine(alu.ToString());


                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("NO SE CARGO NINGUN ELEMENTO");
            }



        }


    }
}