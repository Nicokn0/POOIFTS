using System;
using System.Collections.Generic;

namespace Ej_20__Relacion_de_Clases_02_
{
    class Ejecutora
    {
        /*
         
         2. Un instituto tiene una lista de los cursos que dicta.
        De cada curso se conoce su código, nombre y una lista con todos los alumnos que asisten al mismo.
        
        De cada alumno se conoce el nombre y una lista con las notas obtenidas en el curso. 
        Se pide hacer un programa y las clases que necesite para: 

        a) Agregar un nuevo curso que se dictará. 
        b) Agregar un nuevo alumno al curso (sin notas), tener en cuenta que ya puede ser alumno del instituto. 
        c) Dado un código de curso, informar el alumno con mayor promedio. 
        d) Informar cantidad total de alumnos desaprobados en el instituto. 
        e) Agregar una nota a un alumno, conociendo su nombre y el curso.  

         */
        static void Main(string[] args)
        {
            List<Alumno> ObjAlumno = new List<Alumno>();
            List<Curso> ObjCurso = new List<Curso>();

            Menu(ObjAlumno, ObjCurso);

        }

        static void Menu(List<Alumno> ObjAlumno, List<Curso> ObjCurso)
        {


            int opcion;
            string msj = " 1. Ingrese Curso \n 2. Ingrese Alumno sin NOTAS  \n 3. Informar alumno con mayor promedio \n 4. Informar cantidad total de alumnos desaprobados en el INSTITUTO \n 5. Agregar Nota \n 6. Salir ";
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(msj);
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        char sigue = 'S';

                        while (sigue.ToString().ToUpper().Equals("S"))
                        {
                            IngresarCurso(ObjCurso); // Agrego Curso 

                            Console.WriteLine("\n Ingrese S para continuar con la carga de CURSOS. Cualquier otra tecla para finalizar");
                            sigue = char.Parse(Console.ReadLine());
                        }

                        Console.Clear();
                        break;

                    case 2:

                        AgregarAlumnoCurso(ObjCurso);

                        break;

                    case 3:

                        
                        Console.WriteLine("Ingrese ID del  curso \n ");

                        ListarCurso(ObjCurso);

                        if (ObjCurso.Count > 0)
                        {

                            ObjCurso[int.Parse(Console.ReadLine())].CompararPromedio();
                        }

                        else
                        {
                            Console.WriteLine("\n No se cargo ningun curso, todavia. Por favor vuelva a menu y re ingrese curso ");
                        }
                        
                    

                        break;

                    case 4:

                        Desaprobados(ObjCurso);

                        break;

                    case 5:


                        AgregarNotaAlumnos(ObjCurso);

                        break;

                    case 6:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n FIN DEL PROGRAMA");
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opción Invalida, ingrese opción");
                        break;

                }
            } while (opcion != 6);

        }

        static void IngresarCurso(List<Curso> ObjCurso)
        {

            ObjCurso.Add(new Curso(ObjCurso.Count));

        }


        private static void AgregarAlumnoCurso(List<Curso> curso)
        {
            foreach (Curso ingreso_curso in curso)
            {
                Console.WriteLine(ingreso_curso.ToString());
            }
            char sigue = 'S';
            while (sigue.ToString().ToUpper().Equals("S"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n Seleccione ID, Curso: ");
                curso[int.Parse(Console.ReadLine())].AgregarAlumno(new Alumno());

                Console.WriteLine("\n Ingrese S para continuar con la carga de ALUMNOS. Cualquier otra tecla para finalizar");
                sigue = char.Parse(Console.ReadLine());
            }
        }

        static void AgregarNotaAlumnos(List<Curso> lista_curso)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Seleccione Curso");

            Console.ForegroundColor = ConsoleColor.Cyan;
            ListarCurso(lista_curso);

            Console.WriteLine("\n");
            int opcion_curso = int.Parse(Console.ReadLine());

            if (lista_curso[opcion_curso].List_objAlu.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Seleccione Alumno \n");

                for (int i = 0; i < lista_curso[opcion_curso].List_objAlu.Count; i++)
                {
                    Console.WriteLine($"{i}- {lista_curso[opcion_curso].List_objAlu[i].ToString()} \n ");
                }

                int opcion_alumno = int.Parse(Console.ReadLine());

                do
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n Ingrese nota: ");

                    double nota = double.Parse(Console.ReadLine());

                    lista_curso[opcion_curso].List_objAlu[opcion_alumno].AsociarNota(lista_curso[opcion_curso].IdCurso, nota, lista_curso[opcion_curso].List_objAlu[opcion_alumno].IdAlumno);

                    Console.WriteLine("\n Desea seguir agregando notas? SI/NO");

                } while ("si".Equals(Console.ReadLine(), StringComparison.InvariantCultureIgnoreCase));

                lista_curso[opcion_curso].List_objAlu[opcion_alumno].CalcularPromedio();
            }

            else
            {
                Console.WriteLine("No contiene ningun alumno para cargar nota");
            }

        }

        static void Desaprobados(List<Curso> curso)
        {
            foreach (Curso li in curso)
            {
                Console.WriteLine(li.ToString());
                foreach (Alumno al in li.List_objAlu)
                {
                    if (al.Promedio_Final < 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\n {al.ToString()} ----  Desaprobado. Promedio es: {al.Promedio_Final} ");
                    }
                }
                Console.WriteLine($"\n\n");
            }
        }

        //LISTAR CURSOS 

        public static void ListarCurso(List<Curso> objLista)
        {
            foreach (Curso cursos in objLista)
            {
                Console.WriteLine(cursos.ToString());
            }
        }
    }
}

