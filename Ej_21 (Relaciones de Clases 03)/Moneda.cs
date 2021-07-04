using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_21__Relaciones_de_Clases_03_
{
    /*
      costo (en la moneda de origen), precio de venta (en pesos)
      Además la empresa tiene una lista con las monedas 
        extranjeras con las que opera, de las que se conoce la denominación de la moneda y la cotización.
     
     */
    class Moneda
    {
        private string denominacion;
        private double cotizacion;
        private double valor_auto;
        private double precio_venta;
        private double precio_final;
        private static double ganancias_final;
        private int cont;


        private List<Moneda> listaMoneda = new List<Moneda>();

        public string Denominacion { get => denominacion; set => denominacion = value; }
        public double Cotizacion { get => cotizacion; set => cotizacion = value; }
        public double Valor_auto { get => valor_auto; set => valor_auto = value; }
        public double Precio_final { get => precio_final; set => precio_final = value; }
        internal List<Moneda> ListaMoneda { get => listaMoneda; set => listaMoneda = value; }
        public static double Ganancias_final { get => ganancias_final; set => ganancias_final = value; }
        public double Precio_venta { get => precio_venta; set => precio_venta = value; }
        public  int Cont { get => cont; set => cont = value; }

        public Moneda (int contadormone)
        {
            Console.Write("\n Ingrese MONEDA: ");
            this.denominacion = Console.ReadLine();
            this.cont = contadormone;
        }

  

        public void MostrarMonedasIngresadas (List<Moneda> objmoneda)
        {
            if (ListaMoneda.Count > 0)
            {
                foreach (Moneda monedas in objmoneda)
                {
                    Console.WriteLine(monedas.ToString());
                }
            }
            else
            {
                Console.WriteLine("No ingreso ningun tipo de monedas");
            }
        }

        public double  Ganancias (double precio_venta, double precio_final)
        {
            GananciasFinal(precio_venta, precio_final);
            
            return  precio_venta - precio_final ;
        }
      
        public double GananciasFinal (double precio_venta, double precio_final)
        {
            this.Precio_venta = precio_venta;
            this.Precio_final = precio_final;

            ganancias_final += (precio_venta - precio_final);

            return ganancias_final;
        }

        public override string ToString()
        {
            return ($"ID Moneda: {cont} \t Moneda: {this.denominacion} ");
        }
    }
}
