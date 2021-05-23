using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_15__Herencia_Computadora_
{
    class Computadora
    {
        private string microprocesador;
        private float velocidad;
        private int tamañoRam;
        private static int cont_elementos_electronicos;

        public string Microprocesador { get => microprocesador; set => microprocesador = value; }
        public float Velocidad { get => velocidad; set => velocidad = value; }
        public int TamañoRam { get => tamañoRam; set => tamañoRam = value; }
        public static int Cont_elementos_electronicos { get => cont_elementos_electronicos; set => cont_elementos_electronicos = value; }


        public Computadora()
        {

            IngresoDatos();
            cont_elementos_electronicos++;
        }

        public override string ToString()
        {
            return ($"\t Microprocesador: {microprocesador} \t Velocidad:{velocidad} \t Tamaño RAM: {tamañoRam} \n");
        }

        public void IngresoDatos()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write("\n INGRESE EL MICROPOCESADOR DEL DISPOSITIVO: ");
            this.microprocesador = Console.ReadLine();

            Console.Write("\n INGRESE la velocidad DEL DISPOSITIVO: ");
            this.velocidad = float.Parse(Console.ReadLine());

            Console.Write("\n INGRESE el TAMAÑO DE LA MEMORIA RAM: ");
            this.tamañoRam = int.Parse(Console.ReadLine());


        }
    }
}
