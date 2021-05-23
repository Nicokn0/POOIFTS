using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_17_Clases_Abst_Computadora_
{
    public abtract class Computadora
    {
        private string microprocesador;
        private float velocidad;
        private int tamañoRam;
        private int cont_compu;



        public string Microprocesador { get => microprocesador; set => microprocesador = value; }
        public float Velocidad { get => velocidad; set => velocidad = value; }
        public int TamañoRam { get => tamañoRam; set => tamañoRam = value; }


        public Computadora()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write("\n INGRESE EL MICROPOCESADOR DEL DISPOSITIVO: ");
            this.microprocesador = Console.ReadLine();

            Console.Write("\n INGRESE la velocidad DEL DISPOSITIVO: ");
            this.velocidad = float.Parse(Console.ReadLine());

            Console.Write("\n INGRESE el TAMAÑO DE LA MEMORIA RAM: ");
            this.tamañoRam = int.Parse(Console.ReadLine());


        }


        public override string ToString()
        {
            return ($"\n Microprocesador: { microprocesador} \t Velocidad:{ velocidad} \t Tamaño RAM: { tamañoRam} ");
        }



        public abstract int Cont_Dispositivo();

    }
}
}
