using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_27__Trabajado_en_Clase_02_
{
    class Taxi
    {
        //creo una variable de clase para que tenga visibilidad entre todos los objetos de la misma
        private static int cantidadTaxis = 0;

        private string patente = "";
        private int numeroLicencia = 0;
        private int caducidadVTV = 2021;
        private double bajadaDeBandera = 500;
        public string Patente { get => patente; set => patente = value; }
        public int NumeroLicencia { get => numeroLicencia; set => numeroLicencia = value; }
        public double BajadaDeBandera { set => bajadaDeBandera = value; }

        public override string ToString()
        {
            string texto = "";
            texto = $"Patente:{this.patente}\tNúmero de licencia:{this.numeroLicencia}\tCaducidad VTV:{this.caducidadVTV}\t El valor de la baja de Bandera es: {this.bajadaDeBandera}";
            return texto;
        }

        public int CantidadDeTaxisCreados()
        {
            return cantidadTaxis;
        }

        public Taxi()
        {
            Console.WriteLine("Ingrese el número de patente");
            this.patente = Console.ReadLine();
            Console.WriteLine("Ingrese el número de licencia");
            this.numeroLicencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el año de caducidad del VTV");
            this.caducidadVTV = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la bajada de bandera");
            this.BajadaDeBandera = double.Parse(Console.ReadLine());

            cantidadTaxis++;
        }


        public Taxi(string auxPatente, int auxNumeroLicencia, int auxCaducidadVTV)
        {
            this.patente = auxPatente;
            this.numeroLicencia = auxNumeroLicencia;
            this.caducidadVTV = auxCaducidadVTV;

            cantidadTaxis++;
        }
    }
}
