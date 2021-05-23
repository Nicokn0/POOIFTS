using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_10__Colecciones_Biblioteca_
{
    class Libro
    {

        private string nombre_libro;
        private bool devolucion_libro = false;
        private bool pedir_libro = false;
        private int codigo_libro;
        private string categoria;


        public int Codigo_libro { get => codigo_libro; set => codigo_libro = value; }
        public bool Devolucion_libro { get => devolucion_libro; set => devolucion_libro = value; }
        public bool Pedir_libro { get => pedir_libro; set => pedir_libro = value; }
        public string Nombre_libro { get => nombre_libro; set => nombre_libro = value; }

        public Libro()
        {
            IngresarDatos();

        }

        public override string ToString()
        {
            if (pedir_libro)
            {
                return ($"--- El libro fue prestado ---\n Código:{this.codigo_libro} \n Nombre: {this.nombre_libro} \n Categoria: {this.categoria} ");
            }
            else
            {
                return ($"--- El libro se encuentra disponible ---\n Código:{this.codigo_libro} \n Nombre: {this.nombre_libro} \n Categoria: {this.categoria} ");

            }

        }

        public void IngresarDatos()
        {
            Console.Write("Ingrese el nombre del libro a registrar en la biblioteca: ");
            this.Nombre_libro = Console.ReadLine();

            Console.Write("Ingrese categoria del libro a registrar en la biblioteca: ");
            this.categoria = Console.ReadLine();


            Console.Write("Ingrese código númerico del libro a registrar en la biblioteca: ");
            this.codigo_libro = int.Parse(Console.ReadLine());

        }


    }
}
