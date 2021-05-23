using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_15__Herencia_Computadora_
{
    class Smartphone : Computadora
    {
        private string tipo_De_Pantalla;
        private int tamaño_Pantalla;
        private int cant_Chips;
        private int cant_Frecuencia;

        public Smartphone()
        {

            IngresoDatosSmartphone();


        }

        public override string ToString()
        {
            return ($" Dispositivo: Smartphone \n {base.ToString()} \n Tipo de Pantalla: {tipo_De_Pantalla} \t Tamaño de pantalla: {tamaño_Pantalla} \t Cantidad de chips: {cant_Chips} \t Cantidad de frecuencia: {cant_Frecuencia}");
        }

        public void IngresoDatosSmartphone()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Write("\n INGRESE TIPO DE PANTALLA: ");
            this.tipo_De_Pantalla = Console.ReadLine();

            Console.Write("\n INGRESE TAMAÑO DE PANTALLA: ");
            this.tamaño_Pantalla = int.Parse(Console.ReadLine());

            Console.Write("\n INGRESE CANTIDAD DE CHIPS: ");
            this.cant_Chips = int.Parse(Console.ReadLine());

            Console.Write("\n INGRESE CANTIDAD DE FRECUENCIA:  ");
            this.cant_Frecuencia = int.Parse(Console.ReadLine());



            Console.WriteLine("\n");
        }
    }
}
