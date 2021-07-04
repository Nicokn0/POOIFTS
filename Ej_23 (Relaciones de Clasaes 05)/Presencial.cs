using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_23__Relaciones_de_Clasaes_05_
{
    class Presencial : Alumno
    {

        private int inasistencias;

        public int Inasistencias { get => inasistencias; set => inasistencias = value; }

        public Presencial()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\n Ingrese las faltas del alumno: ");
            Inasistencias = int.Parse(Console.ReadLine());
        }

        public override void Aprobado()
        {
            string mensaje = "";


            if (Inasistencias > 5 || ObtenerPromedio() < 7)
            {
                mensaje = $"El alumno {Nombre} Esta desapobado su promedio fue de {ObtenerPromedio()} y sus faltas fueron {Inasistencias}";
                ContRep++;
            }

            Console.WriteLine(mensaje);

        }
    }
}
