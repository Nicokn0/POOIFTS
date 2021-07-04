using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_21__Relaciones_de_Clases_03_
{
    /*
      Todo auto tiene marca, modelo, costo (en la moneda de origen), precio de venta (en pesos) y
        la cantidad de unidades en stock. La ganancia de cada auto se calcula restando el costo (debiendo 
        convertirlo de acuerdo a la cotización cargada) al precio de venta. 
     */
    class Auto
    { 
        private string marca;
        private string modelo;
        private double costo;
        private double ganancias; 
        private double venta_publico;
        private static int stock_auto;
       
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public double Costo { get => costo; set => costo = value; }
        public static int Stock_auto { get => stock_auto; set => stock_auto = value; }
        public double Venta_publico { get => venta_publico; set => venta_publico = value; }
        public double Ganancias { get => ganancias; set => ganancias = value; }
   

        public Auto()
        {
            Console.Write("\n Ingrese Marca del auto: ");
            this.marca = Console.ReadLine();

            Console.Write("\n Ingrese modelo del auto: ");
            this.modelo = Console.ReadLine();

            Console.WriteLine("\n");

            stock_auto++;
        }

        public override string ToString()
        {
            return ($"\n Auto: Modelo: {this.modelo} \n Marca: {this.marca} \n Valor Inicial: {this.costo} \n Valor en venta al publico: {this.venta_publico} \n Ganancias: ${this.ganancias} PESOS  \n ");
        }
    }
}
