using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_25_Relaciones_de_Clases_07_
{
    class Profesional: Empleado
    {

        public override double CalcularSueldo()
        {
            return (SueldoBasico * 1.10);
        }
    }
}

