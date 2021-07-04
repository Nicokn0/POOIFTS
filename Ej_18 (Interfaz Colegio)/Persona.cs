using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_18__Interfaz_Colegio_
{
   public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private string fecha_naciemiento;
        private int dni;
        private int age;



        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Age { get => age; set => age = value; }
        public string Fecha_naciemiento { get => fecha_naciemiento; set => fecha_naciemiento = value; }
        public int Dni { get => dni; set => dni = value; }

        public Persona()
        {
            

            Console.Write("\n Ingrese Nombre: ");
            nombre = Console.ReadLine();

            Console.Write("\n Ingrese Apellido: ");
            apellido = Console.ReadLine();

            Console.Write("\n Ingrese DNI: ");
            Dni =int.Parse( Console.ReadLine());

            Console.Write("\n Ingrese Fecha de nacimiento DD / MM / yyyy : ");
            fecha_naciemiento = Console.ReadLine();


        }

        public override string ToString()
        {
            return ($"\n Nombre: {nombre} \n Apellido: {apellido} \n DNI: {Dni} ");
        }

      


    }
}
