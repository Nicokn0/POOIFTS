using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_19__Relación_Clases_01_
{
    class Domicilio
    {
        /*
        La clase Domicilio Tiene los atributos idDomicilio int, calle String, numero String, localidad String, provincia String. 

       Tiene un método domicilio() El método domicilio devuelve los datos formateados del domicilio .

        */
        private int idDomicilio;
        private static int cont;
        private string calle;
        private string numero;
        private string localidad;
        private string provincia;

       

        public int IdDomicilio { get => idDomicilio; set => idDomicilio = value; }
        public string Calle { get => calle; set => calle = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public string Provincia { get => provincia; set => provincia = value; }

        public Domicilio()
        {
         
            Console.Write("Ingrese calle: ");
            this.calle = Console.ReadLine();

            Console.Write("\n Ingrese Número: ");
            this.numero = Console.ReadLine();

            Console.Write("\n Ingrese localidad: ");
            this.localidad = Console.ReadLine();

            Console.Write("\n Ingrese provincia: ");
            this.provincia = Console.ReadLine();
            Console.WriteLine("\n");

            this.idDomicilio = cont++;

           domicilio();
        }

        public string domicilio ()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
           return($"\n ID: {idDomicilio} Calle: {calle} \t Número: {numero} \t Localidad: {localidad} \t Prov: {provincia} \n");
        }

  
    }
}
