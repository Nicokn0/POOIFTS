using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_08__Colecciones_Curso_
{
    class Curso
    {
        private int año_curso;
        private string nombre_curso;
        private string nombre_colegio;

        public int Año_curso { get => año_curso; set => año_curso = value; }
        public string Nombre_colegio { get => nombre_colegio; set => nombre_colegio = value; }
        public string Nombre_curso { get => nombre_curso; set => nombre_curso = value; }

        public Curso()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("--------------- Terciario IFTS N° 11 ------------ \n");

            Console.Write("Ingrese año del curso: ");
            this.año_curso = int.Parse(Console.ReadLine());

            Console.Write("Ingrese división del curso: ");
            this.nombre_curso = Console.ReadLine();
            Console.WriteLine("\n");
        }

        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return ($"\t \t -------------- {año_curso} {nombre_curso} ----------------------");
        }
    }
}
