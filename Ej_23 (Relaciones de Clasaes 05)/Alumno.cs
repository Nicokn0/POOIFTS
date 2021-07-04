using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_23__Relaciones_de_Clasaes_05_
{
    public abstract class Alumno
    {
        private string nombre;
        private double notaPrimerParcial;
        private double notaSegundoParcial;
        private static int contRep;

        public string Nombre { get => nombre; set => nombre = value; }
        public double NotaPrimerParcial { get => notaPrimerParcial; set => notaPrimerParcial = value; }
        public double NotaSegundoParcial { get => notaSegundoParcial; set => notaSegundoParcial = value; }
        public static int ContRep { get => contRep; set => contRep = value; }

        public Alumno()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("\n Ingrese nombre del alumno: ");
            Nombre = Console.ReadLine();

            Console.Write("\n Ingrese nota del primer parcial: ");
            NotaPrimerParcial = double.Parse(Console.ReadLine());

            Console.Write("\n Ingrese nota del segundo parcial: ");
            NotaSegundoParcial = double.Parse(Console.ReadLine());
        }

        public abstract void Aprobado();

        public double ObtenerPromedio()
        {
            return (notaPrimerParcial + notaSegundoParcial) / 2;
        }

    }
}
