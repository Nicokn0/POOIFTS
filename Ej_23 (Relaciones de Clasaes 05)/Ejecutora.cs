using System;
using System.Collections.Generic;

namespace Ej_23__Relaciones_de_Clasaes_05_
{
    class Ejecutora
    {
        /*
         
                5) Se tiene un curso del que se conoce su nombre y una lista con todos los alumnos que asisten al mismo. Los alumnos 
        pueden cursar de forma presencial o a distancia. De cada alumno se conoce el nombre y las notas obtenidas en el 
        primer y segundo parcial. 
        
        Además de los alumnos presenciales se conoce la cantidad de inasistencia que tienen y de los 
        alumnos a distancia si aprobaron o no el trabajo práctico que se les solicitó. 
        
        Para aprobar los alumnos deben tener un promedio mayor o igual a 7 y, si es presencial tener menos de 5 inasistencias, y, si cursa a distancia, tener aprobado el 
        trabajo práctico. Se pide hacer un programa y las clases que necesite para: 
      
        a) Agregar un nuevo alumno al curso (con todos sus datos)
        b) Informar el alumno con mayor promedio. 
        c) Informar cuántos alumnos están desaprobados.
         
         */
        static void Main(string[] args)
        {
            List<Curso> ObjListCurso = new List<Curso>();

            Menu(ObjListCurso);
        }

        static void Menu(List<Curso> objListaCurso)
        {
            int opcion = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\n 1-Crear Curso \n 2-Agregar alumno al curso \n 3-Informar alumno con mayor promedio\n 4-Alumnos desaprobados\n 0-Salir \n");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:

                       objListaCurso.Add(new Curso());


                        break;


                    case 2: // Agregar Alumno

                        ListarCursos(objListaCurso);

                        Console.WriteLine("\n Seleccione ID del Curso");
                        objListaCurso[int.Parse(Console.ReadLine())].CrearAlumno();
                        
                        break;

                    case 3: // Informar > Promedio

                        ListarCursos(objListaCurso);

                        Console.WriteLine("\n Seleccione Id del Curso");
                        objListaCurso[int.Parse(Console.ReadLine())].MayorPromedio();

                        break;

                    case 4: // Alumnos desaprobados

                        ListarCursos(objListaCurso);

                        Console.WriteLine("\n Seleccione ID del  Curso");
                        objListaCurso[int.Parse(Console.ReadLine())].AlumnosReprobados();
                        
                        break;

                    default:
                        
                        Console.WriteLine("\n Hasta luego");
                        
                        break;
                }

            } while (opcion != 0);


        }

        public static void ListarCursos(List<Curso> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"\n ID: {i}- {lista[i].NombreCurso}");
            }
        }
    }
    }

