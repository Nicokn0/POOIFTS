using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_29__Trabajado_en_clase_04_
{
    class Abertura
    {
        private static int cantidadAberturas;

        protected int alto;
        protected int ancho;

        public static int CantidadAberturas { get => cantidadAberturas; set => cantidadAberturas = value; }

        public int Superficie()
        {
            return (this.alto * this.ancho);
        }

        public Abertura()
        {
            Console.WriteLine("Por favor ingrese el alto de la abertura");
            this.alto = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingrese el ancho de la abertura");
            this.ancho = int.Parse(Console.ReadLine());
            cantidadAberturas++;
            Console.Write("\n");
        }

        public override string ToString()
        {
            return ($"alto: {this.alto}\nancho: {this.ancho}\n");
        }
    }
}
