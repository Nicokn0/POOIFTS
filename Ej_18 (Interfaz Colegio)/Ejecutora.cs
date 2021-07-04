using System;
using System.Collections.Generic;
using System.Linq;

namespace Ej_18__Interfaz_Colegio_
{
    class Ejecutora
    {

        /* 
         
            Dadas las tres clases que se describen a continuación se pide crear el Diagrama de clase correspondiente 
            • Persona 
            Tiene los atributos nombre string, apellido string, fechaNacimiento Date , dni Integer y los métodos edad() que calcula la 
            edad de la persona, y además de los métodos públicos para trabajar con los atributos correspondientes. 

            • Alumno 
            Hereda de persona e incorpora el número de legajo int, fecha de ingreso y egreso ambas del tipo Date.

            • Docente
            Hereda de Persona e incorpora el atributo número de legajo string, fecha de ingreso a la institución Date y los métodos 
            aniosDocente() que calcula los años que lleva como docente y los métodos públicos para trabajar con los atributos 
            correspondientes

            Se pide realizar la carga de un lote de alumnos y docentes a través de un menú e imprimir todos sus atributos incluyendo los valores 
            calculados (métodos)

            Las clases instánciales son únicamente Alumno y Docente

            Definir un ordenamiento natural de Alumnos y Docentes dado por la edad ascendente.
            Definir un ordenamiento no natural de Alumnos dado por fecha de ingreso ascendente
            Definir un ordenamiento no natural de docentes dado por el número de legajo

            Crear una interface llamada Recreo que tendrá que implementar el método lugar de recreo. En el caso de los alumnos enviará el 
            mensaje string “Recreo en patio”, mientras que la implementación en profesores será un mensaje “Recreo en sala de profesores”
         
         */


        static void Main(string[] args)
        {

            List<Alumno> ObjAlumno = new List<Alumno>();
            List<Docente> ObjDocente = new List<Docente>();

          
            Menu(ObjAlumno, ObjDocente);

        }


        static void Menu(List <Alumno> objAlumno, List<Docente> objDocente) 
        {
            int opcion = 0;

            do
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                string msj1 = ("\n 1. Agregar Alumno \n 2. Agregar Docente  \n 3. Ordenamiento por Edad Docentes y alumnos \n 4. Ordenamiento Alumnos por fecha de ingreso \n 5. Ordenamiento Docentes por Numero Legajo \n 6. Salir ");
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine(msj1);
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        AgregarAlumno(objAlumno);

                        break;

                    case 2:

                        AgregarDocente(objDocente);

                        break;
                    case 3:

                        OrdenamientoEdad(objAlumno , objDocente);

                        break;

                    case 4:

                        OrdenamientoFecha(objAlumno);

                        break;

                    case 5:

                        Ordenamientolegajo(objDocente);

                        break;

                    case 6:

                        Console.WriteLine("FIN DEL PROGRAMA");

                        break;

                    default:

                        Console.WriteLine("Opcion incorrecta, vuelva a ingresar opción");
                        break;
                }

            } while (opcion != 6);

        }

        static void AgregarAlumno (List<Alumno> objAlumno)
        {
            char sigue = 'S'; 

            Console.ForegroundColor = ConsoleColor.Cyan;


            while (sigue.ToString().ToUpper().Equals("S"))
            {
                objAlumno.Add(new Alumno ());

                Console.WriteLine("\n Ingrese S para continuar con la carga de Alumnos. Cualquier otra tecla para finalizar");
                sigue = char.Parse(Console.ReadLine());

            }



           }
     
        static void AgregarDocente(List<Docente> objDocente)
        {
            char sigue = 'S';

            Console.ForegroundColor = ConsoleColor.DarkRed;

            while (sigue.ToString().ToUpper().Equals("S"))
            {
                objDocente.Add(new Docente());

                Console.WriteLine("\n Ingrese S para continuar con la carga de DOCENTES. Cualquier otra tecla para finalizar");
                sigue = char.Parse(Console.ReadLine());

            }
        }

        static void OrdenamientoEdad(List<Alumno> objAlumno, List<Docente> objDocente)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nVer Lista \n 1. Docentes \n 2. Lista Alumnos \n 3. Regresar Menu");
            int opc = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            switch (opc)
            {
                 
                case 1:
                   
                    Console.WriteLine("\n Lista de DOCENTES INGRESADOS \n ");


                    foreach (Docente listdocente in objDocente)
                    {
                        Console.WriteLine($" {listdocente.ToString()} \n");

                    }

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n Lista ORDENADA POR EDAD");

                    objDocente.Sort();

                    foreach (Docente listdocente in objDocente)
                    {
                        Console.WriteLine($" {listdocente.ToString()} \n");

                    }


                    break;

                case 2:

                    Console.WriteLine("Lista de ALUMNOS ingresados al sistema \n");

                    foreach (Alumno listalumno in objAlumno)
                    {
                        Console.WriteLine($" {listalumno.ToString()} \n");

                    }

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Lista Ordenada por EDAD");

                    objAlumno.Sort();

                    foreach (Alumno listalumno in objAlumno)
                    {
                        Console.WriteLine($" {listalumno.ToString()} \n");

                    }

                    break;

                case 3:
                    Console.WriteLine("Fin de listas. Regreso a Menu principal");
                    break;

                default:

                    Console.WriteLine("opción Incorecta");
                    break;
            }
           

        }

        static void OrdenamientoFecha (List<Alumno> objAlumno)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (Alumno listalumno in objAlumno)
            {
                Console.WriteLine($" {listalumno.ToString()} \n");

            }

            objAlumno.Sort(delegate (Alumno x, Alumno y)
            {
                return x.Tiempo_escuela.CompareTo(y.Tiempo_escuela);
            });

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n Lista Ordenada por fecha de ingreso a la escuela \n");

          

            foreach (Alumno listdocente in objAlumno)
            {
                Console.WriteLine($" {listdocente.ToString()} \n");

            }
        }

        static void Ordenamientolegajo(List<Docente> objDocente)
        {
            Console.WriteLine("\n Lista de DOCENTES INGRESADOS \n ");


            foreach (Docente listdocente in objDocente)
            {
                Console.WriteLine($" {listdocente.ToString()} \n");
            }

            Console.WriteLine("Lista Ordenada por NÚMERO DE LEGAJO ");


           objDocente = objDocente.OrderBy(p => p.Num_legajo).ToList();

            foreach (Docente listdocente in objDocente)
            {
                Console.WriteLine($" {listdocente.ToString()} \n");

            }
        }
    }
}
