using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_17_Clases_Abst_Computadora_
{
    class PcEscritorio : Computadora
    {
        private string tamaño_Gabinete;
        private bool tiene_Dvd = false;
        private bool tiene_Hdd = false;
        private int tamaño_Disco;

        private static int cont_PcEscritorio;
        public static int Cont_PcEscritorio { get => cont_PcEscritorio; set => cont_PcEscritorio = value; }
        public string Tamaño_Gabinete { get => tamaño_Gabinete; set => tamaño_Gabinete = value; }
        public bool Tiene_Dvd { get => tiene_Dvd; set => tiene_Dvd = value; }
        public bool Tiene_Hdd { get => tiene_Hdd; set => tiene_Hdd = value; }
        public int Tamaño_Disco { get => tamaño_Disco; set => tamaño_Disco = value; }

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



            Cont_Dispositivo();

            Console.WriteLine("\n");
        }

        public override int Cont_Dispositivo()
        {
            return cont_PcEscritorio++;
        }
    }
}
