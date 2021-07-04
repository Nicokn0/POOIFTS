using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_29__Trabajado_en_clase_04_
{
    class Puerta: Abertura
    {


        private int cantidadBisagras;
        private string tipodePuerta = "No definida";

        public Puerta()
        {
            Console.WriteLine("Por favor ingrese la cantidad de bisagras");
            this.cantidadBisagras = int.Parse(Console.ReadLine());

        }

        public override string ToString()
        {
            return ($"Tipo de puerta{this.tipodePuerta}\n{base.ToString()}superficie: {this.Superficie()}\ncantidad de bisagras: {this.cantidadBisagras}\n");
        }

        public Puerta(string tipoDePuerta, int cantidadDeBisagras)
        {
            this.tipodePuerta = tipoDePuerta;
            this.cantidadBisagras = cantidadDeBisagras;
        }
    }
}
