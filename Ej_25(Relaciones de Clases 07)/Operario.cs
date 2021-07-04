using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_25_Relaciones_de_Clases_07_
{
    class Operario: Empleado
    {
        private double incentivo;

        public double Incentivo { get => incentivo; set => incentivo = value; }

        public Operario()
        {
            Console.Write("\n Ingrese incentivo: $ ");
            Incentivo = double.Parse(Console.ReadLine());
        }

        public override double CalcularSueldo()
        {
            return SueldoBasico + Incentivo;
        }

        public override string ToString()
        {
            return $"Operario. {base.ToString()}";
        }
    }
}
