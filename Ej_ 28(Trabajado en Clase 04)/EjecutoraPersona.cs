using System;
using System.Collections.Generic;

namespace Ej__28_Trabajado_en_Clase_04_
{
    class EjecutoraPersona
    {
        static void Main(string[] args)
        {
            List<Persona> listaDePersonas = new List<Persona>();
            string continuar = "";
            Console.WriteLine("Ingrese cualquier valor para agregar una persona <<0- para terminar>>");
            continuar = Console.ReadLine();



            while (!continuar.Equals("0"))
            {
                // Persona objPersona = new Persona();

                listaDePersonas.Add(new Persona());
                Console.WriteLine("Ingrese cualquier valor para agregar una persona <<0- para terminar>>");
                continuar = Console.ReadLine();

            }
            /*
            string editar = "";
            for (int i =0; i< listaDePersonas.Count; i++)
            {
                Console.WriteLine(listaDePersonas[i].ToString());
                Console.WriteLine("Quiere editar alguna de los valores <<S - otro valor para omitir>>");
                editar = Console.ReadLine();

                if (editar.Equals("S"))
                {
                    Console.WriteLine("Ingrese el nuevo nombre");
                    listaDePersonas[i].Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el nuevo apellido");
                    listaDePersonas[i].Apellido = Console.ReadLine();
                }
            }
            */

            string editar = "";
            foreach (Persona auxiliarPesona in listaDePersonas)
            {
                Console.WriteLine(auxiliarPesona.ToString());
                Console.WriteLine("Quiere editar alguna de los valores <<S - otro valor para omitir>>");
                editar = Console.ReadLine();

                if (editar.Equals("S"))
                {
                    Console.WriteLine("Ingrese el nuevo nombre");
                    auxiliarPesona.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el nuevo apellido");
                    auxiliarPesona.Apellido = Console.ReadLine();
                }
            }

            /*
            for (int i = 0; i < listaDePersonas.Count; i++)
            {
                Console.WriteLine(listaDePersonas[i].ToString());
               
            }
            */
            foreach (Persona objPer in listaDePersonas)
            {
                Console.WriteLine(objPer.ToString());
                Console.WriteLine($"{objPer.Apellido} - {objPer.Documento}");

            }
        }
    }
}
