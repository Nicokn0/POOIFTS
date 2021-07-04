using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_23__Relaciones_de_Clasaes_05_
{
    class Curso
    {
        private string nombreCurso;
        private List<Alumno> listaAlumnos = new List<Alumno>();

        public string NombreCurso { get => nombreCurso; set => nombreCurso = value; }

        public Curso()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n Ingresar nombre de curso: ");
            NombreCurso = Console.ReadLine();
        }

        public void CrearAlumno()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine($"\n 1. Alumno Presencial \n 2. Alumno Virtual");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    listaAlumnos.Add(new Presencial());
                }
                else if (opcion == 2)
                {
                    listaAlumnos.Add(new Virtual());
                }

            } while (opcion < 1 && opcion > 2);


        }

        public void AlumnosReprobados()
        {
            foreach (Alumno li_alumno in listaAlumnos)
            {
                li_alumno.Aprobado();
            }
            Console.WriteLine($"\n En el curso {this.NombreCurso} hay {Alumno.ContRep} alumnos reprobados");
            Alumno.ContRep = 0;
        }

        public void MayorPromedio()
        {


            if (listaAlumnos.Count > 0)
            {
                Alumno objalumno = listaAlumnos[0];

                foreach (Alumno list_alum in listaAlumnos)
                {
                    if (objalumno.ObtenerPromedio() < list_alum.ObtenerPromedio())
                    {
                        objalumno = list_alum;
                    }
                }

                Console.WriteLine($"\n El alumno con mayor promedio es {objalumno.Nombre} con un promedio de {objalumno.ObtenerPromedio()}");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n No hay alumnos cargados, no se puede sacar el promedio");
            }

        }


    }
}
