using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_29__Trabajado_en_clase_04_
{
    class Ventana: Abertura
    {

        private bool dobleVidrio = false;

        // preparo el metodo doble vidrio para ser usado desde la clase ejecutora
        public string TieneDobleVidrio()
        {
            if (dobleVidrio)
            {
                return ("Tiene doble vidrio");
            }
            else
            {
                return ("No tiene doble vidrio");
            }

        }

        public override string ToString()
        {
            return ($"{base.ToString()}{this.TieneDobleVidrio()}\n");
        }

        public Ventana()
        {
            Console.WriteLine("Por favor ingrese si la ventana tiene doble vidrio, <<Si>>/<<NO>>");
            if (Console.ReadLine().ToUpper().Equals("SI")) ;
            {
                dobleVidrio = true;
            }
            Console.Write("\n");

        }
    }
}
