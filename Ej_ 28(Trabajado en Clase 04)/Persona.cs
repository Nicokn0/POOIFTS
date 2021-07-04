using System;
using System.Collections.Generic;
using System.Text;

namespace Ej__28_Trabajado_en_Clase_04_
{
    class Persona
    {

        private string nombre;
        private string apellido;
        private int documento;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Documento { get => documento; set => documento = value; }

        public Persona()
        {
            Console.WriteLine("Ingrese el nombre de la persona");
            this.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido de la persona");
            this.apellido = Console.ReadLine();
            Console.WriteLine("Ingrese el documento de la persona");
            this.documento = int.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return ($"{this.nombre}, {this.apellido}, {this.documento} ");
        }
    }
}
