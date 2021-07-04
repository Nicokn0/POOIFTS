using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_23__Relaciones_de_Clasaes_05_
{
    class Virtual: Alumno
    {

        private bool trabajoPractico;

        public bool TrabajoPractico { get => trabajoPractico; set => trabajoPractico = value; }

        public Virtual()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\n ¿El alumno aprobo el trabajo practico? SI/NO: ");
            string op = Console.ReadLine();

            if (op.Equals("si", StringComparison.InvariantCultureIgnoreCase))
            {
                TrabajoPractico = true;
            }
            else
            {
                TrabajoPractico = false;
            }
        }

        public override void Aprobado()
        {
            string mensaje = "";


            if (!TrabajoPractico || ObtenerPromedio() < 7)
            {
                mensaje = $"\n El alumno {Nombre}. Esta desapobado su promedio fue de {ObtenerPromedio()}. Su trabajo practico esta {((TrabajoPractico) ? "Aprobado" : "Reprobado")}";
                ContRep++;
            }

            Console.WriteLine(mensaje);
        }
    }
}
