using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_15__Herencia_Computadora_
{
    class PcEscritorio : Computadora
    {
        private string tamaño_Gabinete;
        private bool tiene_Dvd = false;
        private bool tiene_Hdd = false;
        private int tamaño_Disco;

        public PcEscritorio()
        {

            IngresoDatosPcEscritorio();


        }

        public override string ToString()
        {
            string mensajeHDD = "HDD: ";
            string mensajeDVD = "DVD: ";

            if (this.tiene_Dvd)
            {
                mensajeDVD += "DVD: SI";
            }
            else
            {
                mensajeDVD += "DVD: NO";
            }

            if (this.tiene_Hdd)
            {
                mensajeHDD += "HDD: SI";
            }
            else
            {
                mensajeHDD += "HDD: NO";
            }
            return ($" Dispositivo: PC ESCRITORIO \n {base.ToString()} \n Tamaño del Gabinete:{tamaño_Gabinete} \t TAMAÑO DEL DISCO: {tamaño_Disco}  \t {mensajeDVD} \t {mensajeHDD} ");
        }

        public void IngresoDatosPcEscritorio()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Write("\n INGRESE TAMAÑO GABINETE: ");
            this.tamaño_Gabinete = Console.ReadLine();

            Console.Write("\n INGRESE TAMAÑO DEL DISCO: ");
            this.tamaño_Disco = int.Parse(Console.ReadLine());

            Console.Write("\n Indique escribiendo SI o NO si tiene reproductor de DVD: ");
            if ("si".Equals(Console.ReadLine(), StringComparison.InvariantCultureIgnoreCase))
            {
                this.tiene_Dvd = true;

            }

            Console.Write("\n Indique escribiendo SI o NO si tiene Disco Solido: ");
            if ("si".Equals(Console.ReadLine(), StringComparison.InvariantCultureIgnoreCase))
            {
                this.tiene_Hdd = true;

            }


            Console.WriteLine("\n");
        }


    }
}
