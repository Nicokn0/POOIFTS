using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_22__Relaciones_de_Clases_04_
{
    class Destino
    {
        /*  De cada destino al que llegan se conoce localidad, provincia y km. a los que dista 
            desde la empresa. 
        
        El costo del envío se establece cobrando $15 si la distancia es hasta 100 km, $25 hasta 400 km y $40 
            para distancias mayores, se le suman además $2 por kg ó fracción. Definir las clases necesarias y escribir los métodos 
            para programar los siguientes casos de uso: */
      
        
        private string localidad;
        private string provincia;
        private int kilometros;
        private List<Encomienda> listaEncomienda = new List<Encomienda>();

        public string Localidad { get => localidad; set => localidad = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public int Kilometros { get => kilometros; set => kilometros = value; }
        internal List<Encomienda> ListaEncomienda { get => listaEncomienda; set => listaEncomienda = value; }

        public Destino()
        {
            Console.WriteLine("Ingrese Provincia");
            this.provincia = Console.ReadLine();

            Console.WriteLine("Ingrese Localidad");
            this.localidad = Console.ReadLine();

            Console.WriteLine("A cuantos kilometros se sitúa de la empresa");
            this.kilometros = int.Parse(Console.ReadLine());

        }

        public override string ToString()
        {
            return $"{Localidad} - {Provincia}";
        }
    }
}
