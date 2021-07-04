using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_22__Relaciones_de_Clases_04_
{
    class Encomienda
    {
        /* Todas ellos tienen un número, remitente, 
            destinatario, destino y peso en kg. */
        private static int contador;
        private int nro;
        private string remitente;
        private string destinatario;
        private Destino objdestino;
        private double peso;

        public Encomienda(Destino d)
        {
            this.nro = contador;
            Console.WriteLine("Ingrese el remitente");
            this.remitente = Console.ReadLine();

            Console.WriteLine("Ingrese destinatario");
            this.destinatario = Console.ReadLine();

            Console.WriteLine("Agregue peso de la encomienda");
            this.Peso = double.Parse(Console.ReadLine());

            this.objdestino = d;

            contador++;
        }

        public double Peso { get => peso; set => peso = value; }
        public int Nro { get => nro; set => nro = value; }
        public string Destinatario { get => destinatario; set => destinatario = value; }

        public void CostoEnvio()
        {
            double costo = 0;

            if (objdestino.Kilometros >= 0 && objdestino.Kilometros <= 100)
            {
                costo = 15;
            }
            else if (objdestino.Kilometros >= 100 && objdestino.Kilometros <= 400)
            {
                costo = 25;
            }
            else
            {
                costo = 40 + (Peso * 2);
            }

            Console.WriteLine($"El costo de la encomienda es de ${costo}");
        }

        public override string ToString()
        {
            return $"{this.Nro}- {this.destinatario}";
        }

    }
}
