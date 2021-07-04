using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_25_Relaciones_de_Clases_07_
{
    class Administrativo: Empleado
    {
        private double horasExtras;

        public double HorasExtras { get => horasExtras; set => horasExtras = value; }

        public Administrativo()
        {
            Console.Write("\n Ingrese horas extras trabajada: ");
            HorasExtras = double.Parse(Console.ReadLine());
        }

        public override double CalcularSueldo()
        {
            return SueldoBasico + (HorasExtras * 50);
        }

        public override string ToString()
        {
            return $"Administrativo. {base.ToString()}";
        }
    }
}
